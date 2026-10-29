using System;
using System.Configuration; 
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RačunalneKomponente
{
    public partial class FrmAddComputerComponent : Form
    {
        
        private readonly string _cs =
            ConfigurationManager
                .ConnectionStrings["RWA2517"]
                .ConnectionString;

        public FrmAddComputerComponent()
        {
            InitializeComponent();
            this.Load += FrmAddComputerComponent_Load;
            btnAddProduct.Click += BtnAddProduct_Click;
            btnGiveUp.Click += BtnGiveUp_Click;
        }

        private void FrmAddComputerComponent_Load(object sender, EventArgs e)
        {
            LoadComponentTypes();
        }

        private void LoadComponentTypes()
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(_cs))
            using (var da = new SqlDataAdapter(
                    "SELECT KategorijaID, Naziv FROM Kategorije", conn))
            {
                da.Fill(dt);
            }
            cboComponentType.DisplayMember = "Naziv";
            cboComponentType.ValueMember = "KategorijaID";
            cboComponentType.DataSource = dt;
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text)
             || cboComponentType.SelectedValue == null
             || !decimal.TryParse(txtPrice.Text, out var price)
             || !int.TryParse(txtNumberOfCores.Text, out var cores))
            {
                MessageBox.Show(
                    "Provjerite obavezna polja (Naziv, Tip, Cijena, Broj jezgri).",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            const string sql = @"
                INSERT INTO Komponente
                  (Naziv, Proizvođač, Cijena, Opis, TehničkeSpecifikacije,
                   Serija, Podnožje, BrojJezgri, KategorijaID)
                VALUES
                  (@Naziv, @Proizvodac, @Cijena, @Opis, @Specifikacije,
                   @Serija, @Podnozje, @BrojJezgri, @KategorijaID);
                SELECT SCOPE_IDENTITY();";

            using (var conn = new SqlConnection(_cs))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Naziv", txtProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@Proizvodac", txtManifacturesName.Text.Trim());
                cmd.Parameters.AddWithValue("@Cijena", price);
                cmd.Parameters.AddWithValue("@Opis", (object)txtDescription.Text.Trim() ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Specifikacije", DBNull.Value);
                cmd.Parameters.AddWithValue("@Serija", (object)txtSeries.Text.Trim() ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Podnozje", (object)txtFooting.Text.Trim() ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@BrojJezgri", cores);
                cmd.Parameters.AddWithValue("@KategorijaID", (int)cboComponentType.SelectedValue);

                conn.Open();
                var newId = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show(
                    "Proizvod je uspješno dodan!\nID nove komponente: " + newId,
                    "Uspjeh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnGiveUp_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cboComponentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtManifacturesName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiveUp_Click_1(object sender, EventArgs e)
        {
            RacunalneKomponente.frmWorkerView view = new RacunalneKomponente.frmWorkerView();
            view.Show();
            this.Close();
        }
    }
}
