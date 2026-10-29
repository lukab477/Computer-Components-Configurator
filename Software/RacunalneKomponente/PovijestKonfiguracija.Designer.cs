namespace RacunalneKomponente
{
    partial class PovijestKonfiguracija
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvConfirmedConfigurations = new System.Windows.Forms.DataGridView();
            this.dgvDeclinedConfigurations = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblChart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmedConfigurations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeclinedConfigurations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(278, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Povijest Konfiguracija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odbijene Konfiguracije";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Potvrđene konfiguracije";
            // 
            // dgvConfirmedConfigurations
            // 
            this.dgvConfirmedConfigurations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfirmedConfigurations.Location = new System.Drawing.Point(16, 152);
            this.dgvConfirmedConfigurations.Name = "dgvConfirmedConfigurations";
            this.dgvConfirmedConfigurations.Size = new System.Drawing.Size(756, 156);
            this.dgvConfirmedConfigurations.TabIndex = 3;
            this.dgvConfirmedConfigurations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConfirmedConfigurations_CellContentClick);
            // 
            // dgvDeclinedConfigurations
            // 
            this.dgvDeclinedConfigurations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeclinedConfigurations.Location = new System.Drawing.Point(16, 346);
            this.dgvDeclinedConfigurations.Name = "dgvDeclinedConfigurations";
            this.dgvDeclinedConfigurations.Size = new System.Drawing.Size(756, 153);
            this.dgvDeclinedConfigurations.TabIndex = 4;
            this.dgvDeclinedConfigurations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeclinedConfigurations_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(681, 505);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 27);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Natrag";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblChart
            // 
            this.lblChart.AutoSize = true;
            this.lblChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblChart.Location = new System.Drawing.Point(12, 87);
            this.lblChart.Name = "lblChart";
            this.lblChart.Size = new System.Drawing.Size(535, 24);
            this.lblChart.TabIndex = 8;
            this.lblChart.Text = "Kliknite na konfiguraciju kako bi dobili mogućnost njenog ispisa";
            // 
            // PovijestKonfiguracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 544);
            this.ControlBox = false;
            this.Controls.Add(this.lblChart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvDeclinedConfigurations);
            this.Controls.Add(this.dgvConfirmedConfigurations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PovijestKonfiguracija";
            this.Text = "PovijestKonfiguracija";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfirmedConfigurations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeclinedConfigurations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvConfirmedConfigurations;
        private System.Windows.Forms.DataGridView dgvDeclinedConfigurations;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblChart;
    }
}