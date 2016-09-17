namespace BitmapToFPGAMemoryConverter
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbBitmapFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imgPreview = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dlgOpenImageFile = new System.Windows.Forms.OpenFileDialog();
            this.tbResolutionRed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbResolutionGreen = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tbResolutionBlue = new System.Windows.Forms.NumericUpDown();
            this.btnExport = new System.Windows.Forms.Button();
            this.dlgSaveExportedFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolutionRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolutionGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolutionBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bitmap File:";
            // 
            // tbBitmapFile
            // 
            this.tbBitmapFile.Location = new System.Drawing.Point(160, 40);
            this.tbBitmapFile.Name = "tbBitmapFile";
            this.tbBitmapFile.Size = new System.Drawing.Size(718, 35);
            this.tbBitmapFile.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(899, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imgPreview
            // 
            this.imgPreview.Location = new System.Drawing.Point(160, 120);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(718, 282);
            this.imgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPreview.TabIndex = 3;
            this.imgPreview.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preview:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bit depth:";
            // 
            // dlgOpenImageFile
            // 
            this.dlgOpenImageFile.DefaultExt = "bmp";
            this.dlgOpenImageFile.Filter = "Bitmap Files (*.bmp)|*.bmp|JPEG Files (*.jpg)|*.jpg|All Image Files|*.jpg;*.bmp|A" +
    "ll Files (*.*)|*.*";
            this.dlgOpenImageFile.Title = "Open Bitmap File";
            // 
            // tbResolutionRed
            // 
            this.tbResolutionRed.Location = new System.Drawing.Point(247, 431);
            this.tbResolutionRed.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.tbResolutionRed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbResolutionRed.Name = "tbResolutionRed";
            this.tbResolutionRed.Size = new System.Drawing.Size(120, 35);
            this.tbResolutionRed.TabIndex = 6;
            this.tbResolutionRed.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Red:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Green:";
            // 
            // tbResolutionGreen
            // 
            this.tbResolutionGreen.Location = new System.Drawing.Point(247, 472);
            this.tbResolutionGreen.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.tbResolutionGreen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbResolutionGreen.Name = "tbResolutionGreen";
            this.tbResolutionGreen.Size = new System.Drawing.Size(120, 35);
            this.tbResolutionGreen.TabIndex = 8;
            this.tbResolutionGreen.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Blue:";
            // 
            // tbResolutionBlue
            // 
            this.tbResolutionBlue.Location = new System.Drawing.Point(247, 513);
            this.tbResolutionBlue.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.tbResolutionBlue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbResolutionBlue.Name = "tbResolutionBlue";
            this.tbResolutionBlue.Size = new System.Drawing.Size(120, 35);
            this.tbResolutionBlue.TabIndex = 10;
            this.tbResolutionBlue.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(165, 593);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(202, 49);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "&Export...";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dlgSaveExportedFile
            // 
            this.dlgSaveExportedFile.DefaultExt = "coe";
            this.dlgSaveExportedFile.Filter = "XILINX Memory (*.coe)|*.coe|All Files (*.*)|*.*";
            this.dlgSaveExportedFile.RestoreDirectory = true;
            this.dlgSaveExportedFile.Title = "Select Output File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 721);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbResolutionBlue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbResolutionGreen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbResolutionRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgPreview);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbBitmapFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolutionRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolutionGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolutionBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBitmapFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imgPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog dlgOpenImageFile;
        private System.Windows.Forms.NumericUpDown tbResolutionRed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown tbResolutionGreen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown tbResolutionBlue;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog dlgSaveExportedFile;
    }
}

