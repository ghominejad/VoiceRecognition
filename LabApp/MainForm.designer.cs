namespace LabApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.پنجرههاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اسپکترومToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اسپکتوگرافToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رکوردToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSampleRateComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.اسپکترومToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.بزرگنماییفرکانسToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specZoomToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.بزرگنماییقدرتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ampZoomtoolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.فاصلهپیچToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.fFTTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.colorPalleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.پنجرههاToolStripMenuItem,
            this.رکوردToolStripMenuItem,
            this.اسپکترومToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(234, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // پنجرههاToolStripMenuItem
            // 
            this.پنجرههاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اسپکتوگرافToolStripMenuItem,
            this.اسپکترومToolStripMenuItem});
            this.پنجرههاToolStripMenuItem.Name = "پنجرههاToolStripMenuItem";
            this.پنجرههاToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.پنجرههاToolStripMenuItem.Text = "پنجره ها";
            // 
            // اسپکترومToolStripMenuItem
            // 
            this.اسپکترومToolStripMenuItem.CheckOnClick = true;
            this.اسپکترومToolStripMenuItem.Name = "اسپکترومToolStripMenuItem";
            this.اسپکترومToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.اسپکترومToolStripMenuItem.Text = "اسپکتروم";
            this.اسپکترومToolStripMenuItem.Click += new System.EventHandler(this.specToolStripMenuItem_Click);
            // 
            // اسپکتوگرافToolStripMenuItem
            // 
            this.اسپکتوگرافToolStripMenuItem.Name = "اسپکتوگرافToolStripMenuItem";
            this.اسپکتوگرافToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.اسپکتوگرافToolStripMenuItem.Text = "اسپکتروگرام";
            this.اسپکتوگرافToolStripMenuItem.Click += new System.EventHandler(this.SpecGraphoToolStripMenuItem_Click);
            // 
            // رکوردToolStripMenuItem
            // 
            this.رکوردToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listenToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.sampleRateToolStripMenuItem});
            this.رکوردToolStripMenuItem.Name = "رکوردToolStripMenuItem";
            this.رکوردToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.رکوردToolStripMenuItem.Text = "رکورد";
            // 
            // listenToolStripMenuItem
            // 
            this.listenToolStripMenuItem.Name = "listenToolStripMenuItem";
            this.listenToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.listenToolStripMenuItem.Text = "شنود";
            this.listenToolStripMenuItem.Click += new System.EventHandler(this.listenToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.stopToolStripMenuItem.Text = "متوقف";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // sampleRateToolStripMenuItem
            // 
            this.sampleRateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSampleRateComboBox});
            this.sampleRateToolStripMenuItem.Name = "sampleRateToolStripMenuItem";
            this.sampleRateToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sampleRateToolStripMenuItem.Text = "Sample Rate";
            // 
            // toolStripSampleRateComboBox
            // 
            this.toolStripSampleRateComboBox.Items.AddRange(new object[] {
            "384000",
            "192000",
            "96000",
            "48000",
            "44100",
            "32000",
            "22050",
            "16000"});
            this.toolStripSampleRateComboBox.Name = "toolStripSampleRateComboBox";
            this.toolStripSampleRateComboBox.Size = new System.Drawing.Size(152, 23);
            this.toolStripSampleRateComboBox.Text = "192000";
            this.toolStripSampleRateComboBox.Click += new System.EventHandler(this.toolStripSampleRateComboBox_Click);
            // 
            // اسپکترومToolStripMenuItem1
            // 
            this.اسپکترومToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بزرگنماییفرکانسToolStripMenuItem,
            this.بزرگنماییقدرتToolStripMenuItem,
            this.فاصلهپیچToolStripMenuItem,
            this.fFTTypeToolStripMenuItem,
            this.colorPalleteToolStripMenuItem});
            this.اسپکترومToolStripMenuItem1.Name = "اسپکترومToolStripMenuItem1";
            this.اسپکترومToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.اسپکترومToolStripMenuItem1.Text = "اسپکتروم";
            // 
            // بزرگنماییفرکانسToolStripMenuItem
            // 
            this.بزرگنماییفرکانسToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.specZoomToolStripMenuItem});
            this.بزرگنماییفرکانسToolStripMenuItem.Name = "بزرگنماییفرکانسToolStripMenuItem";
            this.بزرگنماییفرکانسToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.بزرگنماییفرکانسToolStripMenuItem.Text = "بزرگنمایی فرکانس";
            // 
            // specZoomToolStripMenuItem
            // 
            this.specZoomToolStripMenuItem.Items.AddRange(new object[] {
            "1x",
            "1.5x",
            "2x",
            "2.5",
            "3x",
            "4x",
            "5x",
            "6x",
            "7x",
            "8x",
            "9x",
            "10x"});
            this.specZoomToolStripMenuItem.Name = "specZoomToolStripMenuItem";
            this.specZoomToolStripMenuItem.Size = new System.Drawing.Size(152, 23);
            this.specZoomToolStripMenuItem.Text = "1x";
            this.specZoomToolStripMenuItem.SelectedIndexChanged += new System.EventHandler(this.specZoomToolStripMenuItem_SelectedIndexChanged);
            // 
            // بزرگنماییقدرتToolStripMenuItem
            // 
            this.بزرگنماییقدرتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ampZoomtoolStripComboBox});
            this.بزرگنماییقدرتToolStripMenuItem.Name = "بزرگنماییقدرتToolStripMenuItem";
            this.بزرگنماییقدرتToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.بزرگنماییقدرتToolStripMenuItem.Text = "بزرگنمایی قدرت";
            // 
            // ampZoomtoolStripComboBox
            // 
            this.ampZoomtoolStripComboBox.Items.AddRange(new object[] {
            "1x",
            "2x",
            "4x",
            "8x",
            "16x",
            "50x",
            "1000x"});
            this.ampZoomtoolStripComboBox.Name = "ampZoomtoolStripComboBox";
            this.ampZoomtoolStripComboBox.Size = new System.Drawing.Size(152, 23);
            this.ampZoomtoolStripComboBox.Text = "1x";
            this.ampZoomtoolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.ampZoomtoolStripComboBox_SelectedIndexChanged);
            // 
            // فاصلهپیچToolStripMenuItem
            // 
            this.فاصلهپیچToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.فاصلهپیچToolStripMenuItem.Name = "فاصلهپیچToolStripMenuItem";
            this.فاصلهپیچToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.فاصلهپیچToolStripMenuItem.Text = "FFT Length";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192",
            "16384",
            "32768"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(152, 23);
            this.toolStripComboBox1.Text = "1024";
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.FFTPeechIntervalComboBox1_SelectedIndexChanged);
            // 
            // fFTTypeToolStripMenuItem
            // 
            this.fFTTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.fFTTypeToolStripMenuItem.Name = "fFTTypeToolStripMenuItem";
            this.fFTTypeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.fFTTypeToolStripMenuItem.Text = "FFT Type";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "First",
            "Fast"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(152, 23);
            this.toolStripComboBox2.Text = "Fast";
            this.toolStripComboBox2.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox2_SelectedIndexChanged);
            // 
            // colorPalleteToolStripMenuItem
            // 
            this.colorPalleteToolStripMenuItem.Name = "colorPalleteToolStripMenuItem";
            this.colorPalleteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.colorPalleteToolStripMenuItem.Text = "پالت رنگ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Lab App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem پنجرههاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اسپکترومToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem رکوردToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اسپکترومToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem بزرگنماییفرکانسToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بزرگنماییقدرتToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox specZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox ampZoomtoolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem فاصلهپیچToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem اسپکتوگرافToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fFTTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem colorPalleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sampleRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripSampleRateComboBox;
        private System.Windows.Forms.Button button1;
    }
}

