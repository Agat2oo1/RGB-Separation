using ColorModels.Model.Lab.LabSettings;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ColorModels
{
    public partial class MainWindow : Form
    {
        Bitmap bitmap1;
        Bitmap bitmap2;
        Bitmap bitmap3;
        Bitmap bitmapHSV;
        //Image image;
        public MainWindow()
        {
            InitializeComponent();
            modelList.SelectedIndex = 0;
            colorProfile.SelectedIndex = 0;
            iluminant.SelectedIndex = 5;
            SetModel.Enabled = false;
            bitmapHSV = new Bitmap(289, 375);
            pictureBox.Image = bitmapHSV;
            showHSV();
        }
        public void SeparateChannels()
        {
            using(var snoop1 = new BmpPixelSnoop(bitmap1))
            using(var snoop2 = new BmpPixelSnoop(bitmap2))
            using(var snoop3 = new BmpPixelSnoop(bitmap3))
            {
                switch(modelList.SelectedIndex)
                {
                    case 0:
                        YCbCr(snoop1, snoop2, snoop3);
                        break;
                    case 1:
                        HSV(snoop1, snoop2, snoop3);
                        break;
                    case 2:
                        Lab(snoop1, snoop2, snoop3);
                        break;
                    default:
                        break;
                }
            }
        }
        private void YCbCr(BmpPixelSnoop snoopY, BmpPixelSnoop snoopCb, BmpPixelSnoop snoopCr)
        {
            for (int Xcount = 0; Xcount < bitmap1.Width; Xcount++)
            {
                for (int Ycount = 0; Ycount < bitmap1.Height; Ycount++)
                {
                    Color c = snoopY.GetPixel(Xcount, Ycount);
                    double cR = c.R / 255.0;
                    double cG = c.G / 255.0;
                    double cB = c.B / 255.0;
                    double Y = 0.299 * cR + 0.587 * cG + 0.114 * cB;
                    double Cb = (cB - Y) / 1.772 + 0.5;
                    double Cr = (cR - Y) / 1.402 + 0.5;
                    Y *= 255.0;
                    Cb *= 255.0;
                    Cr *= 255.0;
                    snoopY.SetPixel(Xcount, Ycount, Color.FromArgb((int)Y, (int)Y, (int)Y));
                    if (ToGreyscale.Checked)
                    {
                        snoopCb.SetPixel(Xcount, Ycount, Color.FromArgb((int)Cb, (int)Cb, (int)Cb));
                        snoopCr.SetPixel(Xcount, Ycount, Color.FromArgb((int)Cr, (int)Cr, (int)Cr));
                    }
                    else
                    {
                        snoopCb.SetPixel(Xcount, Ycount, Color.FromArgb(127, 255 - (int)Cb, (int)Cb));
                        snoopCr.SetPixel(Xcount, Ycount, Color.FromArgb((int)Cr, 255 - (int)Cr, 127));
                    }
                }
            }
        }
        private void HSV(BmpPixelSnoop snoopH, BmpPixelSnoop snoopS, BmpPixelSnoop snoopV)
        {
            double H = 0, S, V;
            for (int Xcount = 0; Xcount < bitmap1.Width; Xcount++)
            {
                for (int Ycount = 0; Ycount < bitmap1.Height; Ycount++)
                {
                    Color c = snoopH.GetPixel(Xcount, Ycount);
                    double cR = c.R / 255.0;
                    double cG = c.G / 255.0;
                    double cB = c.B / 255.0;
                    double min = Math.Min(cR, Math.Min(cG, cB));    //Min. value of RGB
                    double max = Math.Max(cR, Math.Max(cG, cB));   //Max. value of RGB
                    double del = max - min;           //Delta RGB value

                    V = max;
                    
                    if (del == 0)
                    {
                        S = 0;
                        H = 0;
                    }
                    else
                    {
                        S = del / max;
                        if (max == cR) H = (60 * ((cG - cB) / del) + 360) % 360;
                        if (max == cG) H = (60 * ((cB - cR) / del) + 120) % 360;
                        if (max == cB) H = (60 * ((cR - cG) / del) + 240) % 360;
                    }

                    H *= (255.0 / 360);
                    S *= 255;
                    V *= 255;
                    snoopH.SetPixel(Xcount, Ycount, Color.FromArgb((int)H, (int)H, (int)H));
                    snoopS.SetPixel(Xcount, Ycount, Color.FromArgb((int)S, (int)S, (int)S));
                    snoopV.SetPixel(Xcount, Ycount, Color.FromArgb((int)V, (int)V, (int)V));
                }
            }
        }
        private void Lab(BmpPixelSnoop snoopL, BmpPixelSnoop snoopA, BmpPixelSnoop snoopB)
        {
            double L, a, b, X, Y, Z;
            double g = (double)gamma.Value;
            double xw = (double)x_w.Value;
            double yw = (double)y_w.Value;
            double xr = (double)x_r.Value;
            double yr = (double)y_r.Value;
            double xg = (double)x_g.Value;
            double yg = (double)y_g.Value;
            double xb = (double)x_b.Value;
            double yb = (double)y_b.Value;
            double zr = 1 - xr - yr;
            double zg = 1 - xg - yg;
            double zb = 1 - xb - yb;
           
            double XW = xw/yw;
            double YW = 1.000;
            double ZW = (1-xw-yw)/yw;

            double[][] matrix = new double[3][];
            matrix[0] = new double[3] { xr, xg, xb };
            matrix[1] = new double[3] { yr, yg, yb };
            matrix[2] = new double[3] { zr, zg, zb };

            double[][] WR = new double[3][];
            WR[0] = new double[1] { XW };
            WR[1] = new double[1] { YW };
            WR[2] = new double[1] { ZW };

            double[][] SRGB = Matrix.MatrixProduct(Matrix.MatrixInverse(matrix), WR);
            double[][] M = Matrix.MatrixMix(matrix, SRGB);

            double[][] RGB = new double[3][];
            RGB[0] = new double[1];
            RGB[1] = new double[1];
            RGB[2] = new double[1];

            for (int Xcount = 0; Xcount < bitmap1.Width; Xcount++)
            {
                for (int Ycount = 0; Ycount < bitmap1.Height; Ycount++)
                {
                    Color c = snoopL.GetPixel(Xcount, Ycount);
                    double cR = c.R / 255.0;
                    double cG = c.G / 255.0;
                    double cB = c.B / 255.0;

                    double pow = g;
                    RGB[0][0] = Math.Pow(cR,pow);
                    RGB[1][0] = Math.Pow(cG,pow);
                    RGB[2][0] = Math.Pow(cB,pow);

                    double[][] XYZ = Matrix.MatrixProduct(M, RGB);
                    X = XYZ[0][0]; Y =XYZ[1][0]; Z =XYZ[2][0];

                    double YbyYW = Y / YW;
                    pow = 1.0 / 3;
                    if (YbyYW > 0.008856) L = 116 * Math.Pow(YbyYW, pow) - 16;
                    else L = 903.3 * YbyYW; 
                    a = 500 * (Math.Pow(X / XW, pow) - Math.Pow(Y / YW, pow));
                    b = 200 * (Math.Pow(Y / YW, pow) - Math.Pow(Z / ZW,pow));

                    L = Math.Max(0, Math.Min(L * 2.55, 255));
                    a = Math.Max(0, Math.Min(a + 128, 255));
                    b = Math.Max(0, Math.Min(b + 128, 255));

                    snoopL.SetPixel(Xcount, Ycount, Color.FromArgb((int)L, (int)L, (int)L));
                    if (ToGreyscale.Checked)
                    {
                        snoopA.SetPixel(Xcount, Ycount, Color.FromArgb((int)a, (int)a, (int)a));
                        snoopB.SetPixel(Xcount, Ycount, Color.FromArgb((int)b, (int)b, (int)b));
                    }
                    else
                    {
                        snoopA.SetPixel(Xcount, Ycount, Color.FromArgb((int)a, (int)(255 - a), 127));
                        snoopB.SetPixel(Xcount, Ycount, Color.FromArgb((int)b, 127, (int)(255 - b)));
                    }
                }
            }
        }
        private void showHSV()
        {
            using (var snoop = new BmpPixelSnoop(bitmapHSV))
            {
                double R = 0, G = 0, B = 0;
                int H = 0;
                double S = 0.0;
                double V = trackBar1.Value / 100.0;
                int x = 4;
                double add = 1.0 / 16.0;
                for (int y = 5; y < 365; y++, x = 4, H++, S = 0.0) //360 wartoœci H
                {
                    for (int i = 0; i < 16; i++, x += 3, S += add)
                    {
                        for (int j = 0; j < 15; j++, x++)
                        {
                            double M = 255 * V;
                            double m = M * (1 - S);
                            double Z = (M - m) * (1 - Math.Abs((H / 60.0) % 2 - 1));
                            switch (H)
                            {
                                case < 60:
                                    R = M;
                                    G = Z + m;
                                    B = m;
                                    break;
                                case < 120:
                                    R = Z + m;
                                    G = M;
                                    B = m;
                                    break;
                                case < 180:
                                    R = m;
                                    G = M;
                                    B = Z + m;
                                    break;
                                case < 240:
                                    R = m;
                                    G = Z + m;
                                    B = M;
                                    break;
                                case < 300:
                                    R = Z + m;
                                    G = m;
                                    B = M;
                                    break;
                                case < 360:
                                    R = M;
                                    G = m;
                                    B = Z + m;
                                    break;
                            }
                            snoop.SetPixel(x, y, Color.FromArgb((int)R, (int)G, (int)B));
                        }
                    }
                }
            }
        }
        private void LoadImage_Click(object sender, EventArgs e)
        {
            string CombinedPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\..\\");
            openFileDialog.InitialDirectory = Path.GetFullPath(CombinedPath);
           
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog.FileName;
                    pictureBox.Image = Image.FromFile(filePath);
                    FirstChannel.Image = null;
                    SecondChannel.Image = null;
                    ThirdChannel.Image = null;
                    //Separate.Enabled = true;
                    //ToGreyscale.Enabled = true;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
        private void Separate_Click(object sender, EventArgs e)
        {
            bitmap1 = new Bitmap(pictureBox.Image);
            bitmap2 = new Bitmap(bitmap1);
            bitmap3 = new Bitmap(bitmap1);
            FirstChannel.Image = bitmap1;
            SecondChannel.Image = bitmap2;
            ThirdChannel.Image = bitmap3;
            SeparateChannels();
        }
        private void SetModel_Click(object sender, EventArgs e)
        {
            SetModel.Enabled = false;
            if(bitmap1!=null)Separate_Click(sender, e);
        }

        private void modelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabSettings.Enabled = false;
            switch (modelList.SelectedIndex)
            {
                case 0:
                    Set(@"..\\..\\..\\Model\\YCbCr\\YCbCrSet.txt");
                    break;
                case 1:
                    Set(@"..\\..\\..\\Model\\HSV\\HSVSet.txt");
                    break;
                case 2:
                    Set(@"..\\..\\..\\Model\\Lab\\LabSet.txt");
                    LabSettings.Enabled = true;
                    break;
                default:
                    break;
            }
            FirstChannel.Image = null;
            SecondChannel.Image = null;
            ThirdChannel.Image = null;
        }
        private void colorProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ("Custom Range" == colorProfile.SelectedItem.ToString()) return;
            string filePath = @"..\\..\\..\\Model\\Lab\\LabSettings\\" + colorProfile.SelectedItem.ToString() + ".txt";
            SetSettings(filePath);
            SetModel.Enabled = true;
        }

        private void iluminant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ("Custom White Point" == iluminant.SelectedItem.ToString()) return;
            SetWhitePoint(iluminant.SelectedIndex);
            SetModel.Enabled = true;
        }
        private void SetProfileChanged(object sender, EventArgs e)
        {
            colorProfile.SelectedIndex = colorProfile.Items.Count - 1;
            SetModel.Enabled = true;
        }
        private void SetWPointChanged(object sender, EventArgs e)
        {
            iluminant.SelectedIndex = iluminant.Items.Count - 1;
            SetModel.Enabled = true;
        }
        private void gamma_Click(object sender, EventArgs e)
        {
            SetModel.Enabled = true;
        }
        private void Set(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            label1.Text = lines[0];
            label2.Text = lines[1];
            label3.Text = lines[2];
        }
        private void SetSettings(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            int pointIndex;
            decimal output;
            int.TryParse(lines[0], out pointIndex);
            decimal.TryParse(lines[1], NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out output);
            x_r.Value = output;
            decimal.TryParse(lines[2], NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out output);
            y_r.Value = output;
            decimal.TryParse(lines[3], NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out output);
            x_g.Value = output;
            decimal.TryParse(lines[4], NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out output);
            y_g.Value = output;
            decimal.TryParse(lines[5], NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out output);
            x_b.Value = output;
            decimal.TryParse(lines[6], NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out output);
            y_b.Value = output;
            decimal.TryParse(lines[7], NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out output);
            gamma.Value = output;

            SetWhitePoint(pointIndex);
            iluminant.SelectedIndex = pointIndex;
        }
        private void SetWhitePoint(int index)
        {
            x_w.Value = WhitePoints.Table[index, 0];
            y_w.Value = WhitePoints.Table[index, 1];
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            showHSV();
            pictureBox.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox.Image = bitmapHSV;
            showHSV();
            FirstChannel.Image = null;
            SecondChannel.Image = null;
            ThirdChannel.Image = null;
        }

        private void ToGreyscale_CheckedChanged(object sender, EventArgs e)
        {
            if (FirstChannel.Image == null) return;
            Separate_Click(sender, e);
        }
    }
}