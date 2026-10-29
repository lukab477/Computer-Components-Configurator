namespace RacunalneKomponente
{
    partial class FrmMyConfigs
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
            this.dgvMyConfigs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblChart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyConfigs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMyConfigs
            // 
            this.dgvMyConfigs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyConfigs.Location = new System.Drawing.Point(40, 161);
            this.dgvMyConfigs.Name = "dgvMyConfigs";
            this.dgvMyConfigs.Size = new System.Drawing.Size(715, 223);
            this.dgvMyConfigs.TabIndex = 0;
            this.dgvMyConfigs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMyConfigs_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(299, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moje konfiguracije";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(40, 400);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Natrag";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblChart
            // 
            this.lblChart.AutoSize = true;
            this.lblChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblChart.Location = new System.Drawing.Point(36, 100);
            this.lblChart.Name = "lblChart";
            this.lblChart.Size = new System.Drawing.Size(535, 24);
            this.lblChart.TabIndex = 9;
            this.lblChart.Text = "Kliknite na konfiguraciju kako bi dobili mogućnost njenog ispisa";
            // 
            // FrmMyConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblChart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMyConfigs);
            this.Name = "FrmMyConfigs";
            this.Text = "Moje Konfiguracije";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyConfigs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMyConfigs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblChart;
    }
}