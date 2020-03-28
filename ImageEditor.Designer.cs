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
            ((System.ComponentModel.ISupportInitialize)(this.gaussianBlurRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medianBlurRadius)).BeginInit();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
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
            this.negative.Location = new System.Drawing.Point(9, 220);
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(223, 23);
            this.negative.TabIndex = 3;
            this.negative.Text = "Негатив";
            this.negative.UseVisualStyleBackColor = true;
            this.negative.Click += new System.EventHandler(this.negative_Click);
            // 
            // gaussianBlur
            // 
            this.gaussianBlur.Location = new System.Drawing.Point(105, 249);
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
            this.gaussianBlurRadius.Location = new System.Drawing.Point(9, 249);
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
            this.medianBlurButton.Location = new System.Drawing.Point(105, 276);
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
            this.medianBlurRadius.Location = new System.Drawing.Point(9, 276);
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
            this.FlipHorizontal.Location = new System.Drawing.Point(88, 71);
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
            this.rotateRight.Location = new System.Drawing.Point(164, 139);
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
            this.rotateLeft.Location = new System.Drawing.Point(9, 139);
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
            this.FlipVerical.Location = new System.Drawing.Point(88, 139);
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
            // ImageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 624);
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
    }
}

