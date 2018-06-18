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
using SoundAnalysis;
using SoundAnalysis.Recognition.Phoneme;
using SoundAnalysis.Recognition;
using SoundAnalysis.Filters;
namespace LabApp
{
    public partial class WndSpecGraph : Form, IFreqFilter
    {
        public WndSpecGraph()
        {
            InitializeComponent();
        }


        #region Fields
        
        int mousex = 0, mousey = 0;
        float zoom = 4;
        Bitmap bmp = null;
        Graphics g;
        bool pause = false;
        bool autoRefresh = false;
        bool loaded = false;
        #endregion

        #region Methods




        TempoAnalyserFilter tempoFilter = new TempoAnalyserFilter();
        NoiseAnalyserFilter noiseFilterVowelChecker = new NoiseAnalyserFilter(7, 50, 3);
        void CheckVowelNew2(int row)
        {
            int rep = 1;
            detector.Detect(GramUtils.Archive[row], 0, noiseAnalyser.NoiseLevel, noiseAnalyser.NoiseLevel);
            lblAH.Text = detector.Inf.pAH.ToString() ;
            lblAA.Text = detector.Inf.pAA.ToString();
            lblEE.Text = detector.Inf.pEE.ToString();
            lblEH.Text = detector.Inf.pEH.ToString();
            lblS.Text = detector.Inf.pS.ToString();
            lblSH.Text = detector.Inf.pSH.ToString();
            
            lblVowel.Text = detector.Inf.pVowel.ToString();
            if (GramUtils.RoundedArchive.Count >= row)
            {
                if(noiseFilterVowelChecker.IsSpeaking)
                    tempoFilter.ProcessData(GramUtils.RoundedArchive[row], null);
            }
            
            lblTempo.Text = tempoFilter.Tempo.ToString();

        }




     

        // Displays given row in combo box 
        void DisplayArchiveItem(int row)
        {
            if (row < 0)
                return;

            //   int row = Archive.Count - 1;
            cmpValues.Items.Clear();
            // double re, im, d;
            for (int x = 0; x < GramUtils.Archive[row].Length / 2; x++)
            {
                cmpValues.Items
                    .Add(GramUtils.Archive[row][x]);
            }
        }


        List<bool> TalkArchive = new List<bool>();
       

        // Loads data into archive
        void ArchiveData(double[] specData, double[] samples)
        {       
            
           
            if (noiseAnalyser.IsSpeaking)
                lblTalking.ForeColor = Color.Red;
            else lblTalking.ForeColor = Color.Gray;


            GramUtils.NormalArchive.Add(specData);
            GramUtils.SampleArchive.Add(samples);
            TalkArchive.Add(noiseAnalyser.IsSpeaking);

            var roundedRow = (double[])specData.Clone();

            new SpectrumNormalizerFilter().ProcessData(roundedRow, null);
            noiseFilterVowelChecker.ProcessData(roundedRow, null);

            GramUtils.RoundedArchive.Add(roundedRow);

                

        }

               PhonemeDetector detector=null;
               NoiseAnalyserFilter noiseAnalyser = new NoiseAnalyserFilter();
               NoiseReductionFilter noiseReduction = new NoiseReductionFilter();
               IntensityAnalyserFilter IntensityAnalyser = new IntensityAnalyserFilter();
                            
        //NoiseAnalyserFilter noiseAnalyser = new NoiseAnalyserFilter();
        

        public delegate void SpecProcessorFunc(double[] specData);
       
        // read time spectrum processor - iterface of this form
        public void ProcessData(double[] specData, double[] samples)
        {
            if (pause)
                return;
            //if (InvokeRequired)
             //   BeginInvoke(new SpecProcessorFunc(ArchiveData), new object[] { specData });
            //else

            if(chkNoiseReducer.Checked)
                noiseReduction.ProcessData(specData, samples);

            noiseAnalyser.ProcessData(specData, samples);
            IntensityAnalyser.ProcessData(specData, samples);
            // تشخیص حرف تلفظ شده از طریق داده های اسپکتروم
            if (noiseAnalyser.IsSpeaking)
                detector.Detect(specData, 0,noiseAnalyser.NoiseLevel, noiseAnalyser.NoiseLevel);

            ArchiveData(specData, samples);
            
            
        }


        void DrawGram()
        {
            zoom = float.Parse(cmbZoom.SelectedItem.ToString().Replace("x", ""));
            int amp = int.Parse(cmdAmp.SelectedItem.ToString().Replace("x", ""));
            GramUtils.DrawGram((int)zoom, amp, tbBalance.Value, tbWide.Value, bmp);                

        }
        void DrawIntensity()
        {
            zoom = float.Parse(cmbZoom.SelectedItem.ToString().Replace("x", ""));
            GramUtils.DrawIntensity((int)zoom, bmp, IntensityAnalyser);
            

        }
        #endregion


        #region Events
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (bmp == null)
            {
                bmp = new Bitmap(512, 900, e.Graphics);
               g = Graphics.FromImage(bmp);
              // g.DrawLine(Pens.Blue, 10, 10, 100, 100);
               pictureBox1.Image = bmp;
            }
           // g.DrawLine(Pens.Blue, 100, 100, 500, 540);
        }
      
       

       
        private void timer1_Tick(object sender, EventArgs e)
        {
           
                //CheckVowelNew(GramUtils.Archive.Count - 1);


            if (!autoRefresh)
                return;
            if (loaded && GramUtils.Archive.Count > 0)
            {

                DrawGram();

                //pictureBox1.Image = bmp;
                pictureBox1.Invalidate();
            }

            if (GramUtils.Archive.Count > 0)
            {

                if (!noiseAnalyser.IsSpeaking)
                {
                    //lblPhonem.Text = "";
                    return;
                }
                //switch (detector.DetectedPhoneme)
                //{
                //    case PhonemeNames.AA: lblPhonem.Text = "اَ";
                //        break;
                //    case PhonemeNames.AH: lblPhonem.Text = "آ";
                //        break;
                //    case PhonemeNames.EE: lblPhonem.Text = "ی";
                //        break;
                //    case PhonemeNames.EU: lblPhonem.Text = "و";
                //        break;
                //    case PhonemeNames.S: lblPhonem.Text = "س";
                //        break;
                //    case PhonemeNames.SH: lblPhonem.Text = "ش";
                //        break;
                //    case PhonemeNames.EH: lblPhonem.Text = "اِ";
                //        break;
                //    case PhonemeNames.Z: lblPhonem.Text = "ز";
                //        break;
                //    case PhonemeNames.ZH: lblPhonem.Text = "ژ";
                //        break;
                //}
            }

        }

      
        private void WndSpecGraph_Load(object sender, EventArgs e)
        {
            // جهت تشخیص صدا
            detector = PhonemeDetectorFactory.CreatePhonemeDetectors();

            loaded = true;
            autoRefresh = true;
            GramUtils.Archive = GramUtils.NormalArchive;
        }



       
        private void btnLoad_Click(object sender, EventArgs e)
        {
            DisplayArchiveItem(GramUtils.Archive.Count - 1);

        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedItem.ToString() == "Round")
                GramUtils.Archive = GramUtils.RoundedArchive;
            else
                GramUtils.Archive = GramUtils.NormalArchive;
        }

        private void btnAutoRefresh_Click(object sender, EventArgs e)
        {
            autoRefresh = true;

        }

        private void btnManualRefresh_Click(object sender, EventArgs e)
        {
            autoRefresh = false;
            DrawGram();
            if (chkEnergy.Checked)
                DrawIntensity();            
                
            pictureBox1.Invalidate();
        }


        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            mousex = e.X;
            mousey =e.Y;

            int bin = (int)((double)mousex / zoom);
            int posy = (int)((double)mousey / zoom);
            if (GramUtils.Archive.Count > posy && bin < MainForm.FftPeechInterval)
            {
                lblFreqAmp.Text = GramUtils.Archive[GramUtils.Archive.Count - (posy + 1)][bin].ToString();
                lblFreq.Text = (((MainForm.SampleRate/2) / MainForm.FftPeechInterval) * bin).ToString();
            }

        }

        private void btnSaveGram_Click_1(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Spectogram (*.gram)|*.gram";
            sfd.ShowDialog();
            
            if(!string.IsNullOrEmpty(sfd.FileName) )
            {
                int zoom = int.Parse(cmbZoom.SelectedItem.ToString().Replace("x", ""));
                int amp = int.Parse(cmdAmp.SelectedItem.ToString().Replace("x", ""));
                int widw = tbWide.Value ;
                 int balance = tbBalance.Value;
                int filter= cmbFilter.SelectedIndex;

                GramUtils.SaveGram(sfd.FileName, zoom,  widw, balance, amp, filter);
            }
        }

        private void btnLoadGram_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog sfd = new OpenFileDialog();
            sfd.Filter = "Spectogram (*.gram)|*.gram";
            sfd.ShowDialog();
            if (!string.IsNullOrEmpty(sfd.FileName))
            {
                int zoom =0 ;
                int amp = 0;
                int widw = 0;
                int balance = 0;
                int filter = 0;

                GramUtils.LoadGram(sfd.FileName, ref zoom, ref widw, ref balance, ref amp, ref filter);
                cmbZoom.SelectedItem = zoom.ToString()+"x";
                cmbFilter.SelectedIndex = filter;
                tbWide.Value = widw;
                tbBalance.Value = balance;
                cmdAmp.SelectedItem = amp.ToString() + "x";
                cmbFilter_SelectedIndexChanged(null, null);
                /*int amp = int.Parse(cmdAmp.SelectedItem.ToString().Replace("x", ""));
                int widw = tbWide.Value;
                int balance = tbBalance.Value;
                int filter = cmbFilter.SelectedIndex;*/
            }
        }

     



        private void cmbZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            zoom = float.Parse((sender as ComboBox).SelectedItem.ToString().Replace("x", ""));
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            pause = !pause;

            btnPause.Text = pause ? "رکورد" : "مکث";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            GramUtils.ClearData();
            TalkArchive.Clear();

        }
        #endregion

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            zoom = float.Parse(cmbZoom.SelectedItem.ToString().Replace("x", ""));
            int posx = (int)((double)e.X / zoom);
            int posy = (int)((double)e.Y / zoom);

            DisplayArchiveItem(GramUtils.Archive.Count - (posy + 1));
            if (cmpValues.Items.Count > posx)
                cmpValues.SelectedIndex = posx;


            //CheckVowel_O(Archive.Count - (posy + 1));
            //detecor.Detect(Archive[Archive.Count - (posy + 1)], 100);
            CheckVowelNew2(GramUtils.Archive.Count - (posy + 1));
        }



    }
}
