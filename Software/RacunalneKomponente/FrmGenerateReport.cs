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
    public partial class FrmGenerateReport : Form
    {
        private List<PrikazKomponente> konfiguracija;

        public FrmGenerateReport(List<PrikazKomponente> komponente)
        {
            InitializeComponent();
            konfiguracija = komponente;
            dgvReportComponents.DataSource = konfiguracija;

            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Cijene",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            };

            foreach (var komponenta in konfiguracija)
            {
                var point = series.Points.AddY((double)komponenta.Cijena);
                series.Points[point].LegendText = komponenta.Naziv;
            }

            chartComponents.Series.Add(series);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var viewConfigForm = new FrmViewConfiguration(konfiguracija, null);
            viewConfigForm.Show();
            this.Close();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string email = RacunalneKomponente.KorisnikPrijava.LastEnteredEmail;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Unesite email adresu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Server=31.147.206.65;Database=RWA2517_DB;User Id=RWA2517_User;Password=pV_Y4JPk;";

            // Save email to DB
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO KorisnikoveKonfiguracije
                    (Email, Procesor, Graficka, MaticnaPloca, RAM, Pohrana, Napajanje, Kuciste, UkupnaCijena)
                    VALUES (@Email, '', '', '', '', '', '', '', 0)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.ExecuteNonQuery();
                }
            }

            // --- EMAIL SENDING LOGIC ---
            // You must have a List<PrikazKomponente> konfiguracija available here!
            if (konfiguracija == null || konfiguracija.Count == 0)
            {
                MessageBox.Show("Konfiguracija nije dostupna za slanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tempPdfPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"Konfiguracija_{Guid.NewGuid()}.pdf");
            string chartImagePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"chart_{Guid.NewGuid()}.png");
            try
            {
                using (var chart = new System.Windows.Forms.DataVisualization.Charting.Chart())
                {
                    chart.Width = 600;
                    chart.Height = 400;
                    var chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
                    chart.ChartAreas.Add(chartArea);

                    var legend = new System.Windows.Forms.DataVisualization.Charting.Legend();
                    legend.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
                    legend.Alignment = StringAlignment.Center;
                    legend.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
                    chart.Legends.Add(legend);

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

                    chart.Series.Add(series);
                    chart.SaveImage(chartImagePath, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }

                using (var stream = new System.IO.FileStream(tempPdfPath, System.IO.FileMode.Create))
                {
                    var pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 25, 25, 25, 25);
                    iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    pdfDoc.Add(new iTextSharp.text.Paragraph("Izvješće o komponentama"));
                    pdfDoc.Add(new iTextSharp.text.Paragraph(" "));

                    iTextSharp.text.Image chartImage = iTextSharp.text.Image.GetInstance(chartImagePath);
                    chartImage.ScaleToFit(400f, 300f);
                    pdfDoc.Add(chartImage);
                    pdfDoc.Add(new iTextSharp.text.Paragraph(" "));

                    var table = new iTextSharp.text.pdf.PdfPTable(5);
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
                    pdfDoc.Add(new iTextSharp.text.Paragraph(" "));
                    pdfDoc.Add(new iTextSharp.text.Paragraph($"Ukupna cijena: {ukupnaCijena:0.00} €"));

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
                if (System.IO.File.Exists(tempPdfPath))
                    System.IO.File.Delete(tempPdfPath);
                if (System.IO.File.Exists(chartImagePath))
                    System.IO.File.Delete(chartImagePath);
            }

        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF files (*.pdf)|*.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string chartImagePath = Path.Combine(Path.GetTempPath(), "chart.png");
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

                        PdfPTable table = new PdfPTable(dgvReportComponents.Columns.Count);
                        foreach (DataGridViewColumn column in dgvReportComponents.Columns)
                        {
                            table.AddCell(new Phrase(column.HeaderText));
                        }
                        foreach (DataGridViewRow row in dgvReportComponents.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    table.AddCell(cell.Value?.ToString() ?? "");
                                }
                            }
                        }
                        pdfDoc.Add(table);

                        pdfDoc.Close();
                        stream.Close();
                    }

                    if (File.Exists(chartImagePath))
                        File.Delete(chartImagePath);

                    MessageBox.Show("PDF izvješće je uspješno generirano!", "PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        
    }
    
}
