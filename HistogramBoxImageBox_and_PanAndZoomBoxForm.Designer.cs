
namespace HistogramBoxImageBox_and_PanAndZoomBox
{
    partial class HistogramBoxImageBox_and_PanAndZoomBoxForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.panAndZoomPictureBox1 = new Emgu.CV.UI.PanAndZoomPictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(88, 77);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(487, 314);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // panAndZoomPictureBox1
            // 
            this.panAndZoomPictureBox1.Location = new System.Drawing.Point(666, 77);
            this.panAndZoomPictureBox1.Name = "panAndZoomPictureBox1";
            this.panAndZoomPictureBox1.Size = new System.Drawing.Size(487, 314);
            this.panAndZoomPictureBox1.TabIndex = 3;
            this.panAndZoomPictureBox1.TabStop = false;
            this.panAndZoomPictureBox1.Click += new System.EventHandler(this.panAndZoomPictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Grayscale Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // histogramBox1
            // 
            this.histogramBox1.Location = new System.Drawing.Point(77, 411);
            this.histogramBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(498, 296);
            this.histogramBox1.TabIndex = 5;
            this.histogramBox1.Load += new System.EventHandler(this.histogramBox1_Load);
            // 
            // histogramBox2
            // 
            this.histogramBox2.Location = new System.Drawing.Point(666, 411);
            this.histogramBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.histogramBox2.Name = "histogramBox2";
            this.histogramBox2.Size = new System.Drawing.Size(487, 283);
            this.histogramBox2.TabIndex = 6;
            this.histogramBox2.Load += new System.EventHandler(this.histogramBox2_Load);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(540, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Color Histogram";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(729, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 34);
            this.button4.TabIndex = 8;
            this.button4.Text = "GrayScale Histogram";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // HistogramBoxImageBox_and_PanAndZoomBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 720);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.histogramBox2);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panAndZoomPictureBox1);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.button1);
            this.Name = "HistogramBoxImageBox_and_PanAndZoomBoxForm";
            this.Text = "HistogramBoxImageBox_and_PanAndZoomBoxForm";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.PanAndZoomPictureBox panAndZoomPictureBox1;
        private System.Windows.Forms.Button button2;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private Emgu.CV.UI.HistogramBox histogramBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

