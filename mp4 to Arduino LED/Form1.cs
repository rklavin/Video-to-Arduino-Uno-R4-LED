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
                updateSliderRange();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Create output file
            convertMatToArduino((int)numericUpDown1.Value, (int)numericUpDown2.Value);
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
            if (trackBar1.Value < trackBar1.Maximum)
            {
                trackBar1.Value += 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value > trackBar1.Minimum)
            {
                trackBar1.Value -= 1;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (videoCapture != null)
            {
                videoCapture.Set(CapProp.PosFrames, trackBar1.Value - 1);
                updatePreviews();
            }
        }

        private Mat convertMatToLED(Mat mat, int height, int width)
        {
            Mat output = new Mat(height, width, Emgu.CV.CvEnum.DepthType.Default, 3);
            CvInvoke.Resize(mat, output, new Size(12, 8), 1, 1, Inter.NearestExact);
            CvInvoke.Threshold(output, output, 127, 255, ThresholdType.Binary);

            return output;
        }

        private void updateSliderRange()
        {
            if (videoCapture != null)
            {
                trackBar1.SetRange(0, (int)videoCapture.Get(CapProp.FrameCount));
            }
        }

        private void updatePreviews()
        {
            if (videoCapture != null)
            {
                using (Mat mat = videoCapture.QueryFrame())
                {
                    // Update source preview
                    imageBox1.Image = mat;

                    // Make and update output preview
                    Mat output = convertMatToLED(mat, 8, 12);
                    imageBox2.Image = output;
                    output.Dispose();
                }
            }
        }

        private void convertMatToArduino(int nFrames, int dropFrame)
        {
            // No output file selected
            if (textBox2 == null) return;

            // Can't grab less than 1 frame
            if (nFrames <= 0) return;

            if (videoCapture != null)
            {
                // Create and open output file
                StreamWriter output = new StreamWriter(textBox2.Text);

                // Write first line of animation file
                output.WriteLine("const uint32_t animation[][4] = {");

                // Get frame count
                int frames = (int)videoCapture.Get(CapProp.FrameCount);
                double dropFPS = videoCapture.Get(CapProp.Fps);
                if (dropFrame > 0)
                {
                    dropFPS = dropFPS - (videoCapture.Get(CapProp.Fps) / dropFrame);
                }
                double frameTime = ((1 / dropFPS) * 1000 * nFrames) - 1;

                // Reset video to start
                videoCapture.Set(CapProp.PosFrames, 0);

                for (int i = 0; i < frames; i += nFrames)
                {
                    if (nFrames > 1)
                    {
                        // Setting the property is much slower
                        videoCapture.Set(CapProp.PosFrames, i);
                    }

                    Mat mat = videoCapture.QueryFrame();

                    // Drop frame
                    if ((dropFrame) > 0 && (i % dropFrame) == 0)
                    {
                        mat.Dispose();
                        continue;
                    }

                    Mat matLED = convertMatToLED(mat, 8, 12);
                    mat.Dispose();

                    // Allow iterating through pixel data
                    Image<Bgr, Byte> img = matLED.ToImage<Bgr, Byte>();
                    matLED.Dispose();

                    // Write LED representation
                    output.WriteLine("\t{");

                    string leds = "";
                    for (int j = 0; j < img.Rows; j += 1)
                    {
                        int line = 0;
                        for (int k = 0; k < img.Cols; k += 1)
                        {
                            line += img.Data[j, k, 0] > 0 ? 1 : 0;
                            line <<= 1;
                        }
                        line >>= 1;
                        line &= 0xFFF;
                        leds += line.ToString("X3");
                    }

                    output.WriteLine("\t\t0x" + leds.Substring(0, 8) + ",");
                    output.WriteLine("\t\t0x" + leds.Substring(8, 8) + ",");
                    output.WriteLine("\t\t0x" + leds.Substring(16, 8) + ",");

                    output.WriteLine("\t\t" + frameTime);

                    output.Write("\t}");
                    if (i < frames - 1)
                    {
                        output.Write(",");
                    }
                    output.WriteLine("");
                }

                // Write last line of animation file
                output.WriteLine("};");

                output.Close();
            }
        }
    }
}