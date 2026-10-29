using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RacunalneKomponente;

namespace RačunalneKomponente.Forme
{
    public partial class FrmPredefinedConfiguration : Form
    {
        private readonly string _cs =
            ConfigurationManager
                .ConnectionStrings["RWA2517"]
                .ConnectionString;
        public FrmPredefinedConfiguration()
        {
            InitializeComponent();
            LoadCategories();
            dgvListaKonfiguracija.AllowUserToAddRows = false;
            dgvListaKonfiguracija.RowHeadersVisible = false;

        }

        private void LoadCategories()
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(_cs))
            using (var da = new SqlDataAdapter(
                    "SELECT TipKonfiguracijeId, Naziv FROM TipKonfiguracije", conn))
            {
                da.Fill(dt);
            }
            cmbVrstaKonfiguracije.DisplayMember = "Naziv";
            cmbVrstaKonfiguracije.ValueMember = "TipKonfiguracijeId";
            cmbVrstaKonfiguracije.DataSource = dt;

        }
        
        private void LoadConfigurations(int id)
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(_cs))
            using (var da = new SqlDataAdapter(
                    "SELECT KonfiguracijaID, NazivKonfiguracija FROM GotoveKonfiguracije WHERE TipKonfiguracije = @TipId", conn)) 
            {
                da.SelectCommand.Parameters.AddWithValue("@TipId", id);
                da.Fill(dt);
            }

            if (!dgvListaKonfiguracija.Columns.Contains("colSelect"))
            {
                var btnCol = new DataGridViewButtonColumn
                {
                    Name = "colSelect",
                    HeaderText = "Odaberi",
                    Text = "Odaberi",
                    UseColumnTextForButtonValue = true,
                    Width = 80
                };
                dgvListaKonfiguracija.Columns.Add(btnCol);
            }
            dgvListaKonfiguracija.AutoGenerateColumns = false;

            if (dgvListaKonfiguracija.Columns.Count == 1)
            {
                dgvListaKonfiguracija.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "KonfiguracijaID",
                    DataPropertyName = "KonfiguracijaID",
                });

                dgvListaKonfiguracija.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "NazivKonfiguracija",
                    HeaderText = "Naziv",
                    DataPropertyName = "NazivKonfiguracija",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });              
            }
                dgvListaKonfiguracija.DataSource = dt;
        }


        private void btnGiveUpCloseForm(object sender, EventArgs e)
        {
            frmCustomerView frmCustomerView = new frmCustomerView();
            frmCustomerView.Show();
            this.Close();
        }

        private void cmbVrstaKonfiguracije_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVrstaKonfiguracije.SelectedIndex < 0) return;
            int tipId = (int) cmbVrstaKonfiguracije.SelectedValue;

            LoadConfigurations(tipId);
        }

        private void lblDisplayAccordingToNeeds_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaKonfiguracija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvListaKonfiguracija.Columns[e.ColumnIndex].Name != "colSelect") return;

            var row = dgvListaKonfiguracija.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells["KonfiguracijaID"].Value);
            string naziv = row.Cells["NazivKonfiguracija"].Value.ToString();

            
            using (var details = new FrmConfigurationDetails(id))
            {
                details.ShowDialog();
            }
            
        }
    }
}
