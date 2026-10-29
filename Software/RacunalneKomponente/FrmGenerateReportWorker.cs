using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Printing;
using System.Xml.Linq;

namespace RacunalneKomponente
{
    public partial class FrmGenerateReportWorker : Form
    {
        private List<PrikazKomponente> konfiguracija;

        public FrmGenerateReportWorker(List<PrikazKomponente> komponente)
        {
            InitializeComponent();
            konfiguracija = new List<PrikazKomponente>();
            foreach (var k in komponente)
            {
                konfiguracija.Add(DohvatiDetaljeKomponente(k.Naziv, k.Kategorija));
            }
            dgvReportComponents.DataSource = konfiguracija;
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Cijene",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            };

            foreach (var komponenta in konfiguracija)
            {
                int pointIndex = series.Points.AddY((double)komponenta.Cijena);
                series.Points[pointIndex].LegendText = komponenta.Naziv;
            }

            chartComponents.Series.Add(series);

        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (konfiguracija == null || konfiguracija.Count == 0)
            {
                MessageBox.Show("Konfiguracija nije dostupna za slanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmSendEmail sendEmailForm = new FrmSendEmail(konfiguracija, chartComponents);
            sendEmailForm.ShowDialog();
        }


        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF files (*.pdf)|*.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string chartImagePath = Path.Combine(Path.GetTempPath(), $"chart_{Guid.NewGuid()}.png");
                    chartComponents.SaveImage(chartImagePath, ChartImageFormat.Png);

                    using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        pdfDoc.Add(new Paragraph("Izvješće o komponentama"));
                        pdfDoc.Add(new Paragraph(" "));

                        iTextSharp.text.Image chartImage = iTextSharp.text.Image.GetInstance(chartImagePath);
                        chartImage.ScaleToFit(400f, 300f);
                        pdfDoc.Add(chartImage);
                        pdfDoc.Add(new Paragraph(" "));

                        PdfPTable table = new PdfPTable(5);
                        table.AddCell("Kategorija");
                        table.AddCell("Naziv");
                        table.AddCell("Proizvođač");
                        table.AddCell("Specifikacije");
                        table.AddCell("Cijena (€)");

                        foreach (var k in konfiguracija)
                        {
                            table.AddCell(k.Kategorija);
                            table.AddCell(k.Naziv);
                            table.AddCell(k.Proizvođač);
                            table.AddCell(k.Specifikacije);
                            table.AddCell(k.Cijena.ToString("0.00"));
                        }
                        pdfDoc.Add(table);

                        decimal ukupnaCijena = konfiguracija.Sum(x => x.Cijena);
                        pdfDoc.Add(new Paragraph(" "));
                        pdfDoc.Add(new Paragraph($"Ukupna cijena: {ukupnaCijena:0.00} €"));

                        pdfDoc.Close();
                        stream.Close();
                    }
                    if (File.Exists(chartImagePath))
                        File.Delete(chartImagePath);
                    MessageBox.Show("PDF izvješće je uspješno generirano!", "PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Close the current form or navigate back to the previous screen
            this.Close();
        }
        private PrikazKomponente DohvatiDetaljeKomponente(string naziv, string kategorija)
        {
            string connectionString = "Server=31.147.206.65;Database=RWA2517_DB;User Id=RWA2517_User;Password=pV_Y4JPk;";
            string query = "SELECT Naziv, Proizvođač, Cijena, Opis, TehničkeSpecifikacije FROM Komponente WHERE Naziv = @Naziv";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Naziv", naziv);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new PrikazKomponente
                        {
                            Kategorija = kategorija,
                            Naziv = reader["Naziv"].ToString(),
                            Proizvođač = reader["Proizvođač"].ToString(),
                            Specifikacije = reader["TehničkeSpecifikacije"].ToString(),
                            Cijena = reader["Cijena"] != DBNull.Value ? Convert.ToDecimal(reader["Cijena"]) : 0
                        };
                    }
                }
            }
            // fallback if not found
            return new PrikazKomponente { Kategorija = kategorija, Naziv = naziv, Proizvođač = "", Specifikacije = "", Cijena = 0 };
        }
    }
}
