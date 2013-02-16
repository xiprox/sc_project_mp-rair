using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Security.Permissions;
using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.Live;
using Microsoft.Expression.Encoder;
using System.Runtime.InteropServices;
using System.Diagnostics;






namespace MP_RAIR
{
    public partial class Form1 : Form
    {

        private LiveJob _job;
        private LiveDeviceSource _deviceSource;
        private bool _bStartedRecording = false;


        public Form1()
        {
            InitializeComponent();

            currentportselection.Text = "CURRENT PORT: " + serialPort1.PortName;
            String[] portnames = SerialPort.GetPortNames();
            foreach (string port in portnames)
            {
                portcombo.Items.Add(port);
            }

            serialPort1.DataReceived += serialPort1_DataReceived;

            foreach (EncoderDevice edv in EncoderDevices.FindDevices(EncoderDeviceType.Video))
            {
                availablecameras.Items.Add(edv.Name);
            }
            foreach (EncoderDevice eda in EncoderDevices.FindDevices(EncoderDeviceType.Audio))
            {
                availablemics.Items.Add(eda.Name);
            }

            if (_bStartedRecording == false) { recordbtn.Text = "Start Recording"; }
            if (_bStartedRecording == true) { recordbtn.Text = "Stop Recording"; }

            rcpanel.SendToBack();

           




        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = serialPort1.ReadLine();
            this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
        }

        private delegate void LineReceivedEvent(string line);
        private void LineReceived(string line)
        {
            //What to do with the received line here
            /*   textBox1.Text = "CORDINATE: ";
               textBox1.Text += line;
               */
        }
        /*
                private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
                {
                    RxString = serialPort1.ReadExisting();
           


                    this.Invoke(new EventHandler(writetext));
                }

                private void writetext(object sender, EventArgs e)
                {
                    try
                    {
                    serialPort1.Open();
                    cordinates.Items.Add("CORDINATE: " + RxString);
                    serialPort1.Close();
                    }
                    catch { }
                    }
                */




        private void GetSelectedVideoAndAudioDevices(out EncoderDevice video, out EncoderDevice audio)
        {
            video = null;
            audio = null;


            if (availablecameras.SelectedIndex < 0 || availablemics.SelectedIndex < 0)
            {
                MessageBox.Show("No Video and Audio devices have been selected.\nSelect the ones to preview from the list and try again.", "Warning");
                return;
            }

            // Get the selected video device            
            foreach (EncoderDevice edv in EncoderDevices.FindDevices(EncoderDeviceType.Video))
            {
                if (String.Compare(edv.Name, availablecameras.SelectedItem.ToString()) == 0)
                {
                    video = edv;
                    break;
                }
            }








        }

        private void recordbtn_Click(object sender, EventArgs e)
        {
            if (_bStartedRecording == true)
            {

                // Stops encoding
                _job.StopEncoding();
                recordbtn.Text = "Start Recording";
                _bStartedRecording = false;
            }
            else
            {
                try
                {
                    // Sets up publishing format for file archival type
                    FileArchivePublishFormat fileOut = new FileArchivePublishFormat();
                    MessageBox.Show("fileOut set");

                    // Sets file path and name
                    fileOut.OutputFileName = String.Format("C:\\WebCam{0:yyyyMMdd_hhmmss}.wmv", DateTime.Now);
                    MessageBox.Show("Path set");

                    // Adds the format to the job. You can add additional formats as well such as
                    // Publishing streams or broadcasting from a port
                    _job.PublishFormats.Add(fileOut);
                    MessageBox.Show("added Publish format");

                    // Start encoding
                    _job.StartEncoding();
                    MessageBox.Show("started job");


                    recordbtn.Text = "Stop Recording";

                    _bStartedRecording = true;
                }
                catch
                {
                    MessageBox.Show("Error Recording", "Error");
                }
            }
        }

        private void camimgcap_Click(object sender, EventArgs e)
        {
            // Create a Bitmap of the same dimension of panelVideoPreview (Width x Height)
            using (Bitmap bitmap = new Bitmap(camerapreview.Width, camerapreview.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // Get the paramters to call g.CopyFromScreen and get the image
                    Rectangle rectanglecamerapreview = camerapreview.Bounds;
                    Point sourcePoints = camerapreview.PointToScreen(new Point(camerapreview.ClientRectangle.X, camerapreview.ClientRectangle.Y));
                    g.CopyFromScreen(sourcePoints, Point.Empty, rectanglecamerapreview.Size);
                }
                try
                {
                    //  string strGrabFileName = String.Format("C:\\Snapshot_{0:yyyyMMdd_hhmmss}.jpg", DateTime.Now);
                    bitmap.Save("capture.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch
                {
                    MessageBox.Show("error capturing");
                }

            }
        }

        private void camrotleft_Click(object sender, EventArgs e)
        {
            //rotate camera to the left


        }

        private void camrotright_Click(object sender, EventArgs e)
        {
            //rotate camera to the right

        }

        private void switchpanel_Click(object sender, EventArgs e)
        {

            rcpanel.BringToFront();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            rcpanel.SendToBack();

        }

        private void camprevload_Click_1(object sender, EventArgs e)
        {
            EncoderDevice video = null;
            EncoderDevice audio = null;

            GetSelectedVideoAndAudioDevices(out video, out audio);

            try
            {
                _job = new LiveJob();
                _deviceSource = _job.AddDeviceSource(video, audio);
                _deviceSource.PreviewWindow = new PreviewWindow(new HandleRef(camerapreview, camerapreview.Handle));
                _job.ActivateSource(_deviceSource);

            }
            catch
            {
                MessageBox.Show("There was an error loading devices for preview", "Error Loading Preview");
            }
        }

        private void portapplybtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                String PortSelection = portcombo.SelectedItem.ToString();
                serialPort1.PortName = PortSelection;
                currentportselection.Text = "CURRENT PORT: " + serialPort1.PortName;
            }
            catch
            {
                MessageBox.Show("Please select a Port first.");

            }
        }

        private void testconnbtn_Click_1(object sender, EventArgs e)
        {
           

                try
                {
                    serialPort1.Write("0");
                }
                catch
                {
                    MessageBox.Show("There was an error. Please make sure that the correct port was selected.");
                }

          
        }

        private void adddevicebtn_Click(object sender, EventArgs e)
        {

            adddevice();

        }


        void adddevice()
        {
            try
            {
                Process p = Process.Start("C:\\Windows\\System32\\DevicePairingWizard.exe");
                while (true)
                {
                    if (p.HasExited)
                        break;
                }
                String[] portnames = SerialPort.GetPortNames();
                foreach (string port in portnames)
                {
                    portcombo.Items.Add(port);
                }

            }
            catch (Exception)
            {
                if (DialogResult.Retry == MessageBox.Show("Unable to find your device", "Please try again", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error))
                    adddevice();
            }
        }

        private void remdevicebtn_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("C:\\Windows\\System32\\control.exe ");

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void speedtrack_Tick(object sender, EventArgs e)
        {

        }

        private void irswitchbtn_Click(object sender, EventArgs e)
        {
           

                try
                {
                   
                    serialPort1.Write("i");
                    
                }
                catch
                {
                    MessageBox.Show("There was an error.");
                }

        

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        Char before;
    

        private void fwrbtn_Click(object sender, EventArgs e)
        {
           
          
        }

        private void bwdbtn_Click(object sender, EventArgs e)
        {

        }

        private void lftbtn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("1");
          
            }
            catch
            {
                MessageBox.Show("There was an error. Please make sure that the correct port was selected.");
            }


           
        }

        private void rghtbtn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("2");
            }
            catch
            {
                MessageBox.Show("There was an error. Please make sure that the correct port was selected.");
            }

        }

        private void W(object sender, KeyEventArgs e)
        {
            if (before == 'W')
            {
                
                    serialPort1.Write("U");
                }

                else
                {
                   
                        serialPort1.Write("W");
                  
                }
            }

        private void tfw_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {

                try
                {
                    serialPort1.Open();
                    MessageBox.Show("opened");
                    serialPort1.Write("U");
                    MessageBox.Show("written");
                    
                }
                catch
                {
                    MessageBox.Show("error");
                }
            }

            else
            {
                try
                {
                    serialPort1.Write("U");
                }
                catch
                {
                }
            }
        }




        }
    }
