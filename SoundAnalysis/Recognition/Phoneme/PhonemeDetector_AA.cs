// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;
using SoundAnalysis.Recognition.Phoneme;

namespace SoundAnalysis.Recognition.Phoneme
{
    // آ
    public class PhonemeDetector_AA : PhonemeDetectorBase
    {


        #region Constructors

        public PhonemeDetector_AA(PhonemeDetector detector)
            : base(detector)          
        {
            // آغاز و پایان منطقه اول
            beg1 = (int)(500 * FrequencyScale);
            end1 = (int)(1200 * FrequencyScale);

            // آغاز و پایان منطقه دوم
            beg2 = (int)(1400 * FrequencyScale);
            end2 = (int)(1600 * FrequencyScale);

        }

        #endregion


        
        #region Meethods

        public override double Detect(double[] fftSamples)
        {
            sum1 = sum2 = 0;

            // مجموع منطقه اول
            for (i = beg1; i < end1; i++)
                sum1 += fftSamples[i];


            // مجموع منطقه دوم
            for (i = beg2; i < end2; i++)
                sum2 += fftSamples[i];

            // محاسبه میانگین مناطق
            avg1 = sum1 / (end1- beg1);
            avg2 = sum2 / (end2 - beg2);

            // نسبت دو منطقه
            rel1 = sum1 / sum2;

            if (rel1 < 6 && avg1 > 0.05)
                return 1;

          

            // There is no any chance
            return 0;
        }

        #endregion
    }
}
