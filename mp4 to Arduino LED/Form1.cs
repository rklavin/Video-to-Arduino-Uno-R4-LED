using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.VideoStab;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace mp4_to_Arduino_LED
{
    public partial class Form1 : Form
    {
        private VideoCapture? videoCapture = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get Input file
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Select Source Video",
                Filter = "Video Files (*.mp4)|*.mp4|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
                videoCapture = new VideoCapture(openFileDialog.FileName);
                button4_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Get Destination file
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Choose a Destination File",
                Filter = "Header File (*.h)|*.h",
                DefaultExt = ".h",
                FileName = "animation.h"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = saveFileDialog.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (videoCapture != null)
            {
                using (Mat mat = videoCapture.QueryFrame())
                {
                    // Update source preview
                    imageBox1.Image = mat;

                    // Make and update output preview
                    Mat output = convertMatToLED(mat);
                    imageBox2.Image = output;
                    output.Dispose();
                }
            }
        }

        private Mat convertMatToLED(Mat mat)
        {
            int width = mat.Size.Width;
            int height = mat.Size.Height;

            int pixelWidth = width / 12;
            int pixelHeight = height / 8;

            Mat output = new Mat(8, 12, Emgu.CV.CvEnum.DepthType.Default, 3);
            CvInvoke.Resize(mat, output, new Size(12, 8), 1, 1, Inter.NearestExact);
            CvInvoke.Threshold(output, output, 127, 255, ThresholdType.Binary);

            return output;
        }
    }
}