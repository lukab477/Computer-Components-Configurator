using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms.DataVisualization.Charting;

namespace RacunalneKomponente
{
    public partial class FrmSendEmail : Form
    {
        private List<PrikazKomponente> konfiguracija;
        private Chart chart;

        public FrmSendEmail(List<PrikazKomponente> konfiguracija, Chart chart)
        {
            InitializeComponent();
            this.konfiguracija = konfiguracija;
            this.chart = chart;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // samo zatvori formu
        }
        private void btnConfirmSend_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

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
            chart.SaveImage(chartImagePath, ChartImageFormat.Png);

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

                using (var mail = new MailMessage())
                {
                    mail.From = new MailAddress("your_email@gmail.com");
                    mail.To.Add(email);
                    mail.Subject = "Vaša konfiguracija";
                    mail.Body = "U privitku se nalazi PDF s vašom konfiguracijom.";

                    using (var attachment = new Attachment(tempPdfPath, System.Net.Mime.MediaTypeNames.Application.Pdf))
                    {
                        mail.Attachments.Add(attachment);

                        var smtp = new SmtpClient("smtp.gmail.com", 587)
                        {
                            Credentials = new System.Net.NetworkCredential("your_email@gmail.com", "YOUR_APP_PASSWORD_HERE"),
                            EnableSsl = true
                        };

                        smtp.Send(mail);
                    }
                }

                MessageBox.Show("Konfiguracija je poslana na email!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
    }
}
