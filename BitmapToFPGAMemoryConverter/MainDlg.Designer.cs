namespace BitmapToFPGAMemoryConverter
{
    partial class MainDlg
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAspectRatio = new System.Windows.Forms.CheckBox();
            this.tbHeight = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tbWIdth = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbGamma = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cbResizeQuality = new System.Windows.Forms.ComboBox();
            this.pbExport = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTiled = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbTileHeight = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTileWidth = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolutionRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolutionGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolutionBlue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWIdth)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGamma)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTileHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTileWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bitmap File:";
            // 
            // tbBitmapFile
            // 
            this.tbBitmapFile.Location = new System.Drawing.Point(69, 18);
            this.tbBitmapFile.Margin = new System.Windows.Forms.Padding(1);
            this.tbBitmapFile.Name = "tbBitmapFile";
            this.tbBitmapFile.Size = new System.Drawing.Size(310, 20);
            this.tbBitmapFile.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imgPreview
            // 
            this.imgPreview.Location = new System.Drawing.Point(69, 54);
            this.imgPreview.Margin = new System.Windows.Forms.Padding(1);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(308, 126);
            this.imgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPreview.TabIndex = 3;
            this.imgPreview.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preview:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Options:";
            // 
            // dlgOpenImageFile
            // 
            this.dlgOpenImageFile.Filter = "Bitmap Files (*.bmp)|*.bmp|JPEG Files (*.jpg)|*.jpg|GIF Image (*.gif)|*.gif|Porta" +
    "ble Network Graphic (*.png)|*.png|All Image Files|*.jpg;*.bmp;*.png;*.gif|All Fi" +
    "les (*.*)|*.*";
            this.dlgOpenImageFile.FilterIndex = 5;
            this.dlgOpenImageFile.Title = "Open Bitmap File";
            // 
            // tbResolutionRed
            // 
            this.tbResolutionRed.Location = new System.Drawing.Point(59, 23);
            this.tbResolutionRed.Margin = new System.Windows.Forms.Padding(1);
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
            this.tbResolutionRed.Size = new System.Drawing.Size(51, 20);
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
            this.label4.Location = new System.Drawing.Point(21, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Red:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Green:";
            // 
            // tbResolutionGreen
            // 
            this.tbResolutionGreen.Location = new System.Drawing.Point(59, 42);
            this.tbResolutionGreen.Margin = new System.Windows.Forms.Padding(1);
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
            this.tbResolutionGreen.Size = new System.Drawing.Size(51, 20);
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
            this.label6.Location = new System.Drawing.Point(21, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Blue:";
            // 
            // tbResolutionBlue
            // 
            this.tbResolutionBlue.Location = new System.Drawing.Point(59, 60);
            this.tbResolutionBlue.Margin = new System.Windows.Forms.Padding(1);
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
            this.tbResolutionBlue.Size = new System.Drawing.Size(51, 20);
            this.tbResolutionBlue.TabIndex = 10;
            this.tbResolutionBlue.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(201, 291);
            this.btnExport.Margin = new System.Windows.Forms.Padding(1);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(87, 22);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "&Export...";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dlgSaveExportedFile
            // 
            this.dlgSaveExportedFile.DefaultExt = "coe";
            this.dlgSaveExportedFile.Filter = "XILINX Memory (*.coe)|*.coe|Intel HEX File (*.hex)|*.hex|All Files (*.*)|*.*";
            this.dlgSaveExportedFile.Title = "Select Output File";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbResolutionRed);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbResolutionBlue);
            this.groupBox1.Controls.Add(this.tbResolutionGreen);
            this.groupBox1.Location = new System.Drawing.Point(69, 194);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(123, 91);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bit depth";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbAspectRatio);
            this.groupBox2.Controls.Add(this.tbHeight);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbWIdth);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(201, 194);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(132, 91);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image size";
            // 
            // cbAspectRatio
            // 
            this.cbAspectRatio.AutoSize = true;
            this.cbAspectRatio.Checked = true;
            this.cbAspectRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAspectRatio.Location = new System.Drawing.Point(12, 61);
            this.cbAspectRatio.Margin = new System.Windows.Forms.Padding(1);
            this.cbAspectRatio.Name = "cbAspectRatio";
            this.cbAspectRatio.Size = new System.Drawing.Size(109, 17);
            this.cbAspectRatio.TabIndex = 4;
            this.cbAspectRatio.Text = "Keep aspect ratio";
            this.cbAspectRatio.UseVisualStyleBackColor = true;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(69, 43);
            this.tbHeight.Margin = new System.Windows.Forms.Padding(1);
            this.tbHeight.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.tbHeight.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(51, 20);
            this.tbHeight.TabIndex = 3;
            this.tbHeight.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.tbHeight.ValueChanged += new System.EventHandler(this.tbHeight_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Height:";
            // 
            // tbWIdth
            // 
            this.tbWIdth.Location = new System.Drawing.Point(69, 23);
            this.tbWIdth.Margin = new System.Windows.Forms.Padding(1);
            this.tbWIdth.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.tbWIdth.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.tbWIdth.Name = "tbWIdth";
            this.tbWIdth.Size = new System.Drawing.Size(51, 20);
            this.tbWIdth.TabIndex = 1;
            this.tbWIdth.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.tbWIdth.ValueChanged += new System.EventHandler(this.tbWIdth_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Width:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbGamma);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbResizeQuality);
            this.groupBox3.Location = new System.Drawing.Point(343, 194);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox3.Size = new System.Drawing.Size(137, 92);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image Quality";
            // 
            // tbGamma
            // 
            this.tbGamma.DecimalPlaces = 2;
            this.tbGamma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tbGamma.Location = new System.Drawing.Point(57, 51);
            this.tbGamma.Margin = new System.Windows.Forms.Padding(1);
            this.tbGamma.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.tbGamma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tbGamma.Name = "tbGamma";
            this.tbGamma.Size = new System.Drawing.Size(51, 20);
            this.tbGamma.TabIndex = 2;
            this.tbGamma.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.tbGamma.ValueChanged += new System.EventHandler(this.tbGamma_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 51);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Gamma:";
            // 
            // cbResizeQuality
            // 
            this.cbResizeQuality.FormattingEnabled = true;
            this.cbResizeQuality.Items.AddRange(new object[] {
            "Low",
            "High",
            "Bilinear",
            "Bicubic",
            "NearestNeighbor",
            "HighQualityBilinear",
            "HighQualityBicubic"});
            this.cbResizeQuality.Location = new System.Drawing.Point(10, 22);
            this.cbResizeQuality.Margin = new System.Windows.Forms.Padding(1);
            this.cbResizeQuality.Name = "cbResizeQuality";
            this.cbResizeQuality.Size = new System.Drawing.Size(119, 21);
            this.cbResizeQuality.TabIndex = 0;
            this.cbResizeQuality.Text = "HighQualityBicubic";
            this.cbResizeQuality.SelectedIndexChanged += new System.EventHandler(this.cbResizeQuality_SelectedIndexChanged);
            // 
            // pbExport
            // 
            this.pbExport.Location = new System.Drawing.Point(2, 0);
            this.pbExport.Margin = new System.Windows.Forms.Padding(1);
            this.pbExport.Name = "pbExport";
            this.pbExport.Size = new System.Drawing.Size(510, 4);
            this.pbExport.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbExport.TabIndex = 16;
            this.pbExport.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Export:";
            // 
            // cbTiled
            // 
            this.cbTiled.AutoSize = true;
            this.cbTiled.Location = new System.Drawing.Point(69, 295);
            this.cbTiled.Name = "cbTiled";
            this.cbTiled.Size = new System.Drawing.Size(81, 17);
            this.cbTiled.TabIndex = 18;
            this.cbTiled.Text = "Tiled export";
            this.cbTiled.UseVisualStyleBackColor = true;
            this.cbTiled.CheckedChanged += new System.EventHandler(this.cbTiled_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbTileHeight);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.tbTileWidth);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(69, 316);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox4.Size = new System.Drawing.Size(132, 78);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tile size";
            // 
            // tbTileHeight
            // 
            this.tbTileHeight.Enabled = false;
            this.tbTileHeight.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.tbTileHeight.Location = new System.Drawing.Point(69, 43);
            this.tbTileHeight.Margin = new System.Windows.Forms.Padding(1);
            this.tbTileHeight.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.tbTileHeight.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.tbTileHeight.Name = "tbTileHeight";
            this.tbTileHeight.Size = new System.Drawing.Size(51, 20);
            this.tbTileHeight.TabIndex = 3;
            this.tbTileHeight.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 42);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Height:";
            // 
            // tbTileWidth
            // 
            this.tbTileWidth.Enabled = false;
            this.tbTileWidth.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.tbTileWidth.Location = new System.Drawing.Point(69, 23);
            this.tbTileWidth.Margin = new System.Windows.Forms.Padding(1);
            this.tbTileWidth.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.tbTileWidth.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.tbTileWidth.Name = "tbTileWidth";
            this.tbTileWidth.Size = new System.Drawing.Size(51, 20);
            this.tbTileWidth.TabIndex = 1;
            this.tbTileWidth.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 24);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Width:";
            // 
            // MainDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 404);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.cbTiled);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pbExport);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgPreview);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbBitmapFile);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainDlg";
            this.Text = "ImageConverter";
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolutionRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolutionGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolutionBlue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWIdth)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGamma)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTileHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTileWidth)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbAspectRatio;
        private System.Windows.Forms.NumericUpDown tbHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown tbWIdth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbResizeQuality;
        private System.Windows.Forms.NumericUpDown tbGamma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar pbExport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbTiled;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown tbTileHeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown tbTileWidth;
        private System.Windows.Forms.Label label12;
    }
}

