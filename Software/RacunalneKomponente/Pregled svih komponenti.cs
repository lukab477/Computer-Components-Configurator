using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RacunalneKomponente
{
    public partial class Pregled_svih_komponenti : Form
    {
        private readonly string _cs =
               ConfigurationManager
                   .ConnectionStrings["RWA2517"]
                   .ConnectionString;
     
        public Pregled_svih_komponenti()
        {
            InitializeComponent();
            dgvPrikazKomponenata.CellValueChanged += dgvPrikazKomponenata_CellValueChanged;
            dgvPrikazKomponenata.CurrentCellDirtyStateChanged += dgvPrikazKomponenata_CurrentCellDirtyStateChanged;
            UcitajKomponente();
        }

        private void dgvPrikazKomponenata_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPrikazKomponenata.IsCurrentCellDirty)
            {
                dgvPrikazKomponenata.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvPrikazKomponenata_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPrikazKomponenata.Columns[e.ColumnIndex].Name == "Dostupno")
            {
                int komponentaId = Convert.ToInt32(dgvPrikazKomponenata.Rows[e.RowIndex].Cells["KomponentaID"].Value);
                bool novaVrijednost = Convert.ToBoolean(dgvPrikazKomponenata.Rows[e.RowIndex].Cells["Dostupno"].Value);

                using (var conn = new SqlConnection(_cs))
                using (var cmd = new SqlCommand("UPDATE Komponente SET Dostupno = @Dostupno WHERE KomponentaID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@Dostupno", novaVrijednost);
                    cmd.Parameters.AddWithValue("@ID", komponentaId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                var konfiguracije = OsvjeziDostupneKonfiguracije(komponentaId);

                foreach (var konf in konfiguracije)
                {
                    PosaljiMail(konf.KonfiguracijaID);
                    
                }

            }
        }


        private void UcitajKomponente()
        {
            dgvPrikazKomponenata.AllowUserToAddRows = false;
            dgvPrikazKomponenata.RowHeadersVisible = true;
            var dt = new DataTable();
            using (var conn = new SqlConnection(_cs))
            using (var da = new SqlDataAdapter(
                    "SELECT KomponentaID, Naziv, Dostupno FROM Komponente", conn))
            {
                da.Fill(dt);
            }
            dgvPrikazKomponenata.DataSource = dt;
        }

        public class KonfiguracijaInfo
        {
            public int KonfiguracijaID { get; set; }
            public string Email { get; set; }
            public decimal UkupnaCijena { get; set; }
        }

        public List<KonfiguracijaInfo> OsvjeziDostupneKonfiguracije(int komponentaID)
        {
            var rezultat = new List<KonfiguracijaInfo>();

            string connectionString = ConfigurationManager
                .ConnectionStrings["RWA2517"]
                .ConnectionString;

            string query = @"
                DECLARE @KomponentaID INT = @InputKomponentaID;

                DECLARE @Updated TABLE (
                    KonfiguracijaID INT
                );

                UPDATE K
                SET Dostupno = 1
                OUTPUT inserted.KonfiguracijaID INTO @Updated
                FROM KorisnikoveKonfiguracije K
                WHERE Dostupno = 0
                AND EXISTS (
                SELECT 1
                FROM Komponente c
                WHERE c.KomponentaID = @KomponentaID
                
                AND ISNULL((SELECT Dostupno FROM Komponente WHERE Naziv = K.Procesor), 0) = 1
                AND ISNULL((SELECT Dostupno FROM Komponente WHERE Naziv = K.Graficka), 0) = 1
                AND ISNULL((SELECT Dostupno FROM Komponente WHERE Naziv = K.MaticnaPloca), 0) = 1
                AND ISNULL((SELECT Dostupno FROM Komponente WHERE Naziv = K.RAM), 0) = 1
                AND ISNULL((SELECT Dostupno FROM Komponente WHERE Naziv = K.Pohrana), 0) = 1
                AND ISNULL((SELECT Dostupno FROM Komponente WHERE Naziv = K.Napajanje), 0) = 1
                AND ISNULL((SELECT Dostupno FROM Komponente WHERE Naziv = K.Kuciste), 0) = 1
                );

                SELECT KonfiguracijaID, Email, UkupnaCijena
                FROM KorisnikoveKonfiguracije
                WHERE KonfiguracijaID IN (SELECT KonfiguracijaID FROM @Updated);";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@InputKomponentaID", komponentaID);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rezultat.Add(new KonfiguracijaInfo
                        {
                            KonfiguracijaID = reader.GetInt32(0),
                            Email = reader.GetString(1),
                            UkupnaCijena = reader.GetDecimal(2)
                        });
                    }
                }
            }

            return rezultat;
        }

        private void dgvPrikazKomponenata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void PosaljiMail(int IDKonfiguracije)
        {
            string connectionString = ConfigurationManager
                .ConnectionStrings["RWA2517"]
                .ConnectionString;

            string query = @"SELECT TOP 1 * FROM KorisnikoveKonfiguracije
                    WHERE KonfiguracijaID = @IDKonfiguracije";

            DataTable konfiguracijaDT = new DataTable();

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@IDKonfiguracije", IDKonfiguracije);
                da.Fill(konfiguracijaDT);
            }

            

            string email = konfiguracijaDT.Rows[0]["Email"].ToString();
            string status = "Vaša konfiguracija je u potpunosti dostupna";

            string subject = status;

            StringBuilder body = new StringBuilder();
            body.AppendLine("Poštovani,");
            body.AppendLine($"Vaša konfiguracija je u potpunosti dostupna.");
            body.AppendLine();
            body.AppendLine("Popis komponenti:");

          
            foreach (DataColumn col in konfiguracijaDT.Columns)
            {
                string colName = col.ColumnName;
                if (colName != "KonfiguracijaID" && colName != "Email" && colName != "Dostupno")
                {
                    body.AppendLine($"{colName}: {konfiguracijaDT.Rows[0][col]}");
                }
            }

            body.AppendLine($"Ukupna cijena: {konfiguracijaDT.Rows[0]["UkupnaCijena"]} €");
            body.AppendLine();

            try
            {
                using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.Credentials = new NetworkCredential("luka.bo2004@gmail.com", "kzga wrtw byul abps");
                    client.EnableSsl = true;

                    MailMessage mail = new MailMessage("luka.bo2004@gmail.com", email, subject, body.ToString());
                    client.Send(mail);
                }

                
            }
            catch (Exception ex)
            {
            }
        }

        private void btnIzađi_Click(object sender, EventArgs e)
        {
            frmWorkerView frmWorkerView = new frmWorkerView();
            frmWorkerView.Show();
            this.Close();
        }
    }

    }

