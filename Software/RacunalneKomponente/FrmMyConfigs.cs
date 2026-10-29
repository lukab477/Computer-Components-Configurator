using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacunalneKomponente
{
    public partial class FrmMyConfigs : Form
    {
        private string connectionString = "Server=31.147.206.65;Database=RWA2517_DB;User Id=RWA2517_User;Password=pV_Y4JPk;";

        public FrmMyConfigs()
        {
            InitializeComponent();
            UcitajMojeKonfiguracije();
        }

        private void UcitajMojeKonfiguracije()
        {
            string email = KorisnikPrijava.LastEnteredEmail;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Nije pronađen email korisnika.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT KonfiguracijaId, Procesor, Graficka, MaticnaPloca, RAM, Pohrana, Napajanje, Kuciste, UkupnaCijena, Status
                                     FROM KorisnikoveKonfiguracije
                                     WHERE Email = @Email AND ISNULL(Procesor, '') <> ''";

                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@Email", email);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMyConfigs.DataSource = dt;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCustomerView customerView = new frmCustomerView();
            customerView.Show();
            this.Close();
        }

        private void dgvMyConfigs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvMyConfigs.Rows[e.RowIndex];
                var konfiguracija = new List<PrikazKomponente>
        {
            new PrikazKomponente { Kategorija = "Procesor", Naziv = row.Cells["Procesor"].Value?.ToString() ?? "", Proizvođač = "", Specifikacije = "", Cijena = 0 },
            new PrikazKomponente { Kategorija = "Graficka kartica", Naziv = row.Cells["Graficka"].Value?.ToString() ?? "", Proizvođač = "", Specifikacije = "", Cijena = 0 },
            new PrikazKomponente { Kategorija = "Maticna ploca", Naziv = row.Cells["MaticnaPloca"].Value?.ToString() ?? "", Proizvođač = "", Specifikacije = "", Cijena = 0 },
            new PrikazKomponente { Kategorija = "RAM", Naziv = row.Cells["RAM"].Value?.ToString() ?? "", Proizvođač = "", Specifikacije = "", Cijena = 0 },
            new PrikazKomponente { Kategorija = "Pohrana", Naziv = row.Cells["Pohrana"].Value?.ToString() ?? "", Proizvođač = "", Specifikacije = "", Cijena = 0 },
            new PrikazKomponente { Kategorija = "Napajanje", Naziv = row.Cells["Napajanje"].Value?.ToString() ?? "", Proizvođač = "", Specifikacije = "", Cijena = 0 },
            new PrikazKomponente { Kategorija = "Kucište", Naziv = row.Cells["Kuciste"].Value?.ToString() ?? "", Proizvođač = "", Specifikacije = "", Cijena = 0 }
        };

                FrmGenerateReportCustomer reportForm = new FrmGenerateReportCustomer(konfiguracija);
                reportForm.Show();
            }
        }
    }
}
