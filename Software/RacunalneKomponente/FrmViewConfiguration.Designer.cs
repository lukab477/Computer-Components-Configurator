namespace RacunalneKomponente
{
    partial class FrmViewConfiguration
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
            this.dgvComponents = new System.Windows.Forms.DataGridView();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnSendConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEndConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComponents
            // 
            this.dgvComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComponents.Location = new System.Drawing.Point(16, 94);
            this.dgvComponents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvComponents.Name = "dgvComponents";
            this.dgvComponents.RowHeadersWidth = 51;
            this.dgvComponents.Size = new System.Drawing.Size(744, 185);
            this.dgvComponents.TabIndex = 0;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(16, 316);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(96, 16);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "Ukupna cijena:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(129, 313);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(191, 22);
            this.txtTotalPrice.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(20, 382);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Natrag";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(331, 382);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(100, 28);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Ispis";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnSendConfig
            // 
            this.btnSendConfig.Location = new System.Drawing.Point(439, 382);
            this.btnSendConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendConfig.Name = "btnSendConfig";
            this.btnSendConfig.Size = new System.Drawing.Size(208, 28);
            this.btnSendConfig.TabIndex = 5;
            this.btnSendConfig.Text = "Pošalji i potvrdi konfiguraciju";
            this.btnSendConfig.UseVisualStyleBackColor = true;
            this.btnSendConfig.Click += new System.EventHandler(this.btnSendConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pregled konfiguracije";
            // 
            // btnEndConfig
            // 
            this.btnEndConfig.Location = new System.Drawing.Point(655, 382);
            this.btnEndConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEndConfig.Name = "btnEndConfig";
            this.btnEndConfig.Size = new System.Drawing.Size(105, 28);
            this.btnEndConfig.TabIndex = 7;
            this.btnEndConfig.Text = "Završi";
            this.btnEndConfig.UseVisualStyleBackColor = true;
            this.btnEndConfig.Click += new System.EventHandler(this.btnEndConfig_Click);
            // 
            // FrmViewConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 430);
            this.ControlBox = false;
            this.Controls.Add(this.btnEndConfig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendConfig);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.dgvComponents);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmViewConfiguration";
            this.Text = "Pregled Konfiguracije";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComponents;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnSendConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEndConfig;
    }
}