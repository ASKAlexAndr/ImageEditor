using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
            this.CalcImageHistogram();
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
                CalcImageHistogram();
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

        private void RenderHistogram(Mat hist, String label, Color color)
        {
            Series series = this.histChart.Series.Add(label);
            series.ChartType = SeriesChartType.Spline;
            series.BorderWidth = 1;
            series.Color = color;
            for (int Row = 0; Row < hist.Rows; Row++)
            {
                series.Points.AddXY(Row, hist.At<float>(Row));          
            }
        }

        private bool IsGrayScale()
        {
            Bitmap img = new Bitmap(this.imageBox.Image);
            Mat imageMat = BitmapConverter.ToMat(img);
            Mat[] mv;
            Cv2.Split(imageMat, out mv);
            for (int i = 0; i < mv.Length; i++)
            {
                for (int k = 0; k < mv[0].Rows; k++)
                {
                    if (mv[0].At<float>(k) != mv[1].At<float>(k) || mv[1].At<float>(k) != mv[2].At<float>(k)) return false;
                }
            }
            return true;
        }
        private void CalcImageHistogram()
        {
            int histSize = 256;
            int[] dimensions = { histSize };
            Rangef[] ranges = { new Rangef(0, histSize) };
            Mat[] mv;
            Bitmap img = new Bitmap(this.imageBox.Image);
            Mat imageMat = BitmapConverter.ToMat(img);

            Cv2.Split(imageMat, out mv);
            if (IsGrayScale())
            {
                Mat Hist = new Mat();
                Cv2.CalcHist(new Mat[] { mv[2] }, new int[] { 0 }, null, Hist, 1, dimensions, ranges);
                Cv2.Normalize(Hist, Hist, 0, 256, NormTypes.MinMax);
                this.histChart.Series.Clear();
                this.histChart.ChartAreas[0].AxisX.Minimum = 0;
                this.histChart.ChartAreas[0].AxisY.Minimum = 0;
                this.histChart.Legends[0].Enabled = false;
                RenderHistogram(Hist, "Яркость", Color.Black);
            } else
            {
                Mat GrayScaleImage = new Mat();
                Cv2.CvtColor(imageMat, GrayScaleImage, ColorConversionCodes.BGR2GRAY);
                Mat HistR = new Mat();
                Mat HistG = new Mat();
                Mat HistB = new Mat();
                Mat HistGray = new Mat();

                Cv2.CalcHist(new Mat[] { mv[2] }, new int[] { 0 }, null, HistR, 1, dimensions, ranges);
                Cv2.CalcHist(new Mat[] { mv[1] }, new int[] { 0 }, null, HistG, 1, dimensions, ranges);
                Cv2.CalcHist(new Mat[] { mv[0] }, new int[] { 0 }, null, HistB, 1, dimensions, ranges);

                Mat[] gs_mv;
                Cv2.Split(GrayScaleImage, out gs_mv);
                Cv2.CalcHist(new Mat[] { gs_mv[0] }, new int[] { 0 }, null, HistGray, 1, dimensions, ranges);

                Cv2.Normalize(HistR, HistR, 0, 256, NormTypes.MinMax);
                Cv2.Normalize(HistG, HistG, 0, 256, NormTypes.MinMax);
                Cv2.Normalize(HistB, HistB, 0, 256, NormTypes.MinMax);
                Cv2.Normalize(HistB, HistGray, 0, 256, NormTypes.MinMax);

                this.histChart.Series.Clear();
                this.histChart.ChartAreas[0].AxisX.Minimum = 0;
                this.histChart.ChartAreas[0].AxisY.Minimum = 0;
                this.histChart.Legends[0].Enabled = true;
                RenderHistogram(HistR, "Красный", Color.Red);
                RenderHistogram(HistB, "Синий", Color.Blue);
                RenderHistogram(HistG, "Зеленый", Color.Green);
                RenderHistogram(HistGray, "Яркость", Color.Black);
            }
        }
        private void CalcHistButton_Click(object sender, EventArgs e)
        {
            CalcImageHistogram();            
        }

        private void GrayButton_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(this.imageBox.Image);
            Mat imageMat = BitmapConverter.ToMat(copy);
            Cv2.CvtColor(imageMat, imageMat, ColorConversionCodes.BGR2GRAY);
            this.imageBox.Image = BitmapConverter.ToBitmap(imageMat);
        }
    }
}
