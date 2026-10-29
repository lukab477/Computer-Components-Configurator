namespace RacunalneKomponente
{
    partial class frmWorkerView
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnAddComponent = new System.Windows.Forms.Button();
            this.btnCreateConfiguration = new System.Windows.Forms.Button();
            this.btnAprove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(243, 43);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(281, 46);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Glavni izbornik";
            // 
            // btnAddComponent
            // 
            this.btnAddComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComponent.Location = new System.Drawing.Point(133, 129);
            this.btnAddComponent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddComponent.Name = "btnAddComponent";
            this.btnAddComponent.Size = new System.Drawing.Size(227, 178);
            this.btnAddComponent.TabIndex = 1;
            this.btnAddComponent.Text = "Dodaj novu komponentu";
            this.btnAddComponent.UseVisualStyleBackColor = true;
            this.btnAddComponent.Click += new System.EventHandler(this.btnAddComponent_Click);
            // 
            // btnCreateConfiguration
            // 
            this.btnCreateConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateConfiguration.Location = new System.Drawing.Point(389, 129);
            this.btnCreateConfiguration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateConfiguration.Name = "btnCreateConfiguration";
            this.btnCreateConfiguration.Size = new System.Drawing.Size(227, 178);
            this.btnCreateConfiguration.TabIndex = 2;
            this.btnCreateConfiguration.Text = "Kreiraj novu konfiguraciju";
            this.btnCreateConfiguration.UseVisualStyleBackColor = true;
            this.btnCreateConfiguration.Click += new System.EventHandler(this.btnCreateConfiguration_Click);
            // 
            // btnAprove
            // 
            this.btnAprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprove.Location = new System.Drawing.Point(133, 326);
            this.btnAprove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAprove.Name = "btnAprove";
            this.btnAprove.Size = new System.Drawing.Size(227, 62);
            this.btnAprove.TabIndex = 3;
            this.btnAprove.Text = "Potvrdi kompatibilnost";
            this.btnAprove.UseVisualStyleBackColor = true;
            this.btnAprove.Click += new System.EventHandler(this.btnAprove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(638, 462);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 37);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Izađi";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(389, 326);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "Povijest konfiguracija";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(233, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Pregled komponenti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmWorkerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 521);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAprove);
            this.Controls.Add(this.btnCreateConfiguration);
            this.Controls.Add(this.btnAddComponent);
            this.Controls.Add(this.lblMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmWorkerView";
            this.Text = "Zaposlenik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnAddComponent;
        private System.Windows.Forms.Button btnCreateConfiguration;
        private System.Windows.Forms.Button btnAprove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}