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
using RačunalneKomponente.Forme;

namespace RacunalneKomponente
{
    public partial class frmCustomerView : Form
    {
        public frmCustomerView()
        {
            InitializeComponent();
        }
     
        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void btnCreateConfiguration_Click(object sender, EventArgs e)
        {
            frmCreateConfiguration frmCreateConfiguration = new frmCreateConfiguration();
            frmCreateConfiguration.Show();
            this.Close();
        }

        private void btnViewConfiguration_Click(object sender, EventArgs e)
        {
            FrmPredefinedConfiguration frmPredefinedConfiguration = new FrmPredefinedConfiguration();
            frmPredefinedConfiguration.Show();
            this.Hide();
        }

        private void btnMyConfigs_Click(object sender, EventArgs e)
        {
            FrmMyConfigs frmMyConfigs = new FrmMyConfigs();
            frmMyConfigs.Show();
            this.Close();
        }
    }
}
