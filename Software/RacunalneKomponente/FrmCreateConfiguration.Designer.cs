namespace RačunalneKomponente
{
    partial class FrmCreateConfiguration
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
            this.lblCreateConfiguration = new System.Windows.Forms.Label();
            this.lblGraphicsCard = new System.Windows.Forms.Label();
            this.lblChoseComponent = new System.Windows.Forms.Label();
            this.lblCooling = new System.Windows.Forms.Label();
            this.lblWorkingMemory = new System.Windows.Forms.Label();
            this.lblHousing = new System.Windows.Forms.Label();
            this.lblProcessor = new System.Windows.Forms.Label();
            this.lblStorage = new System.Windows.Forms.Label();
            this.lblMotherboard = new System.Windows.Forms.Label();
            this.lblConfigurationType = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.cmbProcesor = new System.Windows.Forms.ComboBox();
            this.cmbVrstaKonfiguracije = new System.Windows.Forms.ComboBox();
            this.txtNazivKonfiguracije = new System.Windows.Forms.TextBox();
            this.lblNazivKonfiguracije = new System.Windows.Forms.Label();
            this.cmbPohrana = new System.Windows.Forms.ComboBox();
            this.cmbMaticna = new System.Windows.Forms.ComboBox();
            this.cmbKuciste = new System.Windows.Forms.ComboBox();
            this.cmbGraficka = new System.Windows.Forms.ComboBox();
            this.cmbHladenje = new System.Windows.Forms.ComboBox();
            this.cmbRAM = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCreateConfiguration
            // 
            this.lblCreateConfiguration.AutoSize = true;
            this.lblCreateConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCreateConfiguration.Location = new System.Drawing.Point(345, 35);
            this.lblCreateConfiguration.Name = "lblCreateConfiguration";
            this.lblCreateConfiguration.Size = new System.Drawing.Size(226, 29);
            this.lblCreateConfiguration.TabIndex = 0;
            this.lblCreateConfiguration.Text = "Kreiraj konfiguraciju";
            // 
            // lblGraphicsCard
            // 
            this.lblGraphicsCard.AutoSize = true;
            this.lblGraphicsCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGraphicsCard.Location = new System.Drawing.Point(463, 284);
            this.lblGraphicsCard.Name = "lblGraphicsCard";
            this.lblGraphicsCard.Size = new System.Drawing.Size(132, 20);
            this.lblGraphicsCard.TabIndex = 2;
            this.lblGraphicsCard.Text = "Grafička kartica ";
            // 
            // lblChoseComponent
            // 
            this.lblChoseComponent.AutoSize = true;
            this.lblChoseComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblChoseComponent.Location = new System.Drawing.Point(52, 226);
            this.lblChoseComponent.Name = "lblChoseComponent";
            this.lblChoseComponent.Size = new System.Drawing.Size(177, 22);
            this.lblChoseComponent.TabIndex = 3;
            this.lblChoseComponent.Text = "Odaberi komponente";
            // 
            // lblCooling
            // 
            this.lblCooling.AutoSize = true;
            this.lblCooling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCooling.Location = new System.Drawing.Point(465, 341);
            this.lblCooling.Name = "lblCooling";
            this.lblCooling.Size = new System.Drawing.Size(75, 20);
            this.lblCooling.TabIndex = 4;
            this.lblCooling.Text = "Hlađenje";
            // 
            // lblWorkingMemory
            // 
            this.lblWorkingMemory.AutoSize = true;
            this.lblWorkingMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWorkingMemory.Location = new System.Drawing.Point(463, 394);
            this.lblWorkingMemory.Name = "lblWorkingMemory";
            this.lblWorkingMemory.Size = new System.Drawing.Size(184, 20);
            this.lblWorkingMemory.TabIndex = 5;
            this.lblWorkingMemory.Text = "Radna memorija - RAM";
            // 
            // lblHousing
            // 
            this.lblHousing.AutoSize = true;
            this.lblHousing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHousing.Location = new System.Drawing.Point(52, 440);
            this.lblHousing.Name = "lblHousing";
            this.lblHousing.Size = new System.Drawing.Size(65, 20);
            this.lblHousing.TabIndex = 6;
            this.lblHousing.Text = "Kučište";
            // 
            // lblProcessor
            // 
            this.lblProcessor.AutoSize = true;
            this.lblProcessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProcessor.Location = new System.Drawing.Point(51, 284);
            this.lblProcessor.Name = "lblProcessor";
            this.lblProcessor.Size = new System.Drawing.Size(77, 20);
            this.lblProcessor.TabIndex = 7;
            this.lblProcessor.Text = "Procesor";
            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStorage.Location = new System.Drawing.Point(51, 387);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(71, 20);
            this.lblStorage.TabIndex = 8;
            this.lblStorage.Text = "Pohrana";
            // 
            // lblMotherboard
            // 
            this.lblMotherboard.AutoSize = true;
            this.lblMotherboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMotherboard.Location = new System.Drawing.Point(51, 331);
            this.lblMotherboard.Name = "lblMotherboard";
            this.lblMotherboard.Size = new System.Drawing.Size(113, 20);
            this.lblMotherboard.TabIndex = 9;
            this.lblMotherboard.Text = "Matična ploča";
            // 
            // lblConfigurationType
            // 
            this.lblConfigurationType.AutoSize = true;
            this.lblConfigurationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblConfigurationType.Location = new System.Drawing.Point(52, 117);
            this.lblConfigurationType.Name = "lblConfigurationType";
            this.lblConfigurationType.Size = new System.Drawing.Size(158, 22);
            this.lblConfigurationType.TabIndex = 10;
            this.lblConfigurationType.Text = "Vrsta konfiguracije";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(813, 466);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 37);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Dodaj ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Location = new System.Drawing.Point(712, 466);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(81, 37);
            this.btnGiveUp.TabIndex = 25;
            this.btnGiveUp.Text = "Odustani";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // cmbProcesor
            // 
            this.cmbProcesor.FormattingEnabled = true;
            this.cmbProcesor.Location = new System.Drawing.Point(182, 284);
            this.cmbProcesor.Name = "cmbProcesor";
            this.cmbProcesor.Size = new System.Drawing.Size(203, 24);
            this.cmbProcesor.TabIndex = 26;
            this.cmbProcesor.SelectedIndexChanged += new System.EventHandler(this.cmbProcesor_SelectedIndexChanged);
            // 
            // cmbVrstaKonfiguracije
            // 
            this.cmbVrstaKonfiguracije.FormattingEnabled = true;
            this.cmbVrstaKonfiguracije.Location = new System.Drawing.Point(231, 119);
            this.cmbVrstaKonfiguracije.Name = "cmbVrstaKonfiguracije";
            this.cmbVrstaKonfiguracije.Size = new System.Drawing.Size(154, 24);
            this.cmbVrstaKonfiguracije.TabIndex = 27;
            // 
            // txtNazivKonfiguracije
            // 
            this.txtNazivKonfiguracije.Location = new System.Drawing.Point(231, 166);
            this.txtNazivKonfiguracije.Name = "txtNazivKonfiguracije";
            this.txtNazivKonfiguracije.Size = new System.Drawing.Size(154, 22);
            this.txtNazivKonfiguracije.TabIndex = 29;
            // 
            // lblNazivKonfiguracije
            // 
            this.lblNazivKonfiguracije.AutoSize = true;
            this.lblNazivKonfiguracije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivKonfiguracije.Location = new System.Drawing.Point(52, 164);
            this.lblNazivKonfiguracije.Name = "lblNazivKonfiguracije";
            this.lblNazivKonfiguracije.Size = new System.Drawing.Size(160, 22);
            this.lblNazivKonfiguracije.TabIndex = 30;
            this.lblNazivKonfiguracije.Text = "Naziv konfiguracije";
            // 
            // cmbPohrana
            // 
            this.cmbPohrana.FormattingEnabled = true;
            this.cmbPohrana.Location = new System.Drawing.Point(182, 387);
            this.cmbPohrana.Name = "cmbPohrana";
            this.cmbPohrana.Size = new System.Drawing.Size(203, 24);
            this.cmbPohrana.TabIndex = 31;
            // 
            // cmbMaticna
            // 
            this.cmbMaticna.FormattingEnabled = true;
            this.cmbMaticna.Location = new System.Drawing.Point(182, 334);
            this.cmbMaticna.Name = "cmbMaticna";
            this.cmbMaticna.Size = new System.Drawing.Size(203, 24);
            this.cmbMaticna.TabIndex = 32;
            // 
            // cmbKuciste
            // 
            this.cmbKuciste.FormattingEnabled = true;
            this.cmbKuciste.Location = new System.Drawing.Point(182, 440);
            this.cmbKuciste.Name = "cmbKuciste";
            this.cmbKuciste.Size = new System.Drawing.Size(203, 24);
            this.cmbKuciste.TabIndex = 33;
            // 
            // cmbGraficka
            // 
            this.cmbGraficka.FormattingEnabled = true;
            this.cmbGraficka.Location = new System.Drawing.Point(664, 284);
            this.cmbGraficka.Name = "cmbGraficka";
            this.cmbGraficka.Size = new System.Drawing.Size(203, 24);
            this.cmbGraficka.TabIndex = 34;
            // 
            // cmbHladenje
            // 
            this.cmbHladenje.FormattingEnabled = true;
            this.cmbHladenje.Location = new System.Drawing.Point(664, 341);
            this.cmbHladenje.Name = "cmbHladenje";
            this.cmbHladenje.Size = new System.Drawing.Size(203, 24);
            this.cmbHladenje.TabIndex = 35;
            // 
            // cmbRAM
            // 
            this.cmbRAM.FormattingEnabled = true;
            this.cmbRAM.Location = new System.Drawing.Point(664, 394);
            this.cmbRAM.Name = "cmbRAM";
            this.cmbRAM.Size = new System.Drawing.Size(203, 24);
            this.cmbRAM.TabIndex = 36;
            // 
            // FrmCreateConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 517);
            this.Controls.Add(this.cmbRAM);
            this.Controls.Add(this.cmbHladenje);
            this.Controls.Add(this.cmbGraficka);
            this.Controls.Add(this.cmbKuciste);
            this.Controls.Add(this.cmbMaticna);
            this.Controls.Add(this.cmbPohrana);
            this.Controls.Add(this.lblNazivKonfiguracije);
            this.Controls.Add(this.txtNazivKonfiguracije);
            this.Controls.Add(this.cmbVrstaKonfiguracije);
            this.Controls.Add(this.cmbProcesor);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblConfigurationType);
            this.Controls.Add(this.lblMotherboard);
            this.Controls.Add(this.lblStorage);
            this.Controls.Add(this.lblProcessor);
            this.Controls.Add(this.lblHousing);
            this.Controls.Add(this.lblWorkingMemory);
            this.Controls.Add(this.lblCooling);
            this.Controls.Add(this.lblChoseComponent);
            this.Controls.Add(this.lblGraphicsCard);
            this.Controls.Add(this.lblCreateConfiguration);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCreateConfiguration";
            this.Text = "Kreiraj konfiguraciju";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateConfiguration;
        private System.Windows.Forms.Label lblGraphicsCard;
        private System.Windows.Forms.Label lblChoseComponent;
        private System.Windows.Forms.Label lblCooling;
        private System.Windows.Forms.Label lblWorkingMemory;
        private System.Windows.Forms.Label lblHousing;
        private System.Windows.Forms.Label lblProcessor;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.Label lblMotherboard;
        private System.Windows.Forms.Label lblConfigurationType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.ComboBox cmbProcesor;
        private System.Windows.Forms.ComboBox cmbVrstaKonfiguracije;
        private System.Windows.Forms.TextBox txtNazivKonfiguracije;
        private System.Windows.Forms.Label lblNazivKonfiguracije;
        private System.Windows.Forms.ComboBox cmbPohrana;
        private System.Windows.Forms.ComboBox cmbMaticna;
        private System.Windows.Forms.ComboBox cmbKuciste;
        private System.Windows.Forms.ComboBox cmbGraficka;
        private System.Windows.Forms.ComboBox cmbHladenje;
        private System.Windows.Forms.ComboBox cmbRAM;
    }
}