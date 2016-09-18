using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapToFPGAMemoryConverter
{
    public partial class MainDlg : Form
    {
        Image orgImage;

        int orgImgWidth;
        int orgImgHeight;

        float gamma;

        bool bAvoidUpdateWidth, bAvoidUpdateHeight;

        System.Drawing.Drawing2D.InterpolationMode interpolationmode = System.Drawing.Drawing2D.InterpolationMode.Default;

        public MainDlg()
        {
            InitializeComponent();
            bAvoidUpdateWidth = bAvoidUpdateHeight = false;
            orgImgWidth = orgImgHeight = 0;
            gamma = 2.5f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dlgOpenImageFile.ShowDialog() == DialogResult.OK)
            {
                tbBitmapFile.Text = dlgOpenImageFile.FileName;

                orgImage = Bitmap.FromFile(dlgOpenImageFile.FileName);

                orgImgWidth = orgImage.Width;
                orgImgHeight = orgImage.Height;

                UpdateImage();

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Get target file/name
            if (dlgSaveExportedFile.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = (Bitmap)Bitmap.FromFile(dlgOpenImageFile.FileName);

                string[] parts = dlgSaveExportedFile.FileName.Split('.');
                if (parts.Last().ToUpper() == "COE")
                {
                    if (cbTiled.Checked)
                    {
                        if (((imgPreview.Width % tbTileWidth.Value) != 0) || ((imgPreview.Height % tbTileHeight.Value) != 0))
                        {
                            MessageBox.Show("Tiling not possible if image width/height is not a multiple of tile width/height !", "Export error");
                        }
                        else
                        {
                            for (int h = 0; h < imgPreview.Height / tbTileHeight.Value; h++)
                            {
                                for (int w = 0; w < imgPreview.Width / tbTileWidth.Value; w++)
                                {
                                    string FileName = string.Format("{0}_W{1}_H{2}", dlgSaveExportedFile.FileName, w, h);
                                    ExportBitmapCOE((Bitmap)imgPreview.Image, FileName, w * (int)tbTileWidth.Value, h * (int)tbTileHeight.Value, (int)tbTileWidth.Value, (int)tbTileHeight.Value);
                                }
                            }
                        }
                    }
                    else
                    {
                        ExportBitmapCOE((Bitmap)imgPreview.Image, dlgSaveExportedFile.FileName, 0, 0, imgPreview.Width, imgPreview.Height);
                    }
                }
                else if (parts.Last().ToUpper() == "HEX")
                {
                    ExportBitmapHEX((Bitmap)imgPreview.Image, dlgSaveExportedFile.FileName);
                } else
                {
                    MessageBox.Show("Unknown target file format", "Error");
                }

                MessageBox.Show("Export done !");
            }
        }

        /// <summary>
        /// ExportBitmapHEX will write the pixel information of the given Bitmap object in a text file
        /// according to the INTEL HEX file format
        /// </summary>
        /// <param name="bmp"></param>
        /// <param name="outFileName"></param>
        private void ExportBitmapHEX(Bitmap bmp, string outFileName)
        {
            pbExport.Minimum = 0;
            pbExport.Maximum = bmp.Width - 1;
            pbExport.Value = 0;
            pbExport.Visible = true;
            using (StreamWriter outputFile = new StreamWriter(outFileName))
            {
                byte numBitsR = (byte)tbResolutionRed.Value;
                byte numBitsG = (byte)tbResolutionGreen.Value;
                byte numBitsB = (byte)tbResolutionBlue.Value;

                byte numBytes = (byte)((numBitsB + numBitsG + numBitsR) / 8);
                ulong addr = 0;
                byte chksum = 0;
                for (int row = 0; row < bmp.Height; row++)
                {
                    for (int col = 0; col < bmp.Width; col++)
                    {
                        Color clr = bmp.GetPixel(col, row);
                        chksum = (byte)(numBytes + (byte)(addr % 256) + (byte)(addr / 256) + clr.R + clr.G + clr.B);
                        chksum ^= 0xff;
                        chksum += 1;
                        string rowstring = string.Format(":{0:X2}{1:X4}00{2:X2}{3:X2}{4:X2}{5:X2}", numBytes, addr, clr.R, clr.G, clr.B, chksum);
                        outputFile.WriteLine(rowstring);
                        addr++;
                    }
                    pbExport.Value = row;
                }
                outputFile.WriteLine(":00000001FF");
            }
            pbExport.Visible = false;
        }

        /// <summary>
        /// ExportBitmapCOE will write the pixel information of the given Bitmap object in a text file
        /// according to the XILINX COE (block memory initialization file) format.
        /// </summary>
        /// <param name="bmp">Bitmap object to export</param>
        /// <param name="outFileName">Filename of the object to generate</param>
        private void ExportBitmapCOE(Bitmap bmp, string outFileName, int xoffs, int yoffs, int width, int height)
        {
            pbExport.Minimum = 0;
            pbExport.Maximum = height;
            pbExport.Value = 0;
            pbExport.Visible = true;
            using (StreamWriter outputFile = new StreamWriter(outFileName))
            {
                outputFile.WriteLine("memory_initialization_radix=16");
                outputFile.WriteLine("memory_initialization_vector=");

                byte numBitsR = (byte)tbResolutionRed.Value;
                byte numBitsG = (byte)tbResolutionGreen.Value;
                byte numBitsB = (byte)tbResolutionBlue.Value;

                for (int row = 0; row < height; row++)
                { 
                    for (int col = 0; col < width; col++)
                    {
                        Color clr = bmp.GetPixel(xoffs+col, yoffs+row);
                        ulong clrword = CreateTargetWord(clr.R, clr.G, clr.B, numBitsR, numBitsG, numBitsB);
                        string rowstring = string.Format("{0:x}", clrword);
                        if ((row != bmp.Height - 1) || (col != bmp.Width - 1))
                            rowstring += ",";
                        outputFile.WriteLine(rowstring);
                    }
                    pbExport.Value = row;
                }
            }
            pbExport.Visible = false;
        }

        /// <summary>
        /// CreateTargetWord shall scale the pixel to the target format, apply any kind of gamma and pack the RGB
        /// information into a word.
        /// </summary>
        /// <param name="r">Red Pixel Information</param>
        /// <param name="g">Green Pixel Information</param>
        /// <param name="b">Blue Pixel Information</param>
        /// <returns></returns>
        private ulong CreateTargetWord(byte r, byte g, byte b, byte bitsR, byte bitsG, byte bitsB)
        {
            ulong targetWord = 0;

            targetWord = (ulong)r | ((ulong)g << bitsR) | ((ulong)b << (bitsR + bitsG));

            return targetWord;
        }

        /// <summary>
        /// Applies gamma correction to the color channel. The original as well as the new bit depth must be provided
        /// </summary>
        /// <param name="ch">The value of the color channel</param>
        /// <param name="fGamma">Gamma correction value</param>
        /// <param name="depth_org">Bit depth associated with the ch value</param>
        /// <param name="depth_new">Bit depth to which ch shall be converted to</param>
        /// <returns></returns>
        private byte gammaCorrect(byte ch, float fGamma, int depth_org, int depth_new)
        {
            return (byte)(long)(((float)(1 << depth_new) - 1) * Math.Pow((float)ch / ((1 << depth_org) - 1),fGamma));
        }

        private Image ResizeImage(Image orgImage, int Width, int Height)
        {
            float ratioX = (float)Width / (float)orgImgWidth;
            float ratioY = (float)Height / (float)orgImgHeight;
            float ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(orgImgWidth * ratio);
            int newHeight = (int)(orgImgHeight * ratio);

            Bitmap newImg = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);

            using (Graphics graphics = Graphics.FromImage(newImg))
            {
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = interpolationmode;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.DrawImage(orgImage, 0, 0, newWidth, newHeight);
            }

            for (int row = 0; row < newHeight; row++)
            {
                for (int col = 0; col < newWidth; col++)
                {
                    Color clr = newImg.GetPixel(col, row);
                    newImg.SetPixel(col, row, Color.FromArgb(0, gammaCorrect(clr.R, gamma, 8, 8), gammaCorrect(clr.G, gamma, 8, 8), gammaCorrect(clr.B, gamma, 8, 8)));
                }
            }

            return newImg;
        }


        private void UpdateImage()
        {
            imgPreview.Image = new Bitmap(ResizeImage(orgImage, (int)tbWIdth.Value, (int)tbHeight.Value));
        }

        private void cbResizeQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbResizeQuality.Text)
            {
                case "High":
                    interpolationmode = System.Drawing.Drawing2D.InterpolationMode.High;
                    break;
                case "Low":
                    interpolationmode = System.Drawing.Drawing2D.InterpolationMode.Low;
                    break;
                case "Bilinear":
                    interpolationmode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
                    break;
                case "Bicubic":
                    interpolationmode = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
                    break;
                case "NearestNeighbor":
                    interpolationmode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                    break;
                case "HighQualityBilinear":
                    interpolationmode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                    break;
                case "HighQualityBicubic":
                    interpolationmode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    break;
                default:
                    throw new NotImplementedException();
            }
            if (orgImgWidth != 0)
                UpdateImage();
        }

        private void tbGamma_ValueChanged(object sender, EventArgs e)
        {
            if (orgImgWidth != 0)
            {
                gamma = (float)tbGamma.Value;
                UpdateImage();
            }
        }

        private void cbTiled_CheckedChanged(object sender, EventArgs e)
        {
            tbTileWidth.Enabled = cbTiled.Checked;
            tbTileHeight.Enabled = cbTiled.Checked;
        }


        private void tbWIdth_ValueChanged(object sender, EventArgs e)
        {
            if (!cbAspectRatio.Checked)
            {
                UpdateImage();
            } else
            if (!bAvoidUpdateWidth && (orgImgWidth != 0) && (orgImgHeight != 0))
            {
                bAvoidUpdateWidth = true;
                tbHeight.Value = tbWIdth.Value * orgImgHeight / orgImgWidth;
                bAvoidUpdateWidth = false;
                UpdateImage();
            }

        }

        private void tbHeight_ValueChanged(object sender, EventArgs e)
        {
            if (!cbAspectRatio.Checked)
            {
                UpdateImage();
            } else
            if (!bAvoidUpdateHeight && (orgImgWidth != 0) && (orgImgHeight != 0))
            {
                bAvoidUpdateHeight = true;
                tbWIdth.Value = tbHeight.Value * orgImgWidth / orgImgHeight;
                bAvoidUpdateHeight = false;
                UpdateImage();
            }
        }
    }
}
