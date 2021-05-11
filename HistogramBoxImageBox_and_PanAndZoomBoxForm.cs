using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace HistogramBoxImageBox_and_PanAndZoomBox
{
    public partial class HistogramBoxImageBox_and_PanAndZoomBoxForm : Form
    {
        Image<Bgr, byte> _InputImage;
        Image<Gray, byte> _GrayImage;
        public HistogramBoxImageBox_and_PanAndZoomBoxForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FileName = "c:\\Users\\ASUS\\Desktop\\Desktop_pics\\Lena_PNG.png";
            _InputImage = new Image<Bgr, byte>(FileName);

            if(_InputImage == null)
            {
                MessageBox.Show("Image is not read.");
                return;
            }

            imageBox1.Image = _InputImage;
            imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Everything;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _GrayImage = _InputImage.Convert<Gray, byte>();
            panAndZoomPictureBox1.Image = _GrayImage.Bitmap;
        }

        private void histogramBox2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(0, 255));
            hist.Calculate(new Image<Gray,byte>[] { _InputImage[0]}, false, null);

            Mat m = new Mat();
            hist.CopyTo(m);

            histogramBox1.AddHistogram("Blue channel Histogram", Color.Blue, m, 256, new float[] { 0, 256});
            histogramBox1.Refresh();
        }

        private void panAndZoomPictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(0, 255));
            hist.Calculate(new Image<Gray, byte>[] { _GrayImage }, false, null);

            Mat m = new Mat();
            hist.CopyTo(m);

            histogramBox2.AddHistogram("Grayscale Histogram", Color.Blue, m, 256, new float[] { 0, 256 });
            histogramBox2.Refresh();
        }

        private void histogramBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
