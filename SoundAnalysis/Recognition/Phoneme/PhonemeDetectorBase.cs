// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;

namespace SoundAnalysis.Recognition
{
   
    public abstract class PhonemeDetectorBase : IPhonemeDetector
    {
         
  
        #region Fields

        // Regions
        protected int beg1, end1;
        protected int beg2, end2;
        protected int beg3, end3;
        protected int beg4, end4;

        // Sums
        protected double sum1 = 0, sum2 = 0, sum3, sum4 = 0;

        // Averages
        protected double avg1 = 0, avg2 = 0, avg3, avg4 = 0;

        // Reletive between two are
        protected double rel1, rel2, rel3;

        // loop index
        protected int i = 0;


        protected PhonemeDetector _detector = null;
        #endregion

        #region Properties
        public double FrequencyScale
        {
            get
            {
                return _detector.FrequencyScale;
            }
        }
        #endregion



        #region Constructors
        public PhonemeDetectorBase(PhonemeDetector detector)
        {
            _detector = detector;
        }
        #endregion
        #region Methods


        public abstract double Detect(double[] fftSamples);

        #endregion

    }
}
