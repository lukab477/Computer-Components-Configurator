using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace RacunalneKomponente
{
    public partial class FrmGenerateReportCustomer : Form
    {
        private List<PrikazKomponente> konfiguracija;

        public FrmGenerateReportCustomer(List<PrikazKomponente> komponente)
        {
            InitializeComponent();
            konfiguracija = new List<PrikazKomponente>();
            foreach (var k in komponente)
            {
                konfiguracija.Add(DohvatiDetaljeKomponente(k.Naziv, k.Kategorija));
            }
            dgvReportComponents.DataSource = konfiguracija;

            // Pie chart
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
            string email = RacunalneKomponente.KorisnikPrijava.LastEnteredEmail;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Unesite email adresu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (konfiguracija == null || konfiguracija.Count == 0)
            {
                MessageBox.Show("Konfiguracija nije dostupna za slanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tempPdfPath = Path.Combine(Path.GetTempPath(), $"Konfiguracija_{Guid.NewGuid()}.pdf");
            string chartImagePath = Path.Combine(Path.GetTempPath(), $"chart_{Guid.NewGuid()}.png");
            chartComponents.SaveImage(chartImagePath, ChartImageFormat.Png);
            try
            {
                using (var stream = new FileStream(tempPdfPath, FileMode.Create))
                {
                    var pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    pdfDoc.Add(new Paragraph("Izvješće o komponentama"));
                    pdfDoc.Add(new Paragraph(" "));

                    iTextSharp.text.Image chartImage = iTextSharp.text.Image.GetInstance(chartImagePath);
                    chartImage.ScaleToFit(400f, 300f);
                    pdfDoc.Add(chartImage);
                    pdfDoc.Add(new Paragraph(" "));

                    var table = new PdfPTable(5);
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
                }

                using (var mail = new System.Net.Mail.MailMessage())
                {
                    mail.From = new System.Net.Mail.MailAddress("luka.bo2004@gmail.com");
                    mail.To.Add(email);
                    mail.Subject = "Vaša konfiguracija";
                    mail.Body = "U privitku se nalazi PDF s vašom konfiguracijom.";

                    using (var attachment = new System.Net.Mail.Attachment(tempPdfPath, System.Net.Mime.MediaTypeNames.Application.Pdf))
                    {
                        mail.Attachments.Add(attachment);

                        var smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
                        {
                            Credentials = new System.Net.NetworkCredential("luka.bo2004@gmail.com", "kzga wrtw byul abps"),
                            EnableSsl = true
                        };

                        smtp.Send(mail);
                    }
                }

                MessageBox.Show("Konfiguracija je poslana na email!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri slanju emaila: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (File.Exists(tempPdfPath))
                    File.Delete(tempPdfPath);
                if (File.Exists(chartImagePath))
                    File.Delete(chartImagePath);

            }
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
            return new PrikazKomponente { Kategorija = kategorija, Naziv = naziv, Proizvođač = "", Specifikacije = "", Cijena = 0 };
        }
    }
}
