using System;
using System.Drawing;
using System.Drawing.Imaging;
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

        private void AddNoize_Click(object sender, EventArgs e)
        {
            int power = Decimal.ToInt32(this.noisePower.Value);
            Bitmap copy = new Bitmap(this.imageBox.Image);
            Mat imageMat = BitmapConverter.ToMat(copy);
            Mat mGaussianNoise = new Mat(imageMat.Size(), MatType.CV_8UC4);
            Scalar stddev = new Scalar(power, power, power);
            Cv2.Randn(mGaussianNoise, 0, stddev);
            imageMat += mGaussianNoise;
            this.imageBox.Image = BitmapConverter.ToBitmap(imageMat);
        }

        private void CalcHistButton_Click(object sender, EventArgs e)
        {
            int histSize = 128;
            int[] dimensions = { histSize };
            Rangef[] ranges = { new Rangef(0, histSize) };
            Mat[] mv;
            Bitmap img = new Bitmap(this.imageBox.Image);
            Mat imageMat = BitmapConverter.ToMat(img);

            int Width = this.HistogramBox.Width, Height = this.HistogramBox.Height;
            Mat render = new Mat(new OpenCvSharp.Size(Width, Height), MatType.CV_8U, Scalar.All(0));

            Cv2.Split(imageMat, out mv);
            Mat HistR = new Mat();
            Mat HistG = new Mat();
            Mat HistB = new Mat();
            Cv2.CalcHist(
                new Mat[] {mv[2]},
                new int[] {0},
                null,
                HistR,
                1,
                dimensions,
                ranges
                );
            Cv2.CalcHist(
              new Mat[] { mv[1] },
              new int[] { 0 },
              null,
              HistG,
              1,
              dimensions,
              ranges
              );
            Cv2.CalcHist(
              new Mat[] { mv[0] },
              new int[] { 0 },
              null,
              HistB,
              1,
              dimensions,
              ranges
              );
            Cv2.Normalize(HistR, HistR, 0, 255, NormTypes.MinMax);
            Cv2.Normalize(HistG, HistG, 0, 255, NormTypes.MinMax);
            Cv2.Normalize(HistB, HistB, 0, 255, NormTypes.MinMax);
            int x1, y1;
            int x2, y2;
            int ratio = (int)Math.Round((double)Width / histSize);
            Cv2.CvtColor(render, render, ColorConversionCodes.GRAY2RGB);
            Scalar color = new Scalar(255,0,0);
            for (int i = 1; i < histSize; i++)
            {
                x1 = ratio * (i - 1);
                x2 = ratio * (i);
                // Red
                y1 = Height - (int)Math.Round(HistR.At<float>(i - 1));
                y2 = Height - (int)Math.Round(HistR.At<float>(i));
                color = new Scalar(0, 0, 255);
                Cv2.Line(render, new OpenCvSharp.Point(x1, y1), new OpenCvSharp.Point(x2, y2), color, 1);
                // Blue
                y1 = Height - (int)Math.Round(HistB.At<float>(i - 1));
                y2 = Height - (int)Math.Round(HistB.At<float>(i));
                color = new Scalar(255, 0, 0);
                Cv2.Line(render, new OpenCvSharp.Point(x1, y1), new OpenCvSharp.Point(x2, y2), color, 1);
                // Green
                y1 = Height - (int)Math.Round(HistG.At<float>(i - 1));
                y2 = Height - (int)Math.Round(HistG.At<float>(i));
                color = new Scalar(0, 255, 0);
                Cv2.Line(render, new OpenCvSharp.Point(x1, y1), new OpenCvSharp.Point(x2, y2), color, 1);
            }
            this.HistogramBox.Image = BitmapConverter.ToBitmap(render);
        }
    }
}
