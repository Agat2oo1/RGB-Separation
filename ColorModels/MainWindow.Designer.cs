namespace ColorModels
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ToGreyscale = new System.Windows.Forms.CheckBox();
            this.LabSettings = new System.Windows.Forms.GroupBox();
            this.SetModel = new System.Windows.Forms.Button();
            this.x_g = new System.Windows.Forms.NumericUpDown();
            this.gamma = new System.Windows.Forms.NumericUpDown();
            this.y_w = new System.Windows.Forms.NumericUpDown();
            this.y_b = new System.Windows.Forms.NumericUpDown();
            this.y_g = new System.Windows.Forms.NumericUpDown();
            this.x_w = new System.Windows.Forms.NumericUpDown();
            this.x_b = new System.Windows.Forms.NumericUpDown();
            this.y_r = new System.Windows.Forms.NumericUpDown();
            this.x_r = new System.Windows.Forms.NumericUpDown();
            this.iluminant = new System.Windows.Forms.ComboBox();
            this.colorProfile = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modelList = new System.Windows.Forms.ComboBox();
            this.Separate = new System.Windows.Forms.Button();
            this.LoadImage = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ThirdChannel = new System.Windows.Forms.PictureBox();
            this.SecondChannel = new System.Windows.Forms.PictureBox();
            this.FirstChannel = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.LabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_w)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_w)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstChannel)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.20642F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.79358F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1362, 839);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.ToGreyscale);
            this.panel1.Controls.Add(this.LabSettings);
            this.panel1.Controls.Add(this.modelList);
            this.panel1.Controls.Add(this.Separate);
            this.panel1.Controls.Add(this.LoadImage);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 465);
            this.panel1.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(680, 393);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 25);
            this.label14.TabIndex = 12;
            this.label14.Text = "V";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Load HSV Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(709, 393);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(182, 69);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ToGreyscale
            // 
            this.ToGreyscale.AutoSize = true;
            this.ToGreyscale.Location = new System.Drawing.Point(709, 214);
            this.ToGreyscale.Name = "ToGreyscale";
            this.ToGreyscale.Size = new System.Drawing.Size(112, 29);
            this.ToGreyscale.TabIndex = 8;
            this.ToGreyscale.Text = "Greyscale";
            this.ToGreyscale.UseVisualStyleBackColor = true;
            this.ToGreyscale.CheckedChanged += new System.EventHandler(this.ToGreyscale_CheckedChanged);
            // 
            // LabSettings
            // 
            this.LabSettings.Controls.Add(this.SetModel);
            this.LabSettings.Controls.Add(this.x_g);
            this.LabSettings.Controls.Add(this.gamma);
            this.LabSettings.Controls.Add(this.y_w);
            this.LabSettings.Controls.Add(this.y_b);
            this.LabSettings.Controls.Add(this.y_g);
            this.LabSettings.Controls.Add(this.x_w);
            this.LabSettings.Controls.Add(this.x_b);
            this.LabSettings.Controls.Add(this.y_r);
            this.LabSettings.Controls.Add(this.x_r);
            this.LabSettings.Controls.Add(this.iluminant);
            this.LabSettings.Controls.Add(this.colorProfile);
            this.LabSettings.Controls.Add(this.label13);
            this.LabSettings.Controls.Add(this.label12);
            this.LabSettings.Controls.Add(this.label11);
            this.LabSettings.Controls.Add(this.label10);
            this.LabSettings.Controls.Add(this.label9);
            this.LabSettings.Controls.Add(this.label8);
            this.LabSettings.Controls.Add(this.label7);
            this.LabSettings.Controls.Add(this.label6);
            this.LabSettings.Controls.Add(this.label5);
            this.LabSettings.Controls.Add(this.label4);
            this.LabSettings.Enabled = false;
            this.LabSettings.Location = new System.Drawing.Point(944, 23);
            this.LabSettings.Name = "LabSettings";
            this.LabSettings.Size = new System.Drawing.Size(403, 439);
            this.LabSettings.TabIndex = 7;
            this.LabSettings.TabStop = false;
            this.LabSettings.Text = "Lab Settings";
            // 
            // SetModel
            // 
            this.SetModel.Enabled = false;
            this.SetModel.Location = new System.Drawing.Point(269, 374);
            this.SetModel.Name = "SetModel";
            this.SetModel.Size = new System.Drawing.Size(112, 45);
            this.SetModel.TabIndex = 21;
            this.SetModel.Text = "Set";
            this.SetModel.UseVisualStyleBackColor = true;
            this.SetModel.Click += new System.EventHandler(this.SetModel_Click);
            // 
            // x_g
            // 
            this.x_g.DecimalPlaces = 6;
            this.x_g.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.x_g.Location = new System.Drawing.Point(141, 217);
            this.x_g.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.x_g.Name = "x_g";
            this.x_g.Size = new System.Drawing.Size(112, 31);
            this.x_g.TabIndex = 20;
            this.x_g.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.x_g.Click += new System.EventHandler(this.SetProfileChanged);
            // 
            // gamma
            // 
            this.gamma.DecimalPlaces = 2;
            this.gamma.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.gamma.Location = new System.Drawing.Point(269, 328);
            this.gamma.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.gamma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gamma.Name = "gamma";
            this.gamma.Size = new System.Drawing.Size(112, 31);
            this.gamma.TabIndex = 19;
            this.gamma.Value = new decimal(new int[] {
            220,
            0,
            0,
            131072});
            this.gamma.Click += new System.EventHandler(this.gamma_Click);
            // 
            // y_w
            // 
            this.y_w.DecimalPlaces = 6;
            this.y_w.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.y_w.Location = new System.Drawing.Point(269, 291);
            this.y_w.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.y_w.Name = "y_w";
            this.y_w.Size = new System.Drawing.Size(112, 31);
            this.y_w.TabIndex = 18;
            this.y_w.Value = new decimal(new int[] {
            329020,
            0,
            0,
            393216});
            this.y_w.Click += new System.EventHandler(this.SetWPointChanged);
            // 
            // y_b
            // 
            this.y_b.DecimalPlaces = 6;
            this.y_b.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.y_b.Location = new System.Drawing.Point(269, 254);
            this.y_b.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.y_b.Name = "y_b";
            this.y_b.Size = new System.Drawing.Size(112, 31);
            this.y_b.TabIndex = 17;
            this.y_b.Value = new decimal(new int[] {
            6,
            0,
            0,
            131072});
            this.y_b.Click += new System.EventHandler(this.SetProfileChanged);
            // 
            // y_g
            // 
            this.y_g.DecimalPlaces = 6;
            this.y_g.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.y_g.Location = new System.Drawing.Point(269, 217);
            this.y_g.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.y_g.Name = "y_g";
            this.y_g.Size = new System.Drawing.Size(112, 31);
            this.y_g.TabIndex = 16;
            this.y_g.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            this.y_g.Click += new System.EventHandler(this.SetProfileChanged);
            // 
            // x_w
            // 
            this.x_w.DecimalPlaces = 6;
            this.x_w.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.x_w.Location = new System.Drawing.Point(141, 291);
            this.x_w.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.x_w.Name = "x_w";
            this.x_w.Size = new System.Drawing.Size(112, 31);
            this.x_w.TabIndex = 15;
            this.x_w.Value = new decimal(new int[] {
            312730,
            0,
            0,
            393216});
            this.x_w.Click += new System.EventHandler(this.SetWPointChanged);
            // 
            // x_b
            // 
            this.x_b.DecimalPlaces = 6;
            this.x_b.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.x_b.Location = new System.Drawing.Point(141, 254);
            this.x_b.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.x_b.Name = "x_b";
            this.x_b.Size = new System.Drawing.Size(112, 31);
            this.x_b.TabIndex = 14;
            this.x_b.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            this.x_b.Click += new System.EventHandler(this.SetProfileChanged);
            // 
            // y_r
            // 
            this.y_r.DecimalPlaces = 6;
            this.y_r.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.y_r.Location = new System.Drawing.Point(269, 180);
            this.y_r.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.y_r.Name = "y_r";
            this.y_r.Size = new System.Drawing.Size(112, 31);
            this.y_r.TabIndex = 13;
            this.y_r.Value = new decimal(new int[] {
            33,
            0,
            0,
            131072});
            this.y_r.Click += new System.EventHandler(this.SetProfileChanged);
            // 
            // x_r
            // 
            this.x_r.DecimalPlaces = 6;
            this.x_r.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.x_r.Location = new System.Drawing.Point(141, 180);
            this.x_r.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.x_r.Name = "x_r";
            this.x_r.Size = new System.Drawing.Size(112, 31);
            this.x_r.TabIndex = 12;
            this.x_r.Value = new decimal(new int[] {
            64,
            0,
            0,
            131072});
            this.x_r.Click += new System.EventHandler(this.SetProfileChanged);
            // 
            // iluminant
            // 
            this.iluminant.FormattingEnabled = true;
            this.iluminant.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D50",
            "D55",
            "D65",
            "D75",
            "E",
            "F2",
            "F7",
            "F11",
            "Custom White Point"});
            this.iluminant.Location = new System.Drawing.Point(210, 79);
            this.iluminant.Name = "iluminant";
            this.iluminant.Size = new System.Drawing.Size(171, 33);
            this.iluminant.TabIndex = 11;
            this.iluminant.SelectedIndexChanged += new System.EventHandler(this.iluminant_SelectedIndexChanged);
            // 
            // colorProfile
            // 
            this.colorProfile.FormattingEnabled = true;
            this.colorProfile.Items.AddRange(new object[] {
            "sRGB",
            "AdobeRGB",
            "AppleRGB",
            "CIE RGB",
            "Wide Gamut",
            "Custom Range"});
            this.colorProfile.Location = new System.Drawing.Point(210, 35);
            this.colorProfile.Name = "colorProfile";
            this.colorProfile.Size = new System.Drawing.Size(171, 33);
            this.colorProfile.TabIndex = 10;
            this.colorProfile.SelectedIndexChanged += new System.EventHandler(this.colorProfile_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(179, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 25);
            this.label13.TabIndex = 9;
            this.label13.Text = "Gamma";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 25);
            this.label12.TabIndex = 8;
            this.label12.Text = "White point";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "Blue primary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Green primary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Red primary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chromacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Predefined iluminant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Predefined color profile";
            // 
            // modelList
            // 
            this.modelList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelList.FormattingEnabled = true;
            this.modelList.Items.AddRange(new object[] {
            "YCbCr",
            "HSV",
            "Lab"});
            this.modelList.Location = new System.Drawing.Point(709, 124);
            this.modelList.Name = "modelList";
            this.modelList.Size = new System.Drawing.Size(182, 33);
            this.modelList.TabIndex = 6;
            this.modelList.SelectedIndexChanged += new System.EventHandler(this.modelList_SelectedIndexChanged);
            // 
            // Separate
            // 
            this.Separate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Separate.Location = new System.Drawing.Point(709, 163);
            this.Separate.Name = "Separate";
            this.Separate.Size = new System.Drawing.Size(182, 45);
            this.Separate.TabIndex = 2;
            this.Separate.Text = "Separate Channels";
            this.Separate.UseVisualStyleBackColor = true;
            this.Separate.Click += new System.EventHandler(this.Separate_Click);
            // 
            // LoadImage
            // 
            this.LoadImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadImage.Location = new System.Drawing.Point(709, 23);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(182, 45);
            this.LoadImage.TabIndex = 1;
            this.LoadImage.Text = "Load Image";
            this.LoadImage.UseVisualStyleBackColor = true;
            this.LoadImage.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(17, 23);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(643, 439);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ThirdChannel);
            this.panel2.Controls.Add(this.SecondChannel);
            this.panel2.Controls.Add(this.FirstChannel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 474);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 362);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(897, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(457, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cb";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Y";
            // 
            // ThirdChannel
            // 
            this.ThirdChannel.BackColor = System.Drawing.Color.White;
            this.ThirdChannel.Location = new System.Drawing.Point(897, 37);
            this.ThirdChannel.Name = "ThirdChannel";
            this.ThirdChannel.Size = new System.Drawing.Size(434, 306);
            this.ThirdChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ThirdChannel.TabIndex = 2;
            this.ThirdChannel.TabStop = false;
            // 
            // SecondChannel
            // 
            this.SecondChannel.BackColor = System.Drawing.Color.White;
            this.SecondChannel.Location = new System.Drawing.Point(457, 37);
            this.SecondChannel.Name = "SecondChannel";
            this.SecondChannel.Size = new System.Drawing.Size(434, 306);
            this.SecondChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SecondChannel.TabIndex = 1;
            this.SecondChannel.TabStop = false;
            // 
            // FirstChannel
            // 
            this.FirstChannel.BackColor = System.Drawing.Color.White;
            this.FirstChannel.Location = new System.Drawing.Point(17, 37);
            this.FirstChannel.Name = "FirstChannel";
            this.FirstChannel.Size = new System.Drawing.Size(434, 306);
            this.FirstChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FirstChannel.TabIndex = 0;
            this.FirstChannel.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = resources.GetString("openFileDialog.Filter");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 839);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindow";
            this.Text = "RGB Separation";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.LabSettings.ResumeLayout(false);
            this.LabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_w)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_w)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstChannel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox;
        private Panel panel2;
        private PictureBox FirstChannel;
        private PictureBox ThirdChannel;
        private PictureBox SecondChannel;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button Separate;
        private Button LoadImage;
        private OpenFileDialog openFileDialog;
        private ComboBox modelList;
        private GroupBox LabSettings;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox iluminant;
        private ComboBox colorProfile;
        private NumericUpDown x_g;
        private NumericUpDown gamma;
        private NumericUpDown y_w;
        private NumericUpDown y_b;
        private NumericUpDown y_g;
        private NumericUpDown x_w;
        private NumericUpDown x_b;
        private NumericUpDown y_r;
        private NumericUpDown x_r;
        private Button SetModel;
        private CheckBox ToGreyscale;
        private TrackBar trackBar1;
        private PictureBox PictureBoxHSV;
        private Label label14;
        private Button button1;
    }
}