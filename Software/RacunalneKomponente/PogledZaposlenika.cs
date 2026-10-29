using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RačunalneKomponente;

namespace RacunalneKomponente
{
    public partial class frmWorkerView : Form
    {
        public frmWorkerView()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void btnAprove_Click(object sender, EventArgs e)
        {
            var confirmCompatibility = new FrmConfirmCompatibility();
            confirmCompatibility.Show();
            this.Close();
        }

        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            FrmAddComputerComponent FrmAddComputerComponent = new FrmAddComputerComponent();
            FrmAddComputerComponent.Show();
            this.Hide();

        }

        private void btnCreateConfiguration_Click(object sender, EventArgs e)
        {
            FrmCreateConfiguration FrmCreateConfiguration = new FrmCreateConfiguration();
            FrmCreateConfiguration.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PovijestKonfiguracija povijestForm = new PovijestKonfiguracija();
            povijestForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pregled_svih_komponenti pregledKomponenti = new Pregled_svih_komponenti();
            pregledKomponenti.Show();
            this.Close();
        }
    }
}
