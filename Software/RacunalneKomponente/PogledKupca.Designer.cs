namespace RacunalneKomponente
{
    partial class frmCustomerView
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
            this.btnViewConfiguration = new System.Windows.Forms.Button();
            this.btnCreateConfiguration = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMyConfigs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(182, 35);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(227, 37);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Glavni izbornik";
            // 
            // btnViewConfiguration
            // 
            this.btnViewConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewConfiguration.Location = new System.Drawing.Point(100, 105);
            this.btnViewConfiguration.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewConfiguration.Name = "btnViewConfiguration";
            this.btnViewConfiguration.Size = new System.Drawing.Size(170, 113);
            this.btnViewConfiguration.TabIndex = 1;
            this.btnViewConfiguration.Text = "Pregledaj unaprijed definirane konfiguracije";
            this.btnViewConfiguration.UseVisualStyleBackColor = true;
            this.btnViewConfiguration.Click += new System.EventHandler(this.btnViewConfiguration_Click);
            // 
            // btnCreateConfiguration
            // 
            this.btnCreateConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateConfiguration.Location = new System.Drawing.Point(292, 105);
            this.btnCreateConfiguration.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateConfiguration.Name = "btnCreateConfiguration";
            this.btnCreateConfiguration.Size = new System.Drawing.Size(170, 113);
            this.btnCreateConfiguration.TabIndex = 2;
            this.btnCreateConfiguration.Text = "Kreiraj vlastitu konfiguraciju";
            this.btnCreateConfiguration.UseVisualStyleBackColor = true;
            this.btnCreateConfiguration.Click += new System.EventHandler(this.btnCreateConfiguration_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(383, 322);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Izađi";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMyConfigs
            // 
            this.btnMyConfigs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMyConfigs.Location = new System.Drawing.Point(100, 234);
            this.btnMyConfigs.Name = "btnMyConfigs";
            this.btnMyConfigs.Size = new System.Drawing.Size(362, 55);
            this.btnMyConfigs.TabIndex = 4;
            this.btnMyConfigs.Text = "Moje konfiguracije";
            this.btnMyConfigs.UseVisualStyleBackColor = true;
            this.btnMyConfigs.Click += new System.EventHandler(this.btnMyConfigs_Click);
            // 
            // frmCustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 379);
            this.ControlBox = false;
            this.Controls.Add(this.btnMyConfigs);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateConfiguration);
            this.Controls.Add(this.btnViewConfiguration);
            this.Controls.Add(this.lblMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCustomerView";
            this.Text = "Kupac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnViewConfiguration;
        private System.Windows.Forms.Button btnCreateConfiguration;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMyConfigs;
    }
}