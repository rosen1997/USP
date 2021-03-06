﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;
using QRCodeEncoderDecoderLibrary;

namespace QRScan
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection CaptureDevice; // list of webcam
        private VideoCaptureDevice FinalFrame;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);//constructor
            foreach (FilterInfo Device in CaptureDevice)
            {
                CMB_cameras.Items.Add(Device.Name);
            }

            CMB_cameras.SelectedIndex = 0; // default
            FinalFrame = new VideoCaptureDevice();
        }

        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs) // must be void so that it can be accessed everywhere.
        // New Frame Event Args is an constructor of a class
        {
            Bitmap bitmap = eventArgs.Frame;
            pictureBox1.Image = (Bitmap)bitmap.Clone();
            // pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();// clone the bitmap
        }

        private void BTN_start_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[CMB_cameras.SelectedIndex].MonikerString);// specified web cam and its filter moniker string
            FinalFrame.VideoResolution = FinalFrame.VideoCapabilities[2];
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);// click button event is fired, 
            FinalFrame.Start();
        }
        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            //Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                //Console.WriteLine("stop wait timer");
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void buttonLess()
        {
            int flag = 0;
            for (int i = 0; i < 20; i++)
            { 
                QRDecoder QRCodeDecoder = new QRDecoder();
                byte[][] DataByteArray = QRCodeDecoder.ImageDecoder((Bitmap)pictureBox1.Image);
                try
                {
                    string Result = QRCode.ByteArrayToStr(DataByteArray[0]);
                    int ID;
                    int.TryParse(Result, out ID);
                    flag = 1;

                    dbControl oDB = new dbControl(ID);
                    try
                    {
                        oDB.connectToDB();
                        oDB.writeToDB();
                        oDB.closeConnection();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;
                }
                catch { }
                wait(500);
            }
            if (flag == 0)
                MessageBox.Show("Could not detect QR","Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void BTN_stop_Click(object sender, EventArgs e)
        {
            if (FinalFrame.IsRunning == true) FinalFrame.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BTN_stop_Click(sender, e);
        }

        private void BTN_scan_Click(object sender, EventArgs e)
        {
            QRDecoder QRCodeDecoder = new QRDecoder();
            byte[][] DataByteArray = QRCodeDecoder.ImageDecoder((Bitmap)pictureBox1.Image);
            try
            {
                string Result = QRCode.ByteArrayToStr(DataByteArray[0]);
                //LBL_test.Text = Result;
            }
            catch { MessageBox.Show("Could not detect QR code!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }

        private void BTN_startCapturing_Click(object sender, EventArgs e)
        {
            buttonLess();
        }
    }
}
