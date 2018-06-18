namespace RecognizerApp
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tmDisplayPhoneme = new System.Windows.Forms.Timer(this.components);
            this.lblPhonem = new System.Windows.Forms.Label();
            this.lblSpeaker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(12, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "لطفا یکی ار حرف های (  آ - اَ - اِ - ی - س - ش - ز - ژ ) را جهت شناسایی به صدا در" +
    " آورید";
            // 
            // tmDisplayPhoneme
            // 
            this.tmDisplayPhoneme.Enabled = true;
            this.tmDisplayPhoneme.Tick += new System.EventHandler(this.tmDisplayPhoneme_Tick);
            // 
            // lblPhonem
            // 
            this.lblPhonem.AutoSize = true;
            this.lblPhonem.Font = new System.Drawing.Font("Traditional Arabic", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPhonem.ForeColor = System.Drawing.Color.Green;
            this.lblPhonem.Location = new System.Drawing.Point(201, 65);
            this.lblPhonem.Name = "lblPhonem";
            this.lblPhonem.Size = new System.Drawing.Size(131, 199);
            this.lblPhonem.TabIndex = 0;
            this.lblPhonem.Text = "?";
            // 
            // lblSpeaker
            // 
            this.lblSpeaker.AutoSize = true;
            this.lblSpeaker.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSpeaker.Font = new System.Drawing.Font("Traditional Arabic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSpeaker.ForeColor = System.Drawing.Color.Olive;
            this.lblSpeaker.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblSpeaker.Location = new System.Drawing.Point(551, 0);
            this.lblSpeaker.Name = "lblSpeaker";
            this.lblSpeaker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSpeaker.Size = new System.Drawing.Size(42, 61);
            this.lblSpeaker.TabIndex = 3;
            this.lblSpeaker.Text = "?";
            this.lblSpeaker.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 345);
            this.Controls.Add(this.lblSpeaker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPhonem);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmDisplayPhoneme;
        private System.Windows.Forms.Label lblPhonem;
        private System.Windows.Forms.Label lblSpeaker;
    }
}

