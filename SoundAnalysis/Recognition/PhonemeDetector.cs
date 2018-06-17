// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;
using SoundAnalysis.Filters;

namespace SoundAnalysis.Recognition
{
    public enum PhonemeNames { None, Vowel, Consonant, AA, AH, EU, EH, O, EE, S, SH, Z, ZH, H, KH };
    
   
   
   
    public class PhonemeDetector
    {
         
  
        #region Fields

      
        public  double FrequencyScale = 0;
        private int vcount = 0;
        public PhonemeInfo Inf=new PhonemeInfo();
        public PhonemeNames DetectedPhoneme = PhonemeNames.None;
        PhonemeChecker checker = new PhonemeChecker();
       

        #endregion


        #region Constrators


        public PhonemeDetector(int fftIntercal, int sampleRate)
        {
            FftInterval = fftIntercal;
            SampleRate = sampleRate;
        }
       

        #endregion

        #region Indexer
        public PhonemeDetectorBase this[PhonemeNames vowelName]
        {
            get { return VowelDetectors[vowelName]; }

        }
        #endregion

        #region propereties

        private PhonemeNames _lastVowel = PhonemeNames.None;
       
        public PhonemeNames LastVowel
        {
            get { return _lastVowel; }
            set
            {
                if (_lastVowel != value)
                {
                    vcount--;
                    if (vcount > 1) vcount = 1;
                    if (vcount >= 0) return;
                    if (vcount < 0) vcount = 0;
                }
                else
                    vcount++;
                _lastVowel = value;
            }
        }

    

        Dictionary<PhonemeNames, PhonemeDetectorBase> _vowelDetectors = new Dictionary<PhonemeNames, PhonemeDetectorBase>();

        public  Dictionary<PhonemeNames, PhonemeDetectorBase> VowelDetectors
        {
            get { return _vowelDetectors; }
            set { _vowelDetectors = value; }
        }



        private  int _fftInterval = 0;

        public  int FftInterval
        {
            get { return _fftInterval; }
            set
            {
                _fftInterval = value;
                FrequencyScale = ((double)(_fftInterval * 2) / (double)_sampleRate);
            }
        }
        private int _sampleRate = 0;

        public int SampleRate
        {
            get { return _sampleRate; }
            set
            {
                _sampleRate = value;
                FrequencyScale = ((double)(_fftInterval * 2) / (double)_sampleRate);
            }
        }
        double _tempo = 0;

        public double Tempo
        {
            get { return _tempo; }
        }
        double _noiseVowel = 0;

        public double NoiseVowel
        {
            get { return _noiseVowel; }
        }
        double _noise = 0;

        public double Noise
        {
            get { return _noise; }
        }
        #endregion


        #region Methods



     

        public virtual int Detect(double[] fftSamples, double tempo, double noise, double noiseVowel)
        {   
            _noise = noise;
            _tempo = tempo;
            _noiseVowel = noiseVowel;

            Inf.pVowel = tempo != 0? 1:0 ; 
            Inf.pAH = this[PhonemeNames.AH].Detect(fftSamples);
            Inf.pEH = this[PhonemeNames.EH].Detect(fftSamples);
            Inf.pAA = this[PhonemeNames.AA].Detect(fftSamples);
            Inf.pEE = this[PhonemeNames.EE].Detect(fftSamples);
            Inf.pS = this[PhonemeNames.S].Detect(fftSamples);

            Inf.pSH = this[PhonemeNames.SH].Detect(fftSamples);

            DetectedPhoneme = checker.Method2(Inf);

            return 0;
        }

      



        #endregion


    }
}
