namespace RacunalneKomponente
{
    partial class Pregled_svih_komponenti
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
            this.lblPregledSvihKomponenti = new System.Windows.Forms.Label();
            this.dgvPrikazKomponenata = new System.Windows.Forms.DataGridView();
            this.btnIzađi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazKomponenata)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPregledSvihKomponenti
            // 
            this.lblPregledSvihKomponenti.AutoSize = true;
            this.lblPregledSvihKomponenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPregledSvihKomponenti.Location = new System.Drawing.Point(227, 54);
            this.lblPregledSvihKomponenti.Name = "lblPregledSvihKomponenti";
            this.lblPregledSvihKomponenti.Size = new System.Drawing.Size(279, 29);
            this.lblPregledSvihKomponenti.TabIndex = 0;
            this.lblPregledSvihKomponenti.Text = "Pregled svih komponenti";
            // 
            // dgvPrikazKomponenata
            // 
            this.dgvPrikazKomponenata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazKomponenata.Location = new System.Drawing.Point(22, 125);
            this.dgvPrikazKomponenata.Name = "dgvPrikazKomponenata";
            this.dgvPrikazKomponenata.RowHeadersWidth = 51;
            this.dgvPrikazKomponenata.RowTemplate.Height = 24;
            this.dgvPrikazKomponenata.Size = new System.Drawing.Size(704, 328);
            this.dgvPrikazKomponenata.TabIndex = 1;
            this.dgvPrikazKomponenata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrikazKomponenata_CellContentClick);
            // 
            // btnIzađi
            // 
            this.btnIzađi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzađi.Location = new System.Drawing.Point(651, 489);
            this.btnIzađi.Name = "btnIzađi";
            this.btnIzađi.Size = new System.Drawing.Size(75, 30);
            this.btnIzađi.TabIndex = 2;
            this.btnIzađi.Text = "Izađi";
            this.btnIzađi.UseVisualStyleBackColor = true;
            this.btnIzađi.Click += new System.EventHandler(this.btnIzađi_Click);
            // 
            // Pregled_svih_komponenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 544);
            this.Controls.Add(this.btnIzađi);
            this.Controls.Add(this.dgvPrikazKomponenata);
            this.Controls.Add(this.lblPregledSvihKomponenti);
            this.Name = "Pregled_svih_komponenti";
            this.Text = "Pregled_svih_komponenti";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazKomponenata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregledSvihKomponenti;
        private System.Windows.Forms.DataGridView dgvPrikazKomponenata;
        private System.Windows.Forms.Button btnIzađi;
    }
}