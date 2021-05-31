using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Threading;



namespace OpenCV_CamTest
{
    public partial class Form1 : Form
    {
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        int isCameraRunning = 0;

        const string protoTexPath = @"C:\Users\lioie\Downloads\deploy.prototxt";
        const string caffeModelPath = @"C:\Users\lioie\Downloads\model.caffemodel";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_Capture_Click(object sender, EventArgs e)
        {
            if (button_Capture.Text.Equals("Start"))
            {
                CaptureCamera();
                button_Capture.Text = "Stop";
                isCameraRunning = 1;
            }
            else
            {
                if (capture.IsOpened())
                {
                    capture.Release();
                }

                button_Capture.Text = "Start";
                isCameraRunning = 0;
            }
        }
        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();

            //CaptureCameraCallback();
        }
        private void CaptureCameraCallback()
        {
            frame = new Mat();
            capture = new VideoCapture();
            capture.Open(0);

            while (isCameraRunning == 1)
            {
                capture.Read(frame);
                if (!frame.Empty())
                {
                    image = BitmapConverter.ToBitmap(frame);

                    //var texts = DetectPose();
                    //foreach(string text in texts)
                    //{
                    //    textBox1.Text += text + "\n";
                    //}

                    pictureBox_CamImage.Image = image;
                }
                image = null;
            }
        }
    }
}
