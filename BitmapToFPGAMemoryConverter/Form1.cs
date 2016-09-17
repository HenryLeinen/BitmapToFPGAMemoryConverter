using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapToFPGAMemoryConverter
{
    public partial class Form1 : Form
    {
        byte[] rawData;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dlgOpenImageFile.ShowDialog() == DialogResult.OK)
            {
                tbBitmapFile.Text = dlgOpenImageFile.FileName;

                Image imgFile = Image.FromFile(dlgOpenImageFile.FileName);

                imgPreview.Image = imgFile;

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Get target file/name
            if (dlgSaveExportedFile.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = (Bitmap)Bitmap.FromFile(dlgOpenImageFile.FileName);

                using (StreamWriter outputFile = new StreamWriter(dlgSaveExportedFile.FileName))
                {
                    outputFile.WriteLine("memory_initialization_radix=16");
                    outputFile.WriteLine("memory_initialization_vector=");

                    for (int row = 0; row < bmp.Height; row++)
                        for (int col = 0; col < bmp.Width; col++)
                        {
                            string rowstring = string.Format("{0:x},{1:x},{2:x}", bmp.GetPixel(col, row).R, bmp.GetPixel(col, row).G, bmp.GetPixel(col, row).B);
                            if ((row != bmp.Height - 1) || (col != bmp.Width - 1))
                                rowstring += ",";
                            outputFile.WriteLine(rowstring);
                        }
                }
                MessageBox.Show("Export done !");
            }
        }

    }
}
