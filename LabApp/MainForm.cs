// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SoundCapture;
using SoundAnalysis.Filters;
using RecognizerApp;


namespace LabApp
{
    public partial class MainForm : Form
    {


        #region Fields

        SoundInput input;

        #endregion

        #region Methods


        #endregion

        #region SoundEvents

        // دزیافت نمونه های صوتی از کارت صدا
        private void NewInputSamplesArrivedEvent(short[] data)
        {
            // تیدیل داده های نمونه به فرکانسهای صوتی
            FrequencyUtils.ProcessForierTransfer(data,
                NewFourierFrequencyArrived, (int)MainForm.FftPeechInterval
                );            

        }


        // دریافت فرکانسهای بدست آمده از نمونه های صوتی 1024 تایی
        // جهت تشخیص گفتار
        private void NewFourierFrequencyArrived(double[] data, double[]  samples)
        {

   


            if (wndSpec != null && !wndSpec.IsDisposed)
                wndSpec.ProcessData(data, samples);

            //if (wndTuner != null && !wndTuner.IsDisposed)
            //    wndTuner.ProcessData(data, null);

            if (wndSpecGraph != null && !wndSpecGraph.IsDisposed)
                wndSpecGraph.ProcessData(data, samples);


        }


        #endregion


        #region Fields and properties

        
        static WndSpec wndSpec = null;
      //  static WndTuner wndTuner = null;
        static WndSpecGraph wndSpecGraph = null;
        public static float FftPeechInterval = 1024;
        public static string FftType = "Fast";
        public static int SampleRate = 192000;

    
        
        bool isListenning = false;


        public bool IsListenning
        {
            get { return isListenning; }
        }



        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            
        }

        #endregion

        #region Methods
        private void StopListenning()
        {
            isListenning = false;
            input.Stop();
        }

        private void StartListenning()
        {
            isListenning = true;
            input.Start();
            UpdateListenStopButtons();
        }

        private void UpdateListenStopButtons()
        {
            listenToolStripMenuItem.Enabled = !isListenning;
            stopToolStripMenuItem.Enabled = isListenning;
            
        }
     
    
     
        #endregion

        #region events


        private void MainForm_Load(object sender, EventArgs e)
        {

            // جهت دریافت نمونه های صوتی صوتی از کارت صدا
            input = new SoundInput(NewInputSamplesArrivedEvent);

          

            // آغاز بکار شنود و سدیافت نمونه های صوتی
            StartListenning();

            // بارگزاری طیف رنگ های اسپکتوگراوم
            GramUtils.LoadPalettes(colorPalleteToolStripMenuItem);
            
            
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsListenning)
            {
                StopListenning();
            }
        }


    
        private void listenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartListenning();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopListenning();
            UpdateListenStopButtons();
        }

 

        private void specToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (wndSpec == null || wndSpec.IsDisposed)
                wndSpec = new WndSpec();
            
            wndSpec.Show();
        }
        private void SpecGraphoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wndSpecGraph==null || wndSpecGraph.IsDisposed)
                wndSpecGraph = new WndSpecGraph();

            wndSpecGraph.Show();
        }

     
        private void ampZoomtoolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            float val = float.Parse(((ToolStripComboBox)sender).SelectedItem.ToString().Replace("x", ""));
            wndSpec.YScale = val;

           // WndSpec.
        }

        private void specZoomToolStripMenuItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            float val = float.Parse(((ToolStripComboBox)sender).SelectedItem.ToString().Replace("x", ""));
            wndSpec.XScale = val;
            

        }

          private void FFTPeechIntervalComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FftPeechInterval = float.Parse(((ToolStripComboBox)sender).SelectedItem.ToString().Replace("ms", ""));
            
        }
          private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
          {

              FftType = ((ToolStripComboBox)sender).SelectedItem.ToString();

          }
          private void toolStripSampleRateComboBox_Click(object sender, EventArgs e)
          {
              SampleRate = int.Parse(toolStripSampleRateComboBox.SelectedItem.ToString());
          }
        #endregion

          private void button1_Click(object sender, EventArgs e)
          {


              int i = 0;
              while (true)
              {
                  i++;
                  new SpectrumNormalizerFilter().ProcessData(null, null);
                  if (i > 100)
                      break;
              }

          }

          

        

       
      

      
    }
}
