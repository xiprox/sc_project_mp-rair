namespace MP_RAIR
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.camrotright = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.irswitchbtn = new System.Windows.Forms.Button();
            this.camrotleft = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.camimgcap = new System.Windows.Forms.Button();
            this.recordbtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.camprevload = new System.Windows.Forms.Button();
            this.availablemics = new System.Windows.Forms.ComboBox();
            this.availablecameras = new System.Windows.Forms.ComboBox();
            this.camerapreview = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rcpanel = new System.Windows.Forms.Panel();
            this.r = new System.Windows.Forms.Button();
            this.dw = new System.Windows.Forms.Button();
            this.speed = new System.Windows.Forms.Label();
            this.gpscord = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.remdevicebtn = new System.Windows.Forms.Button();
            this.adddevicebtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.testconnbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentportselection = new System.Windows.Forms.Label();
            this.portcombo = new System.Windows.Forms.ComboBox();
            this.portapplybtn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.speedtrack = new System.Windows.Forms.Timer(this.components);
            this.l = new System.Windows.Forms.Button();
            this.tr = new System.Windows.Forms.Button();
            this.fwl = new System.Windows.Forms.Button();
            this.fwr = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.Button();
            this.tl = new System.Windows.Forms.Button();
            this.tdw = new System.Windows.Forms.Button();
            this.fw = new System.Windows.Forms.Button();
            this.tfw = new System.Windows.Forms.Button();
            this.dwr = new System.Windows.Forms.Button();
            this.dwl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.rcpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel2.Controls.Add(this.rcpanel);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1072, 561);
            this.splitContainer1.SplitterDistance = 620;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel1.Controls.Add(this.camrotright);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel1.Controls.Add(this.camerapreview);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer2.Size = new System.Drawing.Size(620, 561);
            this.splitContainer2.SplitterDistance = 413;
            this.splitContainer2.TabIndex = 16;
            // 
            // camrotright
            // 
            this.camrotright.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.camrotright.Location = new System.Drawing.Point(530, 245);
            this.camrotright.Name = "camrotright";
            this.camrotright.Size = new System.Drawing.Size(73, 45);
            this.camrotright.TabIndex = 1;
            this.camrotright.Text = "→";
            this.camrotright.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.camrotright.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(453, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "IHSAN ISIK   |   FEHIM TRNKA";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.irswitchbtn);
            this.groupBox5.Controls.Add(this.camrotleft);
            this.groupBox5.Location = new System.Drawing.Point(449, 226);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(160, 93);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CONTROL";
            // 
            // irswitchbtn
            // 
            this.irswitchbtn.Location = new System.Drawing.Point(6, 66);
            this.irswitchbtn.Name = "irswitchbtn";
            this.irswitchbtn.Size = new System.Drawing.Size(148, 23);
            this.irswitchbtn.TabIndex = 1;
            this.irswitchbtn.Text = "Nightvision";
            this.irswitchbtn.UseVisualStyleBackColor = true;
            this.irswitchbtn.Click += new System.EventHandler(this.irswitchbtn_Click);
            // 
            // camrotleft
            // 
            this.camrotleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.camrotleft.Location = new System.Drawing.Point(6, 19);
            this.camrotleft.Name = "camrotleft";
            this.camrotleft.Size = new System.Drawing.Size(73, 45);
            this.camrotleft.TabIndex = 0;
            this.camrotleft.Text = "←";
            this.camrotleft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.camrotleft.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.camimgcap);
            this.groupBox4.Controls.Add(this.recordbtn);
            this.groupBox4.Location = new System.Drawing.Point(449, 145);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 75);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RECORDING";
            // 
            // camimgcap
            // 
            this.camimgcap.Location = new System.Drawing.Point(6, 48);
            this.camimgcap.Name = "camimgcap";
            this.camimgcap.Size = new System.Drawing.Size(148, 23);
            this.camimgcap.TabIndex = 13;
            this.camimgcap.Text = "Capture Image";
            this.camimgcap.UseVisualStyleBackColor = true;
            // 
            // recordbtn
            // 
            this.recordbtn.Enabled = false;
            this.recordbtn.Location = new System.Drawing.Point(6, 19);
            this.recordbtn.Name = "recordbtn";
            this.recordbtn.Size = new System.Drawing.Size(148, 23);
            this.recordbtn.TabIndex = 12;
            this.recordbtn.Text = "Record";
            this.recordbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.camprevload);
            this.groupBox3.Controls.Add(this.availablemics);
            this.groupBox3.Controls.Add(this.availablecameras);
            this.groupBox3.Location = new System.Drawing.Point(449, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 98);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CAMERA";
            // 
            // camprevload
            // 
            this.camprevload.Location = new System.Drawing.Point(6, 73);
            this.camprevload.Name = "camprevload";
            this.camprevload.Size = new System.Drawing.Size(148, 23);
            this.camprevload.TabIndex = 10;
            this.camprevload.Text = "Start";
            this.camprevload.UseVisualStyleBackColor = true;
            this.camprevload.Click += new System.EventHandler(this.camprevload_Click_1);
            // 
            // availablemics
            // 
            this.availablemics.FormattingEnabled = true;
            this.availablemics.Location = new System.Drawing.Point(6, 46);
            this.availablemics.Name = "availablemics";
            this.availablemics.Size = new System.Drawing.Size(148, 21);
            this.availablemics.TabIndex = 9;
            this.availablemics.Text = "AUDIO";
            // 
            // availablecameras
            // 
            this.availablecameras.FormattingEnabled = true;
            this.availablecameras.Location = new System.Drawing.Point(6, 19);
            this.availablecameras.Name = "availablecameras";
            this.availablecameras.Size = new System.Drawing.Size(148, 21);
            this.availablecameras.TabIndex = 8;
            this.availablecameras.Text = "VIDEO";
            // 
            // camerapreview
            // 
            this.camerapreview.BackColor = System.Drawing.Color.Black;
            this.camerapreview.Location = new System.Drawing.Point(16, 41);
            this.camerapreview.Name = "camerapreview";
            this.camerapreview.Size = new System.Drawing.Size(427, 360);
            this.camerapreview.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "CAMERA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MP_RAIR.Properties.Resources.SCHRC;
            this.pictureBox1.Location = new System.Drawing.Point(446, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(12, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 26);
            this.label6.TabIndex = 23;
            this.label6.Text = "MOTORS";
            // 
            // rcpanel
            // 
            this.rcpanel.BackColor = System.Drawing.SystemColors.Control;
            this.rcpanel.Controls.Add(this.dwr);
            this.rcpanel.Controls.Add(this.dwl);
            this.rcpanel.Controls.Add(this.tfw);
            this.rcpanel.Controls.Add(this.fw);
            this.rcpanel.Controls.Add(this.tdw);
            this.rcpanel.Controls.Add(this.tl);
            this.rcpanel.Controls.Add(this.x);
            this.rcpanel.Controls.Add(this.fwr);
            this.rcpanel.Controls.Add(this.fwl);
            this.rcpanel.Controls.Add(this.tr);
            this.rcpanel.Controls.Add(this.l);
            this.rcpanel.Controls.Add(this.r);
            this.rcpanel.Controls.Add(this.dw);
            this.rcpanel.Controls.Add(this.speed);
            this.rcpanel.Controls.Add(this.gpscord);
            this.rcpanel.Controls.Add(this.temp);
            this.rcpanel.Controls.Add(this.button1);
            this.rcpanel.Controls.Add(this.label4);
            this.rcpanel.Controls.Add(this.shapeContainer1);
            this.rcpanel.Location = new System.Drawing.Point(2, 0);
            this.rcpanel.Name = "rcpanel";
            this.rcpanel.Size = new System.Drawing.Size(220, 561);
            this.rcpanel.TabIndex = 4;
            // 
            // r
            // 
            this.r.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.r.Location = new System.Drawing.Point(142, 178);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(29, 57);
            this.r.TabIndex = 24;
            this.r.Text = "→";
            this.r.UseVisualStyleBackColor = true;
            // 
            // dw
            // 
            this.dw.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dw.Location = new System.Drawing.Point(87, 241);
            this.dw.Name = "dw";
            this.dw.Size = new System.Drawing.Size(49, 56);
            this.dw.TabIndex = 23;
            this.dw.Text = "↓";
            this.dw.UseVisualStyleBackColor = true;
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.speed.Location = new System.Drawing.Point(83, 423);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(136, 31);
            this.speed.TabIndex = 21;
            this.speed.Text = "000 KMph";
            // 
            // gpscord
            // 
            this.gpscord.AutoSize = true;
            this.gpscord.Location = new System.Drawing.Point(34, 493);
            this.gpscord.Name = "gpscord";
            this.gpscord.Size = new System.Drawing.Size(35, 13);
            this.gpscord.TabIndex = 19;
            this.gpscord.Text = "GPS: ";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Location = new System.Drawing.Point(34, 471);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(99, 13);
            this.temp.TabIndex = 18;
            this.temp.Text = "Temperature: 00 °C";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "← General Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(14, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "VEHICLE";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(220, 561);
            this.shapeContainer1.TabIndex = 20;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 14;
            this.lineShape1.X2 = 210;
            this.lineShape1.Y1 = 455;
            this.lineShape1.Y2 = 455;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(228, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 561);
            this.panel2.TabIndex = 23;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.remdevicebtn);
            this.groupBox6.Controls.Add(this.adddevicebtn);
            this.groupBox6.Location = new System.Drawing.Point(8, 39);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 53);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "DEVICE";
            // 
            // remdevicebtn
            // 
            this.remdevicebtn.Location = new System.Drawing.Point(104, 20);
            this.remdevicebtn.Name = "remdevicebtn";
            this.remdevicebtn.Size = new System.Drawing.Size(88, 23);
            this.remdevicebtn.TabIndex = 1;
            this.remdevicebtn.Text = "Remove";
            this.remdevicebtn.UseVisualStyleBackColor = true;
            this.remdevicebtn.Click += new System.EventHandler(this.remdevicebtn_Click);
            // 
            // adddevicebtn
            // 
            this.adddevicebtn.Location = new System.Drawing.Point(10, 20);
            this.adddevicebtn.Name = "adddevicebtn";
            this.adddevicebtn.Size = new System.Drawing.Size(88, 23);
            this.adddevicebtn.TabIndex = 0;
            this.adddevicebtn.Text = "Add";
            this.adddevicebtn.UseVisualStyleBackColor = true;
            this.adddevicebtn.Click += new System.EventHandler(this.adddevicebtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(14, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "GENERAL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.testconnbtn);
            this.groupBox2.Location = new System.Drawing.Point(8, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 53);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test Connection";
            // 
            // testconnbtn
            // 
            this.testconnbtn.Location = new System.Drawing.Point(10, 20);
            this.testconnbtn.Name = "testconnbtn";
            this.testconnbtn.Size = new System.Drawing.Size(184, 23);
            this.testconnbtn.TabIndex = 0;
            this.testconnbtn.Text = "PIN12 LED Blink";
            this.testconnbtn.UseVisualStyleBackColor = true;
            this.testconnbtn.Click += new System.EventHandler(this.testconnbtn_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentportselection);
            this.groupBox1.Controls.Add(this.portcombo);
            this.groupBox1.Controls.Add(this.portapplybtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(8, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 102);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PORT";
            // 
            // currentportselection
            // 
            this.currentportselection.AutoSize = true;
            this.currentportselection.Location = new System.Drawing.Point(10, 81);
            this.currentportselection.Name = "currentportselection";
            this.currentportselection.Size = new System.Drawing.Size(99, 13);
            this.currentportselection.TabIndex = 3;
            this.currentportselection.Text = "CURRENT PORT: ";
            // 
            // portcombo
            // 
            this.portcombo.FormattingEnabled = true;
            this.portcombo.Location = new System.Drawing.Point(10, 20);
            this.portcombo.Name = "portcombo";
            this.portcombo.Size = new System.Drawing.Size(184, 21);
            this.portcombo.TabIndex = 2;
            this.portcombo.Text = "PORT";
            // 
            // portapplybtn
            // 
            this.portapplybtn.Location = new System.Drawing.Point(10, 50);
            this.portapplybtn.Name = "portapplybtn";
            this.portapplybtn.Size = new System.Drawing.Size(184, 23);
            this.portapplybtn.TabIndex = 2;
            this.portapplybtn.Text = "Apply";
            this.portapplybtn.UseVisualStyleBackColor = true;
            this.portapplybtn.Click += new System.EventHandler(this.portapplybtn_Click_1);
            // 
            // serialPort1
            // 
            this.serialPort1.DtrEnable = true;
            this.serialPort1.PortName = "COM5";
            // 
            // speedtrack
            // 
            this.speedtrack.Enabled = true;
            this.speedtrack.Tick += new System.EventHandler(this.speedtrack_Tick);
            // 
            // l
            // 
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.l.Location = new System.Drawing.Point(50, 178);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(30, 57);
            this.l.TabIndex = 26;
            this.l.Text = "←";
            this.l.UseVisualStyleBackColor = true;
            // 
            // tr
            // 
            this.tr.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.tr.Location = new System.Drawing.Point(177, 178);
            this.tr.Name = "tr";
            this.tr.Size = new System.Drawing.Size(30, 57);
            this.tr.TabIndex = 27;
            this.tr.Text = "→";
            this.tr.UseVisualStyleBackColor = true;
            // 
            // fwl
            // 
            this.fwl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.fwl.Location = new System.Drawing.Point(14, 114);
            this.fwl.Name = "fwl";
            this.fwl.Size = new System.Drawing.Size(66, 57);
            this.fwl.TabIndex = 28;
            this.fwl.Text = "←↑";
            this.fwl.UseVisualStyleBackColor = true;
            // 
            // fwr
            // 
            this.fwr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.fwr.Location = new System.Drawing.Point(142, 114);
            this.fwr.Name = "fwr";
            this.fwr.Size = new System.Drawing.Size(65, 57);
            this.fwr.TabIndex = 30;
            this.fwr.Text = "↑→";
            this.fwr.UseVisualStyleBackColor = true;
            // 
            // x
            // 
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.x.Location = new System.Drawing.Point(87, 178);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(49, 57);
            this.x.TabIndex = 31;
            this.x.Text = "O";
            this.x.UseVisualStyleBackColor = true;
            // 
            // tl
            // 
            this.tl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.tl.Location = new System.Drawing.Point(14, 178);
            this.tl.Name = "tl";
            this.tl.Size = new System.Drawing.Size(30, 57);
            this.tl.TabIndex = 32;
            this.tl.Text = "←";
            this.tl.UseVisualStyleBackColor = true;
            // 
            // tdw
            // 
            this.tdw.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.tdw.Location = new System.Drawing.Point(14, 303);
            this.tdw.Name = "tdw";
            this.tdw.Size = new System.Drawing.Size(192, 53);
            this.tdw.TabIndex = 33;
            this.tdw.Text = "↓↓";
            this.tdw.UseVisualStyleBackColor = true;
            // 
            // fw
            // 
            this.fw.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.fw.Location = new System.Drawing.Point(87, 114);
            this.fw.Name = "fw";
            this.fw.Size = new System.Drawing.Size(49, 57);
            this.fw.TabIndex = 34;
            this.fw.Text = "↑";
            this.fw.UseVisualStyleBackColor = true;
            // 
            // tfw
            // 
            this.tfw.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.tfw.Location = new System.Drawing.Point(14, 55);
            this.tfw.Name = "tfw";
            this.tfw.Size = new System.Drawing.Size(195, 53);
            this.tfw.TabIndex = 35;
            this.tfw.Text = "↑↑";
            this.tfw.UseVisualStyleBackColor = true;
            this.tfw.Click += new System.EventHandler(this.tfw_Click);
            // 
            // dwr
            // 
            this.dwr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dwr.Location = new System.Drawing.Point(142, 241);
            this.dwr.Name = "dwr";
            this.dwr.Size = new System.Drawing.Size(65, 57);
            this.dwr.TabIndex = 37;
            this.dwr.Text = "↓→";
            this.dwr.UseVisualStyleBackColor = true;
            // 
            // dwl
            // 
            this.dwl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dwl.Location = new System.Drawing.Point(14, 241);
            this.dwl.Name = "dwl";
            this.dwl.Size = new System.Drawing.Size(66, 57);
            this.dwl.TabIndex = 36;
            this.dwl.Text = "←↓";
            this.dwl.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1072, 561);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(860, 600);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "MP-RAIR CONTROL";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.rcpanel.ResumeLayout(false);
            this.rcpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel rcpanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label gpscord;
        private System.Windows.Forms.Label temp;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button testconnbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label currentportselection;
        private System.Windows.Forms.ComboBox portcombo;
        private System.Windows.Forms.Button portapplybtn;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button camrotright;
        private System.Windows.Forms.Button camrotleft;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button camimgcap;
        private System.Windows.Forms.Button recordbtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button camprevload;
        private System.Windows.Forms.ComboBox availablemics;
        private System.Windows.Forms.ComboBox availablecameras;
        private System.Windows.Forms.Panel camerapreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button adddevicebtn;
        private System.Windows.Forms.Button remdevicebtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer speedtrack;
        private System.Windows.Forms.Button irswitchbtn;
        private System.Windows.Forms.Button r;
        private System.Windows.Forms.Button dw;
        private System.Windows.Forms.Button fwr;
        private System.Windows.Forms.Button fwl;
        private System.Windows.Forms.Button tr;
        private System.Windows.Forms.Button l;
        private System.Windows.Forms.Button dwr;
        private System.Windows.Forms.Button dwl;
        private System.Windows.Forms.Button tfw;
        private System.Windows.Forms.Button fw;
        private System.Windows.Forms.Button tdw;
        private System.Windows.Forms.Button tl;
        private System.Windows.Forms.Button x;
    }
}

