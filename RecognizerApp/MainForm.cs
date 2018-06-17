// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SoundAnalysis.Recognition;
using SoundAnalysis.Filters;

namespace RecognizerApp
{
    public partial class MainForm : Form
    {

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Fields

        SoundInput input;
        PhonemeDetector phonemeDetector=new PhonemeDetector(1024, 192000);
        //NoiseAnalyserFilter noiseFilterSpeacking = new NoiseAnalyserFilter();
        IntensityAnalyserFilter noiseFilterSpeaking = new  IntensityAnalyserFilter();
        NoiseAnalyserFilter noiseFilterVowelChecker = new NoiseAnalyserFilter(6,44,1.3);

        SpectrumNormalizerFilter normalizerFilter = new SpectrumNormalizerFilter();
         TempoAnalyserFilter tempoFilter = new  TempoAnalyserFilter();
        long l = 0;
       
        #endregion

        #region Methods

        #endregion

        #region SoundEvents

        // دزیافت نمونه های صوتی از کارت صدا
        private void NewInputSamplesArrivedEvent(short[] data)
        {
            // تیدیل داده های نمونه به فرکانسهای صوتی
            FrequencyHelper.ProcessForierTransfer(data,
                New1024FourierFrequencyArrived,
                New8192FourierFrequencyArrived);

        }
       

        // دریافت فرکانسهای بدست آمده از نمونه های صوتی 1024 تایی
        // جهت تشخیص گفتار
        private void New1024FourierFrequencyArrived(double[] data, double[] samples)
        {
          
           
            // تشخیص حرف تلفظ شده از طریق داده های اسپکتروم
            if (noiseFilterSpeaking.IsSpeaking)
                phonemeDetector.Detect(data, tempoFilter.Tempo, noiseFilterSpeaking.NoiseLevel, noiseFilterVowelChecker.NoiseLevel);
      
            
                
            
            
        }

        int _tempo = 0;        
        // دریافت فرکانسهای بدست آمده از نمونه های صوتی 8192 تایی
        // جهت تشخیص زیر و بمی 
        private void New8192FourierFrequencyArrived(double[] data, double[] samples)
        {
            noiseFilterSpeaking.ProcessData(data, samples);
            noiseFilterVowelChecker.ProcessData(data, samples);

            // اگر حرف صدادار تلفظ شده بود 
            if (noiseFilterVowelChecker.IsSpeaking)
            {
                // اسپکتروم باید نرمال شود
                normalizerFilter.ProcessData(data, samples);
                // زیری و بمی با استفاده از اسپکتروم نرمال شده
                tempoFilter.ProcessData(data, samples);
            }
            else
                // حروف صدادار وجود ندارد و باید ریست شود
                tempoFilter.Reset();
        }
        #endregion
        
        #region FormEvents

        private void MainForm_Load(object sender, EventArgs e)
        {
            // جهت دریافت نمونه های صوتی صوتی از کارت صدا
            input = new SoundInput(NewInputSamplesArrivedEvent);

            // جهت تشخیص صدا
            phonemeDetector = PhonemeDetectorFactory.CreatePhonemeDetectors();
                
            // آغاز بکار شنود و سدیافت نمونه های صوتی
            input.Start();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // توقف شنود
            input.Stop();
        }

        #endregion

        private void tmDisplayPhoneme_Tick(object sender, EventArgs e)
        {
            if (noiseFilterVowelChecker.IsSpeaking )
            {
                lblSpeaker.Text = tempoFilter.GetCharachterTitle()+" "+ tempoFilter.Tempo;
                
            }

            if (!noiseFilterSpeaking.IsSpeaking)
            {
                lblPhonem.Text = "";
                return;
            }
            switch (phonemeDetector.DetectedPhoneme)
            {
                case PhonemeNames.AA: lblPhonem.Text = "اَ";
                    break;
                case PhonemeNames.AH: lblPhonem.Text = "آ";
                    break;

                case PhonemeNames.EE: lblPhonem.Text = "ی";
                    break;
                case PhonemeNames.EU: lblPhonem.Text = "و";
                    break;
                case PhonemeNames.S: lblPhonem.Text = "س";
                    break;
                case PhonemeNames.SH: lblPhonem.Text = "ش";
                    break;
                case PhonemeNames.EH: lblPhonem.Text = "اِ";
                    break;
                case PhonemeNames.Z: lblPhonem.Text = "ز";
                    break;
                case PhonemeNames.ZH: lblPhonem.Text = "ژ";
                    break;
            }
        }




       
    }
}
