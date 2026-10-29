namespace RacunalneKomponente
{
    partial class frmCreateConfiguration
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
            this.tabComponents = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstCPUs = new System.Windows.Forms.ListBox();
            this.lblCPU = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstGPUs = new System.Windows.Forms.ListBox();
            this.lblGPUs = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lstMBOs = new System.Windows.Forms.ListBox();
            this.lblMBOs = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lstRAMs = new System.Windows.Forms.ListBox();
            this.lblRAMs = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lstStorage = new System.Windows.Forms.ListBox();
            this.lblStorage = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lstPSUs = new System.Windows.Forms.ListBox();
            this.lblPSUs = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.lstCases = new System.Windows.Forms.ListBox();
            this.lblCases = new System.Windows.Forms.Label();
            this.pnlSelectedComponents = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblSelectedComponents = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tabComponents.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCreateConfiguration
            // 
            this.lblCreateConfiguration.AutoSize = true;
            this.lblCreateConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateConfiguration.Location = new System.Drawing.Point(239, 9);
            this.lblCreateConfiguration.Name = "lblCreateConfiguration";
            this.lblCreateConfiguration.Size = new System.Drawing.Size(506, 46);
            this.lblCreateConfiguration.TabIndex = 0;
            this.lblCreateConfiguration.Text = "Kreiraj vlastitu konfiguraciju";
            // 
            // tabComponents
            // 
            this.tabComponents.Controls.Add(this.tabPage1);
            this.tabComponents.Controls.Add(this.tabPage2);
            this.tabComponents.Controls.Add(this.tabPage3);
            this.tabComponents.Controls.Add(this.tabPage4);
            this.tabComponents.Controls.Add(this.tabPage5);
            this.tabComponents.Controls.Add(this.tabPage6);
            this.tabComponents.Controls.Add(this.tabPage7);
            this.tabComponents.Location = new System.Drawing.Point(27, 71);
            this.tabComponents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabComponents.Name = "tabComponents";
            this.tabComponents.SelectedIndex = 0;
            this.tabComponents.Size = new System.Drawing.Size(580, 405);
            this.tabComponents.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstCPUs);
            this.tabPage1.Controls.Add(this.lblCPU);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(572, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Procesori";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstCPUs
            // 
            this.lstCPUs.FormattingEnabled = true;
            this.lstCPUs.ItemHeight = 16;
            this.lstCPUs.Location = new System.Drawing.Point(5, 31);
            this.lstCPUs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstCPUs.Name = "lstCPUs";
            this.lstCPUs.Size = new System.Drawing.Size(560, 340);
            this.lstCPUs.TabIndex = 1;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(5, 12);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(68, 16);
            this.lblCPU.TabIndex = 0;
            this.lblCPU.Text = "Procesori:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstGPUs);
            this.tabPage2.Controls.Add(this.lblGPUs);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(572, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grafičke kartice";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstGPUs
            // 
            this.lstGPUs.FormattingEnabled = true;
            this.lstGPUs.ItemHeight = 16;
            this.lstGPUs.Location = new System.Drawing.Point(5, 31);
            this.lstGPUs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstGPUs.Name = "lstGPUs";
            this.lstGPUs.Size = new System.Drawing.Size(560, 340);
            this.lstGPUs.TabIndex = 1;
            // 
            // lblGPUs
            // 
            this.lblGPUs.AutoSize = true;
            this.lblGPUs.Location = new System.Drawing.Point(5, 12);
            this.lblGPUs.Name = "lblGPUs";
            this.lblGPUs.Size = new System.Drawing.Size(103, 16);
            this.lblGPUs.TabIndex = 0;
            this.lblGPUs.Text = "Grafičke kartice:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lstMBOs);
            this.tabPage3.Controls.Add(this.lblMBOs);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(572, 376);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Matične ploče";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lstMBOs
            // 
            this.lstMBOs.FormattingEnabled = true;
            this.lstMBOs.ItemHeight = 16;
            this.lstMBOs.Location = new System.Drawing.Point(5, 31);
            this.lstMBOs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMBOs.Name = "lstMBOs";
            this.lstMBOs.Size = new System.Drawing.Size(560, 340);
            this.lstMBOs.TabIndex = 1;
            // 
            // lblMBOs
            // 
            this.lblMBOs.AutoSize = true;
            this.lblMBOs.Location = new System.Drawing.Point(5, 12);
            this.lblMBOs.Name = "lblMBOs";
            this.lblMBOs.Size = new System.Drawing.Size(94, 16);
            this.lblMBOs.TabIndex = 0;
            this.lblMBOs.Text = "Matične ploče:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lstRAMs);
            this.tabPage4.Controls.Add(this.lblRAMs);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(572, 376);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Radne memorije";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lstRAMs
            // 
            this.lstRAMs.FormattingEnabled = true;
            this.lstRAMs.ItemHeight = 16;
            this.lstRAMs.Location = new System.Drawing.Point(5, 31);
            this.lstRAMs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstRAMs.Name = "lstRAMs";
            this.lstRAMs.Size = new System.Drawing.Size(560, 340);
            this.lstRAMs.TabIndex = 1;
            // 
            // lblRAMs
            // 
            this.lblRAMs.AutoSize = true;
            this.lblRAMs.Location = new System.Drawing.Point(5, 12);
            this.lblRAMs.Name = "lblRAMs";
            this.lblRAMs.Size = new System.Drawing.Size(110, 16);
            this.lblRAMs.TabIndex = 0;
            this.lblRAMs.Text = "Radne memorije:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lstStorage);
            this.tabPage5.Controls.Add(this.lblStorage);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Size = new System.Drawing.Size(572, 376);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Pohrana";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lstStorage
            // 
            this.lstStorage.FormattingEnabled = true;
            this.lstStorage.ItemHeight = 16;
            this.lstStorage.Location = new System.Drawing.Point(5, 31);
            this.lstStorage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstStorage.Name = "lstStorage";
            this.lstStorage.Size = new System.Drawing.Size(560, 340);
            this.lstStorage.TabIndex = 1;
            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.Location = new System.Drawing.Point(5, 12);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(61, 16);
            this.lblStorage.TabIndex = 0;
            this.lblStorage.Text = "Pohrana:";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.lstPSUs);
            this.tabPage6.Controls.Add(this.lblPSUs);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage6.Size = new System.Drawing.Size(572, 376);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Napajanja";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // lstPSUs
            // 
            this.lstPSUs.FormattingEnabled = true;
            this.lstPSUs.ItemHeight = 16;
            this.lstPSUs.Location = new System.Drawing.Point(5, 31);
            this.lstPSUs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstPSUs.Name = "lstPSUs";
            this.lstPSUs.Size = new System.Drawing.Size(560, 340);
            this.lstPSUs.TabIndex = 1;
            // 
            // lblPSUs
            // 
            this.lblPSUs.AutoSize = true;
            this.lblPSUs.Location = new System.Drawing.Point(5, 12);
            this.lblPSUs.Name = "lblPSUs";
            this.lblPSUs.Size = new System.Drawing.Size(70, 16);
            this.lblPSUs.TabIndex = 0;
            this.lblPSUs.Text = "Napajanja";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.lstCases);
            this.tabPage7.Controls.Add(this.lblCases);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage7.Size = new System.Drawing.Size(572, 376);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Kućišta";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // lstCases
            // 
            this.lstCases.FormattingEnabled = true;
            this.lstCases.ItemHeight = 16;
            this.lstCases.Location = new System.Drawing.Point(5, 31);
            this.lstCases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstCases.Name = "lstCases";
            this.lstCases.Size = new System.Drawing.Size(560, 340);
            this.lstCases.TabIndex = 1;
            // 
            // lblCases
            // 
            this.lblCases.AutoSize = true;
            this.lblCases.Location = new System.Drawing.Point(5, 12);
            this.lblCases.Name = "lblCases";
            this.lblCases.Size = new System.Drawing.Size(53, 16);
            this.lblCases.TabIndex = 0;
            this.lblCases.Text = "Kućišta:";
            // 
            // pnlSelectedComponents
            // 
            this.pnlSelectedComponents.AllowDrop = true;
            this.pnlSelectedComponents.AutoScroll = true;
            this.pnlSelectedComponents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelectedComponents.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlSelectedComponents.Location = new System.Drawing.Point(632, 96);
            this.pnlSelectedComponents.Name = "pnlSelectedComponents";
            this.pnlSelectedComponents.Size = new System.Drawing.Size(344, 288);
            this.pnlSelectedComponents.TabIndex = 0;
            this.pnlSelectedComponents.WrapContents = false;
            this.pnlSelectedComponents.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlSelectedComponents_DragDrop);
            this.pnlSelectedComponents.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlSelectedComponents_DragEnter);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(669, 446);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 46);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(832, 446);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 46);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Nastavi na pregled";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblSelectedComponents
            // 
            this.lblSelectedComponents.AutoSize = true;
            this.lblSelectedComponents.Location = new System.Drawing.Point(630, 76);
            this.lblSelectedComponents.Name = "lblSelectedComponents";
            this.lblSelectedComponents.Size = new System.Drawing.Size(149, 16);
            this.lblSelectedComponents.TabIndex = 5;
            this.lblSelectedComponents.Text = "Odabrane komponente:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(633, 390);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(241, 16);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Niste još odabrali ni jednu komponentu.";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(636, 414);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 16);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Cijena:";
            // 
            // frmCreateConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 514);
            this.ControlBox = false;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSelectedComponents);
            this.Controls.Add(this.pnlSelectedComponents);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabComponents);
            this.Controls.Add(this.lblCreateConfiguration);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCreateConfiguration";
            this.Text = "Kreiraj vlastitu konfiguraciju";
            this.Load += new System.EventHandler(this.frmCreateConfiguration_Load);
            this.tabComponents.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateConfiguration;
        private System.Windows.Forms.TabControl tabComponents;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ListBox lstCPUs;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblGPUs;
        private System.Windows.Forms.Label lblMBOs;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblRAMs;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.Label lblPSUs;
        private System.Windows.Forms.ListBox lstGPUs;
        private System.Windows.Forms.ListBox lstMBOs;
        private System.Windows.Forms.ListBox lstRAMs;
        private System.Windows.Forms.ListBox lstStorage;
        private System.Windows.Forms.ListBox lstPSUs;
        private System.Windows.Forms.ListBox lstCases;
        private System.Windows.Forms.Label lblCases;
        private System.Windows.Forms.FlowLayoutPanel pnlSelectedComponents;
        private System.Windows.Forms.Label lblSelectedComponents;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPrice;
    }
}