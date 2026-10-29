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
    public partial class frmCreateConfiguration : Form
    {
        private string connectionString = "Server=31.147.206.65;Database=RWA2517_DB;User Id=RWA2517_User;Password=pV_Y4JPk;";
        private List<PrikazKomponente> odabraneKomponente = new List<PrikazKomponente>();
        public frmCreateConfiguration()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Jeste li sigurni da želite napustiti ovaj prozor?\nVaša konfiguracija bit će izbrisana.", "Potvrda izlaska", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                frmCustomerView frmCustomerView = new frmCustomerView();
                frmCustomerView.Show();
                this.Close();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (odabraneKomponente.Count < 7)
            {
                MessageBox.Show("Konfiguracija nije potpuna.\nMolimo odaberite preostale komponente prije nastavka.", "Nepotpuna konfiguracija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var viewConfigurationForm = new FrmViewConfiguration(odabraneKomponente, this);
            viewConfigurationForm.Show();
            this.Hide();
        }
        private void LoadComponents(string componentType, ListBox listBox)
        {
            listBox.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT k.Naziv AS Kategorija, kp.Naziv, kp.Proizvođač, kp.TehničkeSpecifikacije, kp.Cijena FROM Komponente kp JOIN Kategorije k ON kp.KategorijaID = k.KategorijaID WHERE k.Naziv = @TipKomponente";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TipKomponente", componentType);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string kategorija = componentType;
                            string specifikacije = reader["TehničkeSpecifikacije"].ToString();

                            if (!JeKompatibilnaSaSvima(kategorija, specifikacije))
                                continue;

                            string display = $"{reader["Naziv"]} | {reader["Proizvođač"]} | {specifikacije} | {reader["Cijena"]}€";
                            listBox.Items.Add(display);


                        }
                    }
                }
            }
        }
        private void frmCreateConfiguration_Load(object sender, EventArgs e)
        {
            lstCPUs.Tag = "Procesor";
            lstGPUs.Tag = "Graficka kartica";
            lstMBOs.Tag = "Maticna ploca";
            lstRAMs.Tag = "RAM";
            lstStorage.Tag = "Pohrana";
            lstPSUs.Tag = "Napajanje";
            lstCases.Tag = "Kucište";

            lstCPUs.MouseDown += ComponentList_MouseDown;
            lstGPUs.MouseDown += ComponentList_MouseDown;
            lstMBOs.MouseDown += ComponentList_MouseDown;
            lstRAMs.MouseDown += ComponentList_MouseDown;
            lstStorage.MouseDown += ComponentList_MouseDown;
            lstPSUs.MouseDown += ComponentList_MouseDown;
            lstCases.MouseDown += ComponentList_MouseDown;

            LoadComponents("Procesor", lstCPUs);
            LoadComponents("Graficka kartica", lstGPUs);
            LoadComponents("Maticna ploca", lstMBOs);
            LoadComponents("RAM", lstRAMs);
            LoadComponents("Pohrana", lstStorage);
            LoadComponents("Napajanje", lstPSUs);
            LoadComponents("Kucište", lstCases);
        }

        private void ComponentList_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is ListBox listBox && listBox.SelectedItem != null)
            {
                string info = listBox.SelectedItem.ToString();
                string category = listBox.Tag?.ToString() ?? "Nepoznata";
                string data = $"{category}||{info}";
                listBox.DoDragDrop(data, DragDropEffects.Copy);
            }
        }
        private void pnlSelectedComponents_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pnlSelectedComponents_DragDrop(object sender, DragEventArgs e)
        {
            string rawData = e.Data.GetData(DataFormats.Text).ToString();
            string[] parts = rawData.Split(new string[] { "||" }, StringSplitOptions.None);

            if (parts.Length != 2) return;

            string category = parts[0].Trim();
            string componentInfo = parts[1].Trim();

            Label existingLabel = null;
            foreach (Control control in pnlSelectedComponents.Controls)
            {
                if (control is Label label2 && label2.Tag?.ToString() == category)
                {
                    existingLabel = label2;
                    break;
                }
            }
            if (existingLabel != null)
            {
                pnlSelectedComponents.Controls.Remove(existingLabel);
            }

            Label lblComponent = new Label();
            lblComponent.Text = $"{category}:\n{componentInfo.Replace("|", " - ")}";
            lblComponent.AutoSize = true;
            lblComponent.Margin = new Padding(5);
            lblComponent.Tag = category;

            pnlSelectedComponents.Controls.Add(lblComponent);
            pnlSelectedComponents.PerformLayout();
            pnlSelectedComponents.Refresh();
            lblComponent.BringToFront();

            var dijelovi = componentInfo.Split('|');
            if (dijelovi.Length >= 4)
            {
                var komponenta = new PrikazKomponente
                {
                    Kategorija = category,
                    Naziv = dijelovi[0].Trim(),
                    Proizvođač = dijelovi[1].Trim(),
                    Specifikacije = dijelovi[2].Trim(),
                    Cijena = decimal.Parse(dijelovi[3].Replace("€", "").Trim())
                };

                odabraneKomponente.RemoveAll(k => k.Kategorija == category);
                odabraneKomponente.Add(komponenta);

                LoadComponents("Procesor", lstCPUs);
                LoadComponents("Graficka kartica", lstGPUs);
                LoadComponents("Maticna ploca", lstMBOs);
                LoadComponents("RAM", lstRAMs);
                LoadComponents("Pohrana", lstStorage);
                LoadComponents("Napajanje", lstPSUs);
                LoadComponents("Kucište", lstCases);
                AzurirajStatus();
                AzurirajUkupnuCijenu();
            }
        }
        private string DohvatiSocket(string specifikacije)
        {
            var mapiranje = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { "AM4", "AM4" },
        { "AM5", "AM5" },
        { "LGA1700", "LGA1700" },
        { "Z690", "LGA1700" },
        { "B550", "AM4" },
        { "X570", "AM4" },
        { "B650", "AM5" },
        { "X670", "AM5" }
    };

            foreach (var par in mapiranje)
                if (specifikacije.ToUpper().Contains(par.Key.ToUpper()))
                    return par.Value;

            return "";
        }
        private bool JeKompatibilnaSaSvima(string kategorijaKomponente, string specifikacije)
        {
            foreach (var odabrana in odabraneKomponente)
            {
                // CPU ↔ MBO
                if ((kategorijaKomponente == "Maticna ploca" && odabrana.Kategorija == "Procesor") ||
                    (kategorijaKomponente == "Procesor" && odabrana.Kategorija == "Maticna ploca"))
                {
                    string socketA = DohvatiSocket(specifikacije);
                    string socketB = DohvatiSocket(odabrana.Specifikacije);
                    if (socketA != "" && socketB != "" && socketA != socketB)
                        return false;
                }

                // RAM ↔ MBO (samo DDR4/DDR5)
                if ((kategorijaKomponente == "RAM" && odabrana.Kategorija == "Maticna ploca") ||
                    (kategorijaKomponente == "Maticna ploca" && odabrana.Kategorija == "RAM"))
                {
                    if (!(specifikacije.Contains("DDR4") && odabrana.Specifikacije.Contains("DDR4")) &&
                        !(specifikacije.Contains("DDR5") && odabrana.Specifikacije.Contains("DDR5")))
                        return false;
                }

                // GPU ↔ MBO
                if ((kategorijaKomponente == "Graficka kartica" && odabrana.Kategorija == "Maticna ploca") ||
                    (kategorijaKomponente == "Maticna ploca" && odabrana.Kategorija == "Graficka kartica"))
                {
                    if (!specifikacije.Contains("PCIe") || !odabrana.Specifikacije.Contains("PCIe"))
                        return false;
                }
            }

            return true;
        }
        private void AzurirajStatus()
        {
            int ukupno = 7;
            int trenutno = odabraneKomponente.Count;

            if (trenutno < ukupno)
                lblStatus.Text = $"Odabrano komponenti: {trenutno}/{ukupno}. Dodajte preostale dijelove.";
            else
                lblStatus.Text = "Sve komponente su odabrane. Konfiguracija je potpuna.";
        }
        private void AzurirajUkupnuCijenu()
        {
            decimal total = odabraneKomponente.Sum(k => k.Cijena);
            lblPrice.Text = $"Cijena: {total}€";
        }
    }
}
