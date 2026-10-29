using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RacunalneKomponente
{
    public partial class PovijestKonfiguracija : Form
    {
        private string connectionString = "Server=31.147.206.65;Database=RWA2517_DB;User Id=RWA2517_User;Password=pV_Y4JPk;";

        public PovijestKonfiguracija()
        {
            InitializeComponent();
            UcitajPotvrdjeneKonfiguracije();
            UcitajOdbijeneKonfiguracije();
        }

        private void UcitajPotvrdjeneKonfiguracije()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT KonfiguracijaId, Procesor, Graficka, MaticnaPloca, RAM, Pohrana, Napajanje, Kuciste, UkupnaCijena, Email
                                 FROM KorisnikoveKonfiguracije
                                 WHERE Status = 'Potvrđeno'";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvConfirmedConfigurations.DataSource = dt;
                }
            }
        }

        private void UcitajOdbijeneKonfiguracije()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT KonfiguracijaId, Procesor, Graficka, MaticnaPloca, RAM, Pohrana, Napajanje, Kuciste, UkupnaCijena, Email
                                 FROM KorisnikoveKonfiguracije
                                 WHERE Status = 'Odbijeno'";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDeclinedConfigurations.DataSource = dt;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWorkerView workerView = new frmWorkerView();
            workerView.Show();
            this.Close();
        }

        private void dgvConfirmedConfigurations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvConfirmedConfigurations.Rows[e.RowIndex];
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

                FrmGenerateReportWorker reportForm = new FrmGenerateReportWorker(konfiguracija);
                reportForm.Show();
            }
        }

        private void dgvDeclinedConfigurations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDeclinedConfigurations.Rows[e.RowIndex];
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

                FrmGenerateReportWorker reportForm = new FrmGenerateReportWorker(konfiguracija);
                reportForm.Show();
            }
        }
    }
}