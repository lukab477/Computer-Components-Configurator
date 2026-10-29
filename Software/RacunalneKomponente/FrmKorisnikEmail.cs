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

namespace RacunalneKomponente
{
    public partial class FrmKorisnikEmail : Form
    {
        private List<PrikazKomponente> konfiguracija;
        private string connectionString = "Server=YOUR_SERVER_IP;Database=RWA2517_DB;User Id=YOUR_USER;Password=YOUR_PASSWORD;";


        public FrmKorisnikEmail(List<PrikazKomponente> komponente)
        {
            InitializeComponent();
            konfiguracija = komponente;
        }

        private void btnSendConfig_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Unesite email adresu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string procesor = konfiguracija.FirstOrDefault(k => k.Kategorija == "Procesor")?.Naziv ?? "";
            string gpu = konfiguracija.FirstOrDefault(k => k.Kategorija == "Graficka kartica")?.Naziv ?? "";
            string maticna = konfiguracija.FirstOrDefault(k => k.Kategorija == "Maticna ploca")?.Naziv ?? "";
            string ram = konfiguracija.FirstOrDefault(k => k.Kategorija == "RAM")?.Naziv ?? "";
            string pohrana = konfiguracija.FirstOrDefault(k => k.Kategorija == "Pohrana")?.Naziv ?? "";
            string napajanje = konfiguracija.FirstOrDefault(k => k.Kategorija == "Napajanje")?.Naziv ?? "";
            string kuciste = konfiguracija.FirstOrDefault(k => k.Kategorija == "Kucište")?.Naziv ?? "";
            decimal ukupno = konfiguracija.Sum(k => k.Cijena);


            SqlConnection conn = new SqlConnection(connectionString);


            bool sveDostupno = SveKomponenteDostupne(new List<string>
            {
                procesor, gpu, maticna, ram, pohrana, napajanje, kuciste
            });

            using (conn)
            {
                conn.Open();

                string query = @"INSERT INTO KorisnikoveKonfiguracije
            (Email, Procesor, Graficka, MaticnaPloca, RAM, Pohrana, Napajanje, Kuciste, UkupnaCijena, Dostupno)
            VALUES (@Email, @CPU, @GPU, @MBO, @RAM, @HDD, @PSU, @CASE, @Total, @Dostupno)";

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
                    cmd.Parameters.AddWithValue("@Dostupno", sveDostupno);


                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Konfiguracija i email su spremljeni!", "Uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool SveKomponenteDostupne(List<String> nazivi)
        {
            string inClause = string.Join(",", nazivi.Select((n, i) => $"@naziv{i}"));
            string finalSql = $@"SELECT COUNT(*) FROM Komponente 
                         WHERE Naziv IN ({inClause}) AND Dostupno = 0";

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(finalSql, conn))
            {
                for (int i = 0; i < nazivi.Count; i++)
                {
                    cmd.Parameters.AddWithValue($"@naziv{i}", nazivi[i]);
                }

                conn.Open();
                int brojNedostupnih = (int)cmd.ExecuteScalar();
                return brojNedostupnih == 0;
            }
        }
    }
}

