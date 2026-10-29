namespace RacunalneKomponente
{
    partial class FrmGenerateReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartComponents = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvReportComponents = new System.Windows.Forms.DataGridView();
            this.btnGeneratePDF = new System.Windows.Forms.Button();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartComponents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportComponents)).BeginInit();
            this.SuspendLayout();
            // 
            // chartComponents
            // 
            chartArea2.Name = "ChartArea1";
            this.chartComponents.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartComponents.Legends.Add(legend2);
            this.chartComponents.Location = new System.Drawing.Point(12, 143);
            this.chartComponents.Name = "chartComponents";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartComponents.Series.Add(series2);
            this.chartComponents.Size = new System.Drawing.Size(277, 208);
            this.chartComponents.TabIndex = 0;
            this.chartComponents.Text = "chart1";
            // 
            // dgvReportComponents
            // 
            this.dgvReportComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportComponents.Location = new System.Drawing.Point(321, 74);
            this.dgvReportComponents.Name = "dgvReportComponents";
            this.dgvReportComponents.Size = new System.Drawing.Size(511, 277);
            this.dgvReportComponents.TabIndex = 1;
            // 
            // btnGeneratePDF
            // 
            this.btnGeneratePDF.Location = new System.Drawing.Point(731, 376);
            this.btnGeneratePDF.Name = "btnGeneratePDF";
            this.btnGeneratePDF.Size = new System.Drawing.Size(101, 23);
            this.btnGeneratePDF.TabIndex = 3;
            this.btnGeneratePDF.Text = "Generiraj PDF";
            this.btnGeneratePDF.UseVisualStyleBackColor = true;
            this.btnGeneratePDF.Click += new System.EventHandler(this.btnGeneratePDF_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(601, 376);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(92, 23);
            this.btnSendEmail.TabIndex = 4;
            this.btnSendEmail.Text = "Pošalji E-mail";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 376);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Natrag";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ispis konfiguracije";
            // 
            // lblChart
            // 
            this.lblChart.AutoSize = true;
            this.lblChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblChart.Location = new System.Drawing.Point(58, 88);
            this.lblChart.Name = "lblChart";
            this.lblChart.Size = new System.Drawing.Size(184, 24);
            this.lblChart.TabIndex = 7;
            this.lblChart.Text = "Cijene komponenata";
            // 
            // FrmGenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 421);
            this.ControlBox = false;
            this.Controls.Add(this.lblChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.btnGeneratePDF);
            this.Controls.Add(this.dgvReportComponents);
            this.Controls.Add(this.chartComponents);
            this.Name = "FrmGenerateReport";
            this.Text = "Ispis konfiguracije";
            ((System.ComponentModel.ISupportInitialize)(this.chartComponents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportComponents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartComponents;
        private System.Windows.Forms.DataGridView dgvReportComponents;
        private System.Windows.Forms.Button btnGeneratePDF;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChart;
    }
}