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
    public partial class KorisnikPrijava : Form
    {
        public KorisnikPrijava()
        {
            InitializeComponent();
        }
        public static string LastEnteredEmail { get; private set; }
        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Unesite email adresu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LastEnteredEmail = email;

            string connectionString = "Server=31.147.206.65;Database=RWA2517_DB;User Id=RWA2517_User;Password=pV_Y4JPk;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO KorisnikoveKonfiguracije
                    (Email, Procesor, Graficka, MaticnaPloca, RAM, Pohrana, Napajanje, Kuciste, UkupnaCijena)
                    VALUES (@Email, '', '', '', '', '', '', '', 0)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.ExecuteNonQuery();
                }
            }

            frmCustomerView pogledKupca = new frmCustomerView();
            pogledKupca.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frmCustomerView = new frmMenu();
            frmCustomerView.Show();
            this.Close();
        }
    }
}
