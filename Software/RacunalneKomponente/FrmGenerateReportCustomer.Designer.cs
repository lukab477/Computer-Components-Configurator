namespace RacunalneKomponente
{
    partial class FrmGenerateReportCustomer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartComponents = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnGeneratePDF = new System.Windows.Forms.Button();
            this.dgvReportComponents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartComponents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportComponents)).BeginInit();
            this.SuspendLayout();
            // 
            // chartComponents
            // 
            chartArea1.Name = "ChartArea1";
            this.chartComponents.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartComponents.Legends.Add(legend1);
            this.chartComponents.Location = new System.Drawing.Point(12, 139);
            this.chartComponents.Name = "chartComponents";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartComponents.Series.Add(series1);
            this.chartComponents.Size = new System.Drawing.Size(277, 208);
            this.chartComponents.TabIndex = 18;
            this.chartComponents.Text = "chart1";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 363);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Natrag";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(557, 363);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(92, 23);
            this.btnSendEmail.TabIndex = 16;
            this.btnSendEmail.Text = "Pošalji E-mail";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnGeneratePDF
            // 
            this.btnGeneratePDF.Location = new System.Drawing.Point(687, 363);
            this.btnGeneratePDF.Name = "btnGeneratePDF";
            this.btnGeneratePDF.Size = new System.Drawing.Size(101, 23);
            this.btnGeneratePDF.TabIndex = 15;
            this.btnGeneratePDF.Text = "Generiraj PDF";
            this.btnGeneratePDF.UseVisualStyleBackColor = true;
            this.btnGeneratePDF.Click += new System.EventHandler(this.btnGeneratePDF_Click);
            // 
            // dgvReportComponents
            // 
            this.dgvReportComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportComponents.Location = new System.Drawing.Point(313, 70);
            this.dgvReportComponents.Name = "dgvReportComponents";
            this.dgvReportComponents.Size = new System.Drawing.Size(475, 277);
            this.dgvReportComponents.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ispis konfiguracije";
            // 
            // lblChart
            // 
            this.lblChart.AutoSize = true;
            this.lblChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblChart.Location = new System.Drawing.Point(61, 97);
            this.lblChart.Name = "lblChart";
            this.lblChart.Size = new System.Drawing.Size(184, 24);
            this.lblChart.TabIndex = 19;
            this.lblChart.Text = "Cijene komponenata";
            // 
            // FrmGenerateReportCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.lblChart);
            this.Controls.Add(this.chartComponents);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.btnGeneratePDF);
            this.Controls.Add(this.dgvReportComponents);
            this.Controls.Add(this.label1);
            this.Name = "FrmGenerateReportCustomer";
            this.Text = "Ispis konfiguracije";
            ((System.ComponentModel.ISupportInitialize)(this.chartComponents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportComponents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartComponents;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnGeneratePDF;
        private System.Windows.Forms.DataGridView dgvReportComponents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChart;
    }
}