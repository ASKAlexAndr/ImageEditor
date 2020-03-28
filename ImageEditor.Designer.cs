namespace ImageEditor
{
    partial class ImageEditor
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
            this.OpenButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.negative = new System.Windows.Forms.Button();
            this.gaussianBlur = new System.Windows.Forms.Button();
            this.gaussianBlurRadius = new System.Windows.Forms.NumericUpDown();
            this.medianBlurButton = new System.Windows.Forms.Button();
            this.medianBlurRadius = new System.Windows.Forms.NumericUpDown();
            this.FlipHorizontal = new System.Windows.Forms.Button();
            this.rotateRight = new System.Windows.Forms.Button();
            this.rotateLeft = new System.Windows.Forms.Button();
            this.FlipVerical = new System.Windows.Forms.Button();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeSizeButton = new System.Windows.Forms.Button();
            this.imageWidth = new System.Windows.Forms.NumericUpDown();
            this.imageHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddNoize = new System.Windows.Forms.Button();
            this.noisePower = new System.Windows.Forms.NumericUpDown();
            this.HistogramBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianBlurRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medianBlurRadius)).BeginInit();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noisePower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(12, 12);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(101, 42);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "Открыть";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(129, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(103, 42);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // negative
            // 
            this.negative.Location = new System.Drawing.Point(9, 308);
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(223, 23);
            this.negative.TabIndex = 3;
            this.negative.Text = "Негатив";
            this.negative.UseVisualStyleBackColor = true;
            this.negative.Click += new System.EventHandler(this.negative_Click);
            // 
            // gaussianBlur
            // 
            this.gaussianBlur.Location = new System.Drawing.Point(105, 337);
            this.gaussianBlur.Name = "gaussianBlur";
            this.gaussianBlur.Size = new System.Drawing.Size(127, 20);
            this.gaussianBlur.TabIndex = 4;
            this.gaussianBlur.Text = "Размытие по Гауссу";
            this.gaussianBlur.UseVisualStyleBackColor = true;
            this.gaussianBlur.Click += new System.EventHandler(this.Blur_Click);
            // 
            // gaussianBlurRadius
            // 
            this.gaussianBlurRadius.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.gaussianBlurRadius.Location = new System.Drawing.Point(9, 337);
            this.gaussianBlurRadius.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.gaussianBlurRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gaussianBlurRadius.Name = "gaussianBlurRadius";
            this.gaussianBlurRadius.Size = new System.Drawing.Size(90, 20);
            this.gaussianBlurRadius.TabIndex = 5;
            this.gaussianBlurRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gaussianBlurRadius.ValueChanged += new System.EventHandler(this.GaussianBlurRadius_ValueChanged);
            // 
            // medianBlurButton
            // 
            this.medianBlurButton.Location = new System.Drawing.Point(105, 364);
            this.medianBlurButton.Name = "medianBlurButton";
            this.medianBlurButton.Size = new System.Drawing.Size(127, 21);
            this.medianBlurButton.TabIndex = 6;
            this.medianBlurButton.Text = "Медианное размытие";
            this.medianBlurButton.UseVisualStyleBackColor = true;
            this.medianBlurButton.Click += new System.EventHandler(this.medianBlurButton_Click);
            // 
            // medianBlurRadius
            // 
            this.medianBlurRadius.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.medianBlurRadius.Location = new System.Drawing.Point(9, 364);
            this.medianBlurRadius.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.medianBlurRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.medianBlurRadius.Name = "medianBlurRadius";
            this.medianBlurRadius.Size = new System.Drawing.Size(90, 20);
            this.medianBlurRadius.TabIndex = 7;
            this.medianBlurRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.medianBlurRadius.ValueChanged += new System.EventHandler(this.medianBlurRadius_ValueChanged);
            // 
            // FlipHorizontal
            // 
            this.FlipHorizontal.BackgroundImage = global::ImageEditor.Properties.Resources.flip_horizontal;
            this.FlipHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FlipHorizontal.Location = new System.Drawing.Point(91, 172);
            this.FlipHorizontal.Name = "FlipHorizontal";
            this.FlipHorizontal.Size = new System.Drawing.Size(70, 62);
            this.FlipHorizontal.TabIndex = 10;
            this.FlipHorizontal.UseVisualStyleBackColor = true;
            this.FlipHorizontal.Click += new System.EventHandler(this.FlipHorizontal_Click);
            // 
            // rotateRight
            // 
            this.rotateRight.BackgroundImage = global::ImageEditor.Properties.Resources.Rotate_right;
            this.rotateRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rotateRight.Location = new System.Drawing.Point(167, 240);
            this.rotateRight.Name = "rotateRight";
            this.rotateRight.Size = new System.Drawing.Size(65, 62);
            this.rotateRight.TabIndex = 9;
            this.rotateRight.UseVisualStyleBackColor = true;
            this.rotateRight.Click += new System.EventHandler(this.rotateRight_Click);
            // 
            // rotateLeft
            // 
            this.rotateLeft.BackgroundImage = global::ImageEditor.Properties.Resources.Rotate_left;
            this.rotateLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rotateLeft.Location = new System.Drawing.Point(12, 240);
            this.rotateLeft.Name = "rotateLeft";
            this.rotateLeft.Size = new System.Drawing.Size(70, 62);
            this.rotateLeft.TabIndex = 8;
            this.rotateLeft.UseVisualStyleBackColor = true;
            this.rotateLeft.Click += new System.EventHandler(this.rotateLeft_Click);
            // 
            // FlipVerical
            // 
            this.FlipVerical.BackgroundImage = global::ImageEditor.Properties.Resources.flip_vertical;
            this.FlipVerical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FlipVerical.Location = new System.Drawing.Point(91, 240);
            this.FlipVerical.Name = "FlipVerical";
            this.FlipVerical.Size = new System.Drawing.Size(70, 62);
            this.FlipVerical.TabIndex = 11;
            this.FlipVerical.UseVisualStyleBackColor = true;
            this.FlipVerical.Click += new System.EventHandler(this.FlipVerical_Click);
            // 
            // imagePanel
            // 
            this.imagePanel.AutoScroll = true;
            this.imagePanel.AutoSize = true;
            this.imagePanel.Controls.Add(this.imageBox);
            this.imagePanel.Location = new System.Drawing.Point(271, 12);
            this.imagePanel.MaximumSize = new System.Drawing.Size(800, 600);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(800, 600);
            this.imagePanel.TabIndex = 12;
            // 
            // imageBox
            // 
            this.imageBox.Image = global::ImageEditor.Properties.Resources.drakon_past_ogon_plamya_voyna_srazhenie_61650_1920x1080;
            this.imageBox.Location = new System.Drawing.Point(0, 0);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(1920, 1080);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "X";
            // 
            // ChangeSizeButton
            // 
            this.ChangeSizeButton.Location = new System.Drawing.Point(157, 108);
            this.ChangeSizeButton.Name = "ChangeSizeButton";
            this.ChangeSizeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeSizeButton.TabIndex = 14;
            this.ChangeSizeButton.Text = "Применить";
            this.ChangeSizeButton.UseVisualStyleBackColor = true;
            this.ChangeSizeButton.Click += new System.EventHandler(this.ChangeSizeButton_Click);
            // 
            // imageWidth
            // 
            this.imageWidth.Location = new System.Drawing.Point(12, 82);
            this.imageWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.imageWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.imageWidth.Name = "imageWidth";
            this.imageWidth.Size = new System.Drawing.Size(87, 20);
            this.imageWidth.TabIndex = 15;
            this.imageWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // imageHeight
            // 
            this.imageHeight.Location = new System.Drawing.Point(129, 82);
            this.imageHeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.imageHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.imageHeight.Name = "imageHeight";
            this.imageHeight.Size = new System.Drawing.Size(103, 20);
            this.imageHeight.TabIndex = 16;
            this.imageHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Высота";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ширина";
            // 
            // AddNoize
            // 
            this.AddNoize.Location = new System.Drawing.Point(105, 391);
            this.AddNoize.Name = "AddNoize";
            this.AddNoize.Size = new System.Drawing.Size(127, 22);
            this.AddNoize.TabIndex = 19;
            this.AddNoize.Text = "Шум";
            this.AddNoize.UseVisualStyleBackColor = true;
            this.AddNoize.Click += new System.EventHandler(this.AddNoize_Click);
            // 
            // noisePower
            // 
            this.noisePower.Location = new System.Drawing.Point(9, 392);
            this.noisePower.Name = "noisePower";
            this.noisePower.Size = new System.Drawing.Size(90, 20);
            this.noisePower.TabIndex = 20;
            // 
            // HistogramBox
            // 
            this.HistogramBox.Location = new System.Drawing.Point(12, 435);
            this.HistogramBox.Name = "HistogramBox";
            this.HistogramBox.Size = new System.Drawing.Size(220, 161);
            this.HistogramBox.TabIndex = 21;
            this.HistogramBox.TabStop = false;
            // 
            // ImageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 624);
            this.Controls.Add(this.HistogramBox);
            this.Controls.Add(this.noisePower);
            this.Controls.Add(this.AddNoize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imageHeight);
            this.Controls.Add(this.imageWidth);
            this.Controls.Add(this.ChangeSizeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.FlipVerical);
            this.Controls.Add(this.FlipHorizontal);
            this.Controls.Add(this.rotateRight);
            this.Controls.Add(this.rotateLeft);
            this.Controls.Add(this.medianBlurRadius);
            this.Controls.Add(this.medianBlurButton);
            this.Controls.Add(this.gaussianBlurRadius);
            this.Controls.Add(this.gaussianBlur);
            this.Controls.Add(this.negative);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OpenButton);
            this.Name = "ImageEditor";
            this.Text = "Редактор изображений";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gaussianBlurRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medianBlurRadius)).EndInit();
            this.imagePanel.ResumeLayout(false);
            this.imagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noisePower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button negative;
        private System.Windows.Forms.Button gaussianBlur;
        private System.Windows.Forms.NumericUpDown gaussianBlurRadius;
        private System.Windows.Forms.Button medianBlurButton;
        private System.Windows.Forms.NumericUpDown medianBlurRadius;
        private System.Windows.Forms.Button rotateLeft;
        private System.Windows.Forms.Button rotateRight;
        private System.Windows.Forms.Button FlipHorizontal;
        private System.Windows.Forms.Button FlipVerical;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeSizeButton;
        private System.Windows.Forms.NumericUpDown imageWidth;
        private System.Windows.Forms.NumericUpDown imageHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddNoize;
        private System.Windows.Forms.NumericUpDown noisePower;
        private System.Windows.Forms.PictureBox HistogramBox;
    }
}

