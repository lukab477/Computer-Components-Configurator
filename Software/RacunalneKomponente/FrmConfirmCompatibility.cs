using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace RacunalneKomponente
{
    public partial class FrmConfirmCompatibility : Form
    {
        private string connectionString = "Server=31.147.206.65;Database=RWA2517_DB;User Id=RWA2517_User;Password=pV_Y4JPk;";
        private DataTable konfiguracijaDT;
        private int konfiguracijaId;
        public FrmConfirmCompatibility()
        {
            InitializeComponent();
            UcitajKonfiguraciju();
        }

        private void UcitajKonfiguraciju()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT TOP 1 KonfiguracijaId, Procesor, Graficka, MaticnaPloca, RAM, Pohrana, Napajanje, Kuciste, UkupnaCijena, Email, Dostupno
                             FROM KorisnikoveKonfiguracije
                             WHERE Status = 'Na čekanju' AND ISNULL(Procesor, '') <> ''
                             ORDER BY KonfiguracijaId ASC";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    konfiguracijaDT = new DataTable();
                    da.Fill(konfiguracijaDT);
                    dgvConfigurationOverview.DataSource = konfiguracijaDT;

                    if (konfiguracijaDT.Rows.Count > 0)
                    {
                        konfiguracijaId = Convert.ToInt32(konfiguracijaDT.Rows[0]["KonfiguracijaId"]);
                    }
                }
            }
        }
        private void PosaljiMail(string status)
        {
            if (konfiguracijaDT.Rows.Count == 0) return;

            string email = konfiguracijaDT.Rows[0]["Email"].ToString();
            string subject = status == "Odbijena" ? "Vaša konfiguracija je odbijena" : "Vaša konfiguracija je potvrđena";
            StringBuilder body = new StringBuilder();
            body.AppendLine($"Poštovani,");
            body.AppendLine($"Vaša konfiguracija je {status.ToLower()}.");
            body.AppendLine();
            body.AppendLine("Popis komponenti:");
            foreach (DataColumn col in konfiguracijaDT.Columns)
            {
                if (col.ColumnName != "Id" && col.ColumnName != "Email" && col.ColumnName != "UkupnaCijena")
                    body.AppendLine($"{col.ColumnName}: {konfiguracijaDT.Rows[0][col]}");
            }
            body.AppendLine($"Ukupna cijena: {konfiguracijaDT.Rows[0]["UkupnaCijena"]} €");
            body.AppendLine();
            body.AppendLine("Komentar zaposlenika:");
            body.AppendLine(txtComment.Text);

            if(konfiguracijaDT.Rows[0]["Dostupno"].ToString() == "False")
            {
                body.AppendLine("Napomena:");
                body.AppendLine("Trenutno jedna ili više komponenti nije dostupna. Čim sve komponente postanu dostupne bit ćete obaviješteni.");
            }
            

            SmtpClient client = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("luka.bo2004@gmail.com", "kzga wrtw byul abps"),
                EnableSsl = true,
            };

            MailMessage mail = new MailMessage("luka.bo2004@gmail.com", email, subject, body.ToString());
            client.Send(mail);
        }

        private void AzurirajStatus(string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE KorisnikoveKonfiguracije SET Status = @Status WHERE KonfiguracijaId = @KonfiguracijaId";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@KonfiguracijaId", konfiguracijaId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            var workerView = new frmWorkerView();
            workerView.Show();
            this.Close();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            AzurirajStatus("Odbijeno");
            PosaljiMail("Odbijena");
            MessageBox.Show("Konfiguracija je odbijena i korisnik je obaviješten.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            AzurirajStatus("Potvrđeno");
            PosaljiMail("Potvrđena");
            MessageBox.Show("Konfiguracija je potvrđena i korisnik je obaviješten.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
