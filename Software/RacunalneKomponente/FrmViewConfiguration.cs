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
using RacunalneKomponente.Models;

namespace RacunalneKomponente
{
    public partial class FrmViewConfiguration : Form
    {
        private string connectionString = "Server=31.147.206.65;Database=RWA2517_DB;User Id=RWA2517_User;Password=pV_Y4JPk;";
        private frmCreateConfiguration parentForm;
        private List<PrikazKomponente> konfiguracija;

        public FrmViewConfiguration(List<PrikazKomponente> komponente, frmCreateConfiguration parent)
        {
            InitializeComponent();
            konfiguracija = komponente;
            parentForm = parent;
            dgvComponents.DataSource = konfiguracija;

            decimal ukupno = konfiguracija.Sum(k => k.Cijena);
            txtTotalPrice.Text = $"{ukupno:0.00} €";

        }
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var reportForm = new FrmGenerateReport(konfiguracija);
            reportForm.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void btnEndConfig_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Jeste li sigurni da ste gotovi i želite ići na početnu?", "Potvrda završetka", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                var reportForm = new frmMenu();
                reportForm.Show();
                this.Close();
            }
        }

        // FrmKorisnikEmail.cs
        private void btnSendConfig_Click(object sender, EventArgs e)
        {
            // Use the email from KorisnikPrijava
            string email = KorisnikPrijava.LastEnteredEmail;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email nije pronađen. Prijavite se ponovno.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Server=31.147.206.65;Database=RWA2517_DB;User Id=RWA2517_User;Password=pV_Y4JPk;";

            string procesor = konfiguracija.FirstOrDefault(k => k.Kategorija == "Procesor")?.Naziv ?? "";
            string gpu = konfiguracija.FirstOrDefault(k => k.Kategorija == "Graficka kartica")?.Naziv ?? "";
            string maticna = konfiguracija.FirstOrDefault(k => k.Kategorija == "Maticna ploca")?.Naziv ?? "";
            string ram = konfiguracija.FirstOrDefault(k => k.Kategorija == "RAM")?.Naziv ?? "";
            string pohrana = konfiguracija.FirstOrDefault(k => k.Kategorija == "Pohrana")?.Naziv ?? "";
            string napajanje = konfiguracija.FirstOrDefault(k => k.Kategorija == "Napajanje")?.Naziv ?? "";
            string kuciste = konfiguracija.FirstOrDefault(k => k.Kategorija == "Kucište")?.Naziv ?? "";
            decimal ukupno = konfiguracija.Sum(k => k.Cijena);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO KorisnikoveKonfiguracije
                    (Email, Procesor, Graficka, MaticnaPloca, RAM, Pohrana, Napajanje, Kuciste, UkupnaCijena)
                    VALUES (@Email, @CPU, @GPU, @MBO, @RAM, @HDD, @PSU, @CASE, @Total)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@CPU", procesor);
                    cmd.Parameters.AddWithValue("@GPU", gpu);
                    cmd.Parameters.AddWithValue("@MBO", maticna);
                    cmd.Parameters.AddWithValue("@RAM", ram);
                    cmd.Parameters.AddWithValue("@HDD", pohrana);
                    cmd.Parameters.AddWithValue("@PSU", napajanje);
                    cmd.Parameters.AddWithValue("@CASE", kuciste);
                    cmd.Parameters.AddWithValue("@Total", ukupno);

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Konfiguracija je poslana!", "Uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string GetNaziv(string kategorija)
        {
            return konfiguracija.FirstOrDefault(k => k.Kategorija == kategorija)?.Naziv ?? "";
        }

    }
}