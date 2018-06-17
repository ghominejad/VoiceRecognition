namespace LabApp
{
    partial class WndSpecGraph
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblFreqAmp = new System.Windows.Forms.Label();
            this.lblFreq = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cmpValues = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkEnergy = new System.Windows.Forms.CheckBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.cmdAmp = new System.Windows.Forms.ComboBox();
            this.tbBalance = new System.Windows.Forms.TrackBar();
            this.chkNoiseReducer = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWide = new System.Windows.Forms.TrackBar();
            this.cmbZoom = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAutoRefresh = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnManualRefresh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTalking = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTempo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblVowel = new System.Windows.Forms.Label();
            this.lblSH = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblEH = new System.Windows.Forms.Label();
            this.lblEE = new System.Windows.Forms.Label();
            this.lblAA = new System.Windows.Forms.Label();
            this.lblAH = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWide)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 689);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.lblTalking);
            this.panel1.Location = new System.Drawing.Point(703, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 689);
            this.panel1.TabIndex = 45;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.lblFreqAmp);
            this.groupBox4.Controls.Add(this.lblFreq);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(13, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(194, 150);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "اطلاعات";
            // 
            // lblFreqAmp
            // 
            this.lblFreqAmp.AutoSize = true;
            this.lblFreqAmp.Location = new System.Drawing.Point(17, 53);
            this.lblFreqAmp.Name = "lblFreqAmp";
            this.lblFreqAmp.Size = new System.Drawing.Size(41, 13);
            this.lblFreqAmp.TabIndex = 3;
            this.lblFreqAmp.Text = "label10";
            // 
            // lblFreq
            // 
            this.lblFreq.AutoSize = true;
            this.lblFreq.Location = new System.Drawing.Point(17, 30);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(39, 13);
            this.lblFreq.TabIndex = 2;
            this.lblFreq.Text = "lblFreq";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "مقدار:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "فرکانس:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.cmpValues);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(7, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(207, 110);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مقادیر اسپکتروم";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "مقادیر ردثف انتخاب شده";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(98, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "بازگشایی گرام";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnLoadGram_Click_1);
            // 
            // cmpValues
            // 
            this.cmpValues.FormattingEnabled = true;
            this.cmpValues.Location = new System.Drawing.Point(6, 40);
            this.cmpValues.Name = "cmpValues";
            this.cmpValues.Size = new System.Drawing.Size(194, 21);
            this.cmpValues.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "ذخیره گرام";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSaveGram_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkEnergy);
            this.groupBox2.Controls.Add(this.cmbFilter);
            this.groupBox2.Controls.Add(this.cmdAmp);
            this.groupBox2.Controls.Add(this.tbBalance);
            this.groupBox2.Controls.Add(this.chkNoiseReducer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbWide);
            this.groupBox2.Controls.Add(this.cmbZoom);
            this.groupBox2.Location = new System.Drawing.Point(7, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(200, 198);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اسپکترو گرام";
            // 
            // chkEnergy
            // 
            this.chkEnergy.AutoSize = true;
            this.chkEnergy.Location = new System.Drawing.Point(11, 164);
            this.chkEnergy.Name = "chkEnergy";
            this.chkEnergy.Size = new System.Drawing.Size(84, 17);
            this.chkEnergy.TabIndex = 25;
            this.chkEnergy.Text = "نمایش انرژی";
            this.chkEnergy.UseVisualStyleBackColor = true;
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Normal",
            "Round"});
            this.cmbFilter.Location = new System.Drawing.Point(22, 133);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbFilter.TabIndex = 24;
            this.cmbFilter.Text = "Normal";
            this.cmbFilter.Click += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // cmdAmp
            // 
            this.cmdAmp.FormattingEnabled = true;
            this.cmdAmp.Items.AddRange(new object[] {
            "1x",
            "2x",
            "3x",
            "4x",
            "5x",
            "6x",
            "7x",
            "8x",
            "9x",
            "10x",
            "20x",
            "30x",
            "40x",
            "50x",
            "100x",
            "120x",
            "150x",
            "170x",
            "200x",
            "250x",
            "300x",
            "350x",
            "400x",
            "450x",
            "500x",
            "1000x",
            "2000x",
            "3000x",
            "4000x",
            "5000x",
            "10000x"});
            this.cmdAmp.Location = new System.Drawing.Point(20, 106);
            this.cmdAmp.Name = "cmdAmp";
            this.cmdAmp.Size = new System.Drawing.Size(121, 21);
            this.cmdAmp.TabIndex = 23;
            this.cmdAmp.Text = "40x";
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(17, 76);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(121, 45);
            this.tbBalance.TabIndex = 22;
            this.tbBalance.Value = 4;
            // 
            // chkNoiseReducer
            // 
            this.chkNoiseReducer.AutoSize = true;
            this.chkNoiseReducer.Location = new System.Drawing.Point(98, 164);
            this.chkNoiseReducer.Name = "chkNoiseReducer";
            this.chkNoiseReducer.Size = new System.Drawing.Size(76, 17);
            this.chkNoiseReducer.TabIndex = 21;
            this.chkNoiseReducer.Text = "کاهنده نویز";
            this.chkNoiseReducer.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "فیلتر";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "قدرت";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "جابجایی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "پهنای رنگ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "بزرگنمایی";
            // 
            // tbWide
            // 
            this.tbWide.Location = new System.Drawing.Point(17, 52);
            this.tbWide.Name = "tbWide";
            this.tbWide.Size = new System.Drawing.Size(121, 45);
            this.tbWide.TabIndex = 13;
            this.tbWide.Value = 10;
            // 
            // cmbZoom
            // 
            this.cmbZoom.FormattingEnabled = true;
            this.cmbZoom.Items.AddRange(new object[] {
            "1x",
            "2x",
            "3x",
            "4x",
            "5x",
            "6x",
            "7x",
            "8x",
            "9x",
            "10x"});
            this.cmbZoom.Location = new System.Drawing.Point(17, 25);
            this.cmbZoom.Name = "cmbZoom";
            this.cmbZoom.Size = new System.Drawing.Size(112, 21);
            this.cmbZoom.TabIndex = 11;
            this.cmbZoom.Text = "4x";
            this.cmbZoom.SelectedIndexChanged += new System.EventHandler(this.cmbZoom_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAutoRefresh);
            this.groupBox3.Controls.Add(this.btnPause);
            this.groupBox3.Controls.Add(this.btnManualRefresh);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(7, 374);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(200, 77);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بروز رسانی";
            // 
            // btnAutoRefresh
            // 
            this.btnAutoRefresh.Location = new System.Drawing.Point(105, 19);
            this.btnAutoRefresh.Name = "btnAutoRefresh";
            this.btnAutoRefresh.Size = new System.Drawing.Size(80, 23);
            this.btnAutoRefresh.TabIndex = 26;
            this.btnAutoRefresh.Text = "خودکار";
            this.btnAutoRefresh.UseVisualStyleBackColor = true;
            this.btnAutoRefresh.Click += new System.EventHandler(this.btnAutoRefresh_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.Location = new System.Drawing.Point(105, 48);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(80, 23);
            this.btnPause.TabIndex = 23;
            this.btnPause.Text = "مکث";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnManualRefresh
            // 
            this.btnManualRefresh.Location = new System.Drawing.Point(22, 18);
            this.btnManualRefresh.Name = "btnManualRefresh";
            this.btnManualRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnManualRefresh.TabIndex = 25;
            this.btnManualRefresh.Text = "دستی";
            this.btnManualRefresh.UseVisualStyleBackColor = true;
            this.btnManualRefresh.Click += new System.EventHandler(this.btnManualRefresh_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(20, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "پاکسازی";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // lblTalking
            // 
            this.lblTalking.AutoSize = true;
            this.lblTalking.Location = new System.Drawing.Point(-33, 512);
            this.lblTalking.Name = "lblTalking";
            this.lblTalking.Size = new System.Drawing.Size(37, 13);
            this.lblTalking.TabIndex = 31;
            this.lblTalking.Text = "صحبت";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 695F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(918, 695);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Location = new System.Drawing.Point(476, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 689);
            this.panel2.TabIndex = 0;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(21, 96);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(11, 13);
            this.lblTempo.TabIndex = 86;
            this.lblTempo.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 85;
            this.label13.Text = "زیر و بمی";
            // 
            // lblVowel
            // 
            this.lblVowel.AutoSize = true;
            this.lblVowel.Location = new System.Drawing.Point(28, 72);
            this.lblVowel.Name = "lblVowel";
            this.lblVowel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVowel.Size = new System.Drawing.Size(19, 13);
            this.lblVowel.TabIndex = 84;
            this.lblVowel.Text = "EE";
            // 
            // lblSH
            // 
            this.lblSH.AutoSize = true;
            this.lblSH.Location = new System.Drawing.Point(28, 48);
            this.lblSH.Name = "lblSH";
            this.lblSH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSH.Size = new System.Drawing.Size(21, 13);
            this.lblSH.TabIndex = 83;
            this.lblSH.Text = "AA";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(27, 25);
            this.lblS.Name = "lblS";
            this.lblS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblS.Size = new System.Drawing.Size(21, 13);
            this.lblS.TabIndex = 82;
            this.lblS.Text = "AH";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(65, 72);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 81;
            this.label14.Text = "Vowel";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(65, 48);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 80;
            this.label15.Text = "SH";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(64, 25);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 79;
            this.label16.Text = "S";
            // 
            // lblEH
            // 
            this.lblEH.AutoSize = true;
            this.lblEH.Location = new System.Drawing.Point(116, 96);
            this.lblEH.Name = "lblEH";
            this.lblEH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEH.Size = new System.Drawing.Size(20, 13);
            this.lblEH.TabIndex = 78;
            this.lblEH.Text = "EH";
            // 
            // lblEE
            // 
            this.lblEE.AutoSize = true;
            this.lblEE.Location = new System.Drawing.Point(117, 72);
            this.lblEE.Name = "lblEE";
            this.lblEE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEE.Size = new System.Drawing.Size(19, 13);
            this.lblEE.TabIndex = 77;
            this.lblEE.Text = "EE";
            // 
            // lblAA
            // 
            this.lblAA.AutoSize = true;
            this.lblAA.Location = new System.Drawing.Point(117, 48);
            this.lblAA.Name = "lblAA";
            this.lblAA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAA.Size = new System.Drawing.Size(21, 13);
            this.lblAA.TabIndex = 76;
            this.lblAA.Text = "AA";
            // 
            // lblAH
            // 
            this.lblAH.AutoSize = true;
            this.lblAH.Location = new System.Drawing.Point(116, 25);
            this.lblAH.Name = "lblAH";
            this.lblAH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAH.Size = new System.Drawing.Size(21, 13);
            this.lblAH.TabIndex = 75;
            this.lblAH.Text = "AH";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(153, 96);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 74;
            this.label12.Text = "EH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 72);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 73;
            this.label11.Text = "EE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(154, 48);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "AA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(153, 25);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "AH";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.lblS);
            this.groupBox5.Controls.Add(this.lblTempo);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.lblVowel);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.lblSH);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.lblAH);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.lblAA);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.lblEE);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.lblEH);
            this.groupBox5.Location = new System.Drawing.Point(18, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(200, 168);
            this.groupBox5.TabIndex = 87;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "احتمال وجود حروف";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(5, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(172, 37);
            this.label17.TabIndex = 87;
            this.label17.Text = "روی ردیف های اسپکتروگرام در حالت مکث کلیک کنید";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(121, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "میانگین :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 93);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(121, 93);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "میانگین R1:";
            // 
            // WndSpecGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 695);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "WndSpecGraph";
            this.Text = "WndSpecGram";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WndSpecGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWide)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblFreqAmp;
        private System.Windows.Forms.Label lblFreq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmpValues;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkEnergy;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.ComboBox cmdAmp;
        private System.Windows.Forms.TrackBar tbBalance;
        private System.Windows.Forms.CheckBox chkNoiseReducer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbWide;
        private System.Windows.Forms.ComboBox cmbZoom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAutoRefresh;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnManualRefresh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTalking;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblVowel;
        private System.Windows.Forms.Label lblSH;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblEH;
        private System.Windows.Forms.Label lblEE;
        private System.Windows.Forms.Label lblAA;
        private System.Windows.Forms.Label lblAH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}