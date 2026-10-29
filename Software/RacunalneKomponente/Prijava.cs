using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacunalneKomponente
{
    public partial class frmLogin : Form
    {
        private const string KorisnickoIme = "zaposlenik";
        private const string Lozinka = "123";

        public frmLogin()
        {
            InitializeComponent();

            btnLogin.Enabled = false;

            txtUsername.TextChanged += Polja_TextChanged;
            txtPassword.TextChanged += Polja_TextChanged;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtUsername.Text.Trim();
            string lozinka = txtPassword.Text;

            if (korisnickoIme == KorisnickoIme && lozinka == Lozinka)
            {
                frmWorkerView frmWorkerView = new frmWorkerView();
                frmWorkerView.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Krivi podaci za prijavu.", "Prijava neuspješna", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void Polja_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = !string.IsNullOrWhiteSpace(txtUsername.Text) &&
                               !string.IsNullOrWhiteSpace(txtPassword.Text);
        }
    }

}
