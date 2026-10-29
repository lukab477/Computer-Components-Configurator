using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RacunalneKomponente;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace RačunalneKomponente
{
    public partial class FrmCreateConfiguration : Form
    {

        private readonly string _cs =
            ConfigurationManager
                .ConnectionStrings["RWA2517"]
                .ConnectionString;
        public FrmCreateConfiguration()
        {
            InitializeComponent();

            FillConfigurationTypes();

            FillComponents(1, cmbProcesor);
            FillComponents(2, cmbGraficka);
            FillComponents(3, cmbMaticna);
            FillComponents(4, cmbRAM);
            FillComponents(5, cmbPohrana);
            FillComponents(6, cmbHladenje);
            FillComponents(7, cmbKuciste);
            
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            frmWorkerView frmWorkerView = new frmWorkerView();
            frmWorkerView.Show();
            this.Close();
        }

        private void cmbProcesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Ispis" + cmbVrstaKonfiguracije.SelectedValue?.GetType().FullName);
            Debug.WriteLine(cmbVrstaKonfiguracije.SelectedValue);
        }

        private void FillConfigurationTypes()
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(_cs))
            using (var da = new SqlDataAdapter(
                "SELECT TipKonfiguracijeID, Naziv FROM TipKonfiguracije",
                conn))
            {
                da.Fill(dt);
            }

            cmbVrstaKonfiguracije.DisplayMember = "Naziv";
            cmbVrstaKonfiguracije.ValueMember = "TipKonfiguracijeID";
            cmbVrstaKonfiguracije.DataSource = dt;
        }

        private void FillComponents(int kategorijaId, ComboBox cb)
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(_cs))
            using (var da = new SqlDataAdapter(
                "SELECT KomponentaID, Naziv FROM Komponente WHERE KategorijaID = @KatID",
                conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@KatID", kategorijaId);
                da.Fill(dt);
            }

            cb.DisplayMember = "Naziv";
            cb.ValueMember = "KomponentaID";
            cb.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
 
           
            int tipKonf = Convert.ToInt32(cmbVrstaKonfiguracije.SelectedValue);
            string nazivKonf = txtNazivKonfiguracije.Text.Trim();
            int procId = Convert.ToInt32(cmbProcesor.SelectedValue);
            int maticnaId = Convert.ToInt32(cmbMaticna.SelectedValue);
            int pohranaId = Convert.ToInt32(cmbPohrana.SelectedValue);
            int kucisteId = Convert.ToInt32(cmbKuciste.SelectedValue);
            int grafId = Convert.ToInt32(cmbGraficka.SelectedValue);
            int hladId = Convert.ToInt32(cmbHladenje.SelectedValue);
            int ramId = Convert.ToInt32(cmbRAM.SelectedValue);

            
            const string sql = @"
            INSERT INTO GotoveKonfiguracije
          (TipKonfiguracije, NazivKonfiguracija,
           ProcesorId, MaticnaId, PohranaId,
           KucisteId, GrafickaId, HladenjeId, RAMId)
          VALUES
          (@TipKonf, @NazivKonf,
           @ProcId, @MaticnaId, @PohranaId,
           @KucisteId, @GrafId, @HladId, @RamId);
             SELECT CAST(SCOPE_IDENTITY() AS INT);";

            try
            {
                using (var conn = new SqlConnection(_cs))
                using (var cmd = new SqlCommand(sql, conn))
                {
                  
                    cmd.Parameters.Add("@TipKonf", SqlDbType.Int).Value = tipKonf;
                    cmd.Parameters.Add("@NazivKonf", SqlDbType.NVarChar, 100).Value = nazivKonf;
                    cmd.Parameters.Add("@ProcId", SqlDbType.Int).Value = procId;
                    cmd.Parameters.Add("@MaticnaId", SqlDbType.Int).Value = maticnaId;
                    cmd.Parameters.Add("@PohranaId", SqlDbType.Int).Value = pohranaId;
                    cmd.Parameters.Add("@KucisteId", SqlDbType.Int).Value = kucisteId;
                    cmd.Parameters.Add("@GrafId", SqlDbType.Int).Value = grafId;
                    cmd.Parameters.Add("@HladId", SqlDbType.Int).Value = hladId;
                    cmd.Parameters.Add("@RamId", SqlDbType.Int).Value = ramId;

                    conn.Open();
                    int newId = (int)cmd.ExecuteScalar();

                    MessageBox.Show(
                        $"Konfiguracija uspješno spremljena!\nID = {newId}",
                        "Uspjeh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Greška pri izvršavanju upita:\n{ex.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
