namespace LabApp
{
    partial class WndSpec
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
            this.spectrumViewer1 = new LabApp.SpectrumViewer(this.components);
            this.SuspendLayout();
            // 
            // spectrumViewer1
            // 
            this.spectrumViewer1.AutoSize = true;
            this.spectrumViewer1.BackColor = System.Drawing.Color.White;
            this.spectrumViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spectrumViewer1.Location = new System.Drawing.Point(0, -1);
            this.spectrumViewer1.Name = "spectrumViewer1";
            this.spectrumViewer1.Size = new System.Drawing.Size(933, 518);
            this.spectrumViewer1.SpecData = null;
            this.spectrumViewer1.TabIndex = 10;
            this.spectrumViewer1.XScale = 1F;
            this.spectrumViewer1.YScale = 1F;
            // 
            // WndSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 414);
            this.Controls.Add(this.spectrumViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "WndSpec";
            this.Text = "wndSpec";
            this.Resize += new System.EventHandler(this.WndSpec_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SpectrumViewer spectrumViewer1;
    }
}