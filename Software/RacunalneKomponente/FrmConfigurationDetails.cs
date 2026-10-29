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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace RačunalneKomponente.Forme
{
    public partial class FrmConfigurationDetails : Form
    {
        private readonly string _cs =
            ConfigurationManager
                .ConnectionStrings["RWA2517"]
                .ConnectionString;

        private decimal ukupnaCijena = 0;

        public FrmConfigurationDetails(int konfiguracijaId)
        {
            InitializeComponent();
            LoadConfiguration(konfiguracijaId);
        }

        private void LoadConfiguration(int id)
        {
            string sql = @"
    SELECT
        GK.KonfiguracijaId,
        GK.NazivKonfiguracija AS KonfiguracijaNaziv,
        TK.Naziv AS TipKonfiguracijeNaziv,

        P.Naziv AS ProcesorNaziv,
        P.Cijena AS ProcesorCijena,

        M.Naziv AS MaticnaNaziv,
        M.Cijena AS MaticnaCijena,

        St.Naziv AS PohranaNaziv,
        St.Cijena AS PohranaCijena,

        Kc.Naziv AS KucisteNaziv,
        Kc.Cijena AS KucisteCijena,

        G.Naziv AS GrafickaNaziv,
        G.Cijena AS GrafickaCijena,

        H.Naziv AS HladenjeNaziv,
        H.Cijena AS HladenjeCijena,

        R.Naziv AS RamNaziv,
        R.Cijena AS RamCijena,

        /* Zbroj svih komponenti */
        COALESCE(P.Cijena, 0)
      + COALESCE(M.Cijena, 0)
      + COALESCE(St.Cijena, 0)
      + COALESCE(Kc.Cijena, 0)
      + COALESCE(G.Cijena, 0)
      + COALESCE(H.Cijena, 0)
      + COALESCE(R.Cijena, 0) AS UkupnaCijena

    FROM dbo.GotoveKonfiguracije GK
    INNER JOIN dbo.TipKonfiguracije TK
        ON GK.TipKonfiguracije = TK.TipKonfiguracijeId

    LEFT JOIN dbo.Komponente P
        ON P.KomponentaID = GK.ProcesorId
    LEFT JOIN dbo.Komponente M
        ON M.KomponentaID = GK.MaticnaId
    LEFT JOIN dbo.Komponente St
        ON St.KomponentaID = GK.PohranaId
    LEFT JOIN dbo.Komponente Kc
        ON Kc.KomponentaID = GK.KucisteId
    LEFT JOIN dbo.Komponente G
        ON G.KomponentaID = GK.GrafickaId
    LEFT JOIN dbo.Komponente H
        ON H.KomponentaID = GK.HladenjeId
    LEFT JOIN dbo.Komponente R
        ON R.KomponentaID = GK.RAMId

    WHERE GK.KonfiguracijaId = @KonfiguracijaId;
    ";

            var dt = new DataTable();
            using (var conn = new SqlConnection(_cs))
            using (var cmd = new SqlCommand(sql, conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@KonfiguracijaId",id);
                da.Fill(dt);
            }

            lblNazivKonfiguracijeVrijednost.Text = dt.Rows[0]["KonfiguracijaNaziv"].ToString();
            lblVrstaKonfiguracijeVrijednost.Text = dt.Rows[0]["TipKonfiguracijeNaziv"].ToString();
            lblNameProcessor.Text = dt.Rows[0]["ProcesorNaziv"].ToString();
            lblPriceProcessor.Text = dt.Rows[0]["ProcesorCijena"].ToString();
            lblNameGraphicsCard.Text = dt.Rows[0]["GrafickaNaziv"].ToString();
            lblPriceGraphicsCard.Text = dt.Rows[0]["GrafickaCijena"].ToString();
            lblNameMotherboard.Text = dt.Rows[0]["MaticnaNaziv"].ToString();
            lblPriceMotherboard.Text = dt.Rows[0]["MaticnaCijena"].ToString();
            lblNameStorage.Text = dt.Rows[0]["PohranaNaziv"].ToString();
            lblPriceStorage.Text = dt.Rows[0]["PohranaCijena"].ToString();
            lblNameHousing.Text = dt.Rows[0]["KucisteNaziv"].ToString();
            lblPriceHousing.Text = dt.Rows[0]["KucisteCijena"].ToString();
            lblNameCooling.Text = dt.Rows[0]["HladenjeNaziv"].ToString();
            lblPriceCooling.Text = dt.Rows[0]["HladenjeCijena"].ToString();
            lblNameRAM.Text = dt.Rows[0]["RamNaziv"].ToString();
            lblPriceRAM.Text = dt.Rows[0]["RamCijena"].ToString();
            lblSumPrice.Text = dt.Rows[0]["UkupnaCijena"].ToString();

            ukupnaCijena = Convert.ToDecimal(dt.Rows[0]["UkupnaCijena"]);
        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMailAddress_TextChanged(object sender, EventArgs e)
        {
            string mail = txtMailAddress.Text;
            if (string.IsNullOrEmpty(mail) || !mail.Contains("@"))
            {
                btnChoose.Enabled = false;
            }
            else
            {
                btnChoose.Enabled = true;
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            const string sql = @"
                INSERT INTO KorisnikoveKonfiguracije
                  (DatumIzrade, Procesor, Graficka, MaticnaPloca, RAM,
                   Pohrana, Napajanje, Kuciste, UkupnaCijena,Email, Dostupno)
                VALUES
                  (@DatumIzrade, @Procesor, @Graficka, @MaticnaPloca, @RAM,
                   @Pohrana, @Napajanje, @Kuciste, @UkupnaCijena, @Email, @Dostupno);
                SELECT SCOPE_IDENTITY();";

            bool sveDostupno = SveKomponenteDostupne(); 

            using (var conn = new SqlConnection(_cs))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@DatumIzrade", SqlDbType.DateTime)
                                                .Value = DateTime.Now;
                cmd.Parameters.AddWithValue("@Procesor", lblNameProcessor.Text.Trim());
                cmd.Parameters.AddWithValue("@Graficka", lblNameGraphicsCard.Text.Trim());
                cmd.Parameters.AddWithValue("@MaticnaPloca", lblNameMotherboard.Text.Trim());
                cmd.Parameters.AddWithValue("@RAM", lblNameRAM.Text.Trim());
                cmd.Parameters.AddWithValue("@Pohrana", lblNameStorage.Text.Trim());
                cmd.Parameters.AddWithValue("@Napajanje", lblNameCooling.Text.Trim());
                cmd.Parameters.AddWithValue("@Kuciste", lblNameHousing.Text.Trim());
                cmd.Parameters.AddWithValue("@UkupnaCijena", ukupnaCijena);
                cmd.Parameters.AddWithValue("@Email", txtMailAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Dostupno", sveDostupno);

                conn.Open();
                var newId = Convert.ToInt32(cmd.ExecuteScalar());

                var result= MessageBox.Show(
                    "Konfiguracija je uspješno poslana!\nID nove konfiguracije: " + newId,
                    "Uspjeh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if(result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private bool SveKomponenteDostupne()
        {
            var nazivi = new List<string>
    {
        lblNameProcessor.Text.Trim(),
        lblNameGraphicsCard.Text.Trim(),
        lblNameMotherboard.Text.Trim(),
        lblNameRAM.Text.Trim(),
        lblNameStorage.Text.Trim(),
        lblNameCooling.Text.Trim(),
        lblNameHousing.Text.Trim()
    };

            string inClause = string.Join(",", nazivi.Select((n, i) => $"@naziv{i}"));

            string finalSql = $@"SELECT COUNT(*) FROM Komponente 
                         WHERE Naziv IN ({inClause}) AND Dostupno = 0";

            using (var conn = new SqlConnection(_cs))
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
