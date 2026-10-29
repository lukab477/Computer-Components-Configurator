namespace RačunalneKomponente.Forme
{
    partial class FrmPredefinedConfiguration
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
            this.lblDisplayAccordingToNeeds = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblComputerType = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.cmbVrstaKonfiguracije = new System.Windows.Forms.ComboBox();
            this.dgvListaKonfiguracija = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKonfiguracija)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDisplayAccordingToNeeds
            // 
            this.lblDisplayAccordingToNeeds.AutoSize = true;
            this.lblDisplayAccordingToNeeds.Location = new System.Drawing.Point(34, 156);
            this.lblDisplayAccordingToNeeds.Name = "lblDisplayAccordingToNeeds";
            this.lblDisplayAccordingToNeeds.Size = new System.Drawing.Size(114, 16);
            this.lblDisplayAccordingToNeeds.TabIndex = 4;
            this.lblDisplayAccordingToNeeds.Text = "Lista konfiguracija";
            this.lblDisplayAccordingToNeeds.Click += new System.EventHandler(this.lblDisplayAccordingToNeeds_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(173, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unaprijed definirane konfiguracije";
            // 
            // lblComputerType
            // 
            this.lblComputerType.AutoSize = true;
            this.lblComputerType.Location = new System.Drawing.Point(34, 102);
            this.lblComputerType.Name = "lblComputerType";
            this.lblComputerType.Size = new System.Drawing.Size(134, 16);
            this.lblComputerType.TabIndex = 12;
            this.lblComputerType.Text = "Odabri vrstu računala";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(551, 545);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(96, 31);
            this.btnCloseForm.TabIndex = 24;
            this.btnCloseForm.Text = "Odustani";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnGiveUpCloseForm);
            // 
            // cmbVrstaKonfiguracije
            // 
            this.cmbVrstaKonfiguracije.FormattingEnabled = true;
            this.cmbVrstaKonfiguracije.Location = new System.Drawing.Point(188, 99);
            this.cmbVrstaKonfiguracije.Name = "cmbVrstaKonfiguracije";
            this.cmbVrstaKonfiguracije.Size = new System.Drawing.Size(186, 24);
            this.cmbVrstaKonfiguracije.TabIndex = 25;
            this.cmbVrstaKonfiguracije.SelectedIndexChanged += new System.EventHandler(this.cmbVrstaKonfiguracije_SelectedIndexChanged);
            // 
            // dgvListaKonfiguracija
            // 
            this.dgvListaKonfiguracija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaKonfiguracija.Location = new System.Drawing.Point(37, 199);
            this.dgvListaKonfiguracija.Name = "dgvListaKonfiguracija";
            this.dgvListaKonfiguracija.RowHeadersWidth = 51;
            this.dgvListaKonfiguracija.RowTemplate.Height = 24;
            this.dgvListaKonfiguracija.Size = new System.Drawing.Size(610, 330);
            this.dgvListaKonfiguracija.TabIndex = 26;
            this.dgvListaKonfiguracija.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaKonfiguracija_CellContentClick);
            // 
            // FrmPredefinedConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 600);
            this.Controls.Add(this.dgvListaKonfiguracija);
            this.Controls.Add(this.cmbVrstaKonfiguracije);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.lblComputerType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDisplayAccordingToNeeds);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPredefinedConfiguration";
            this.Text = "Unaprijed definirane konfiguracije";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKonfiguracija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDisplayAccordingToNeeds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblComputerType;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.ComboBox cmbVrstaKonfiguracije;
        private System.Windows.Forms.DataGridView dgvListaKonfiguracija;
    }
}