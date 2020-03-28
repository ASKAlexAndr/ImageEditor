using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace ImageEditor
{
    public partial class ImageEditor : Form
    {
        public ImageEditor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadSizeBoxes();
        }
        
        private void LoadSizeBoxes()
        {
            int height = this.imageBox.Height;
            int width = this.imageBox.Width;
            this.UpdateSizeBoxes(width, height);
        }
        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image File (*.bmp,*.jpg)|*.bmp;*.jpg";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.imageBox.Image = new Bitmap(ofile.FileName);
                this.LoadSizeBoxes();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog safd = new SaveFileDialog();
            safd.Filter = "Image File (*.bmp,*.jpg)|*.bmp;*.jpg";
            if (safd.ShowDialog() == DialogResult.OK)
            {
                this.imageBox.Image.Save(safd.FileName, ImageFormat.Jpeg);
            }
        }

        private void negative_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(this.imageBox.Image);
            this.imageBox.Image = negativeConvert(copy);

            imageBox.BringToFront();
            imageBox.Visible = true;
        }

        public Bitmap negativeConvert(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
                for (int j = 0; j < b.Height; j++)
                {

                    Color c1 = b.GetPixel(i, j);


                    int a = c1.A;
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;

                    r1 = 255 - r1;
                    g1 = 255 - g1;
                    b1 = 255 - b1;


                    b.SetPixel(i, j, Color.FromArgb(a, r1, g1, b1));

                }
            return b;
        }

        private void Blur_Click(object sender, EventArgs e)
        {
            Int32 radius = Decimal.ToInt32(this.gaussianBlurRadius.Value);
            OpenCvSharp.Size size = new OpenCvSharp.Size(radius, radius);
            Bitmap copy = new Bitmap(this.imageBox.Image);
            Mat imageMat = BitmapConverter.ToMat(copy);
            Cv2.GaussianBlur(imageMat, imageMat, size, 0);
            this.imageBox.Image = BitmapConverter.ToBitmap(imageMat);
        }

        public Bitmap blurConvert(Bitmap b)
        {
            Int32 radius = System.Convert.ToInt32(this.gaussianBlurRadius.Value);
            for (int i = 0; i < b.Width; i++)
                for (int j = 0; j < b.Height; j++)
                {
                    Int32 avgR = 0, avgG = 0, avgB = 0;
                    Int32 blurPixelCount = 0;

                    for (Int32 x = i; (x < i + radius && x < b.Width); x++)
                    {
                        for (Int32 y = j; (y < j + radius && y < b.Height); y++)
                        {
                            Color pixel = b.GetPixel(x, y);
                            avgR += pixel.R;
                            avgG += pixel.G;
                            avgB += pixel.B;

                            blurPixelCount++;
                        }
                    }
                    avgR = avgR / blurPixelCount;
                    avgG = avgG / blurPixelCount;
                    avgB = avgB / blurPixelCount;
                    for (Int32 x = i; x < i + radius && x < b.Width; x++)
                    {
                        for (Int32 y = j; y < j + radius && y < b.Height; y++)
                        {
                            b.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                        }
                    }
                }

            return b;
        }

        private void GaussianBlurRadius_ValueChanged(object sender, EventArgs e)
        {
            if (this.gaussianBlurRadius.Value % 2 == 0)
            {
                MessageBox.Show("Допустимо только нечетное число");
                this.gaussianBlurRadius.Value--;
            }
        }

        private void medianBlurButton_Click(object sender, EventArgs e)
        {
            Int32 radius = System.Convert.ToInt32(this.medianBlurRadius.Value);
            Bitmap copy = new Bitmap(this.imageBox.Image);
            Mat imageMat = BitmapConverter.ToMat(copy);
            Cv2.MedianBlur(imageMat, imageMat, radius);
            this.imageBox.Image = BitmapConverter.ToBitmap(imageMat);
        }

        private void medianBlurRadius_ValueChanged(object sender, EventArgs e)
        {
            if (this.medianBlurRadius.Value % 2 == 0)
            {
                MessageBox.Show("Допустимо только нечетное число");
                this.medianBlurRadius.Value--;
            }
        }

        private void rotateLeft_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(this.imageBox.Image);
            Mat imageMat = BitmapConverter.ToMat(copy);
            Cv2.Rotate(imageMat, imageMat, RotateFlags.Rotate90Counterclockwise);
            this.imageBox.Image = BitmapConverter.ToBitmap(imageMat);
            this.LoadSizeBoxes();
        }

        private void rotateRight_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(this.imageBox.Image);
            Mat imageMat = BitmapConverter.ToMat(copy);
            Cv2.Rotate(imageMat, imageMat, RotateFlags.Rotate90Clockwise);
            this.imageBox.Image = BitmapConverter.ToBitmap(imageMat);
            this.LoadSizeBoxes();
        }

        private void FlipHorizontal_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(this.imageBox.Image);
            Mat imageMat = BitmapConverter.ToMat(copy);
            Cv2.Flip(imageMat, imageMat, FlipMode.Y);
            this.imageBox.Image = BitmapConverter.ToBitmap(imageMat);
        }

        private void FlipVerical_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(this.imageBox.Image);
            Mat imageMat = BitmapConverter.ToMat(copy);
            Cv2.Flip(imageMat, imageMat, FlipMode.X);
            this.imageBox.Image = BitmapConverter.ToBitmap(imageMat);
        }

        private void UpdateImageSize(int width, int height)
        {
            Bitmap copy = new Bitmap(this.imageBox.Image);
            Mat imageMat = BitmapConverter.ToMat(copy);
            Cv2.Resize(imageMat, imageMat, new OpenCvSharp.Size(width, height));
            this.imageBox.Image = BitmapConverter.ToBitmap(imageMat);
        }
        private void UpdateSizeBoxes(int width, int height)
        {
            this.imageWidth.Value = width;
            this.imageHeight.Value = height;
        }

        private void ChangeSizeButton_Click(object sender, EventArgs e)
        {
            this.UpdateImageSize(Decimal.ToInt32(this.imageWidth.Value), Decimal.ToInt32(this.imageHeight.Value));
        }
    }
}
