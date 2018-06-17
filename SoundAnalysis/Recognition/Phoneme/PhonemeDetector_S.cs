// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;

namespace SoundAnalysis.Recognition.Phoneme
{
    // ا آ
    public class PhonemeDetector_S : PhonemeDetectorBase
    {
        

        #region Constructors

        public PhonemeDetector_S(PhonemeDetector detector)
            : base(detector)
        {
            beg1 = (int)(3500 * FrequencyScale);
            end1 = (int)(4000 * FrequencyScale);

            //Men
            beg2 = (int)(6000 * FrequencyScale);
            end2 = (int)(10000 * FrequencyScale);

            //Men
            beg3 = (int)(14000 * FrequencyScale);
            end3 = (int)(16000 * FrequencyScale);


        }

        #endregion
                
        #region Meethods

        public override double Detect(double[] fftSamples)
        {
            sum1 = sum2 = sum3= 0;
           
            for (i = beg1; i < end1; i++)
                sum1 += fftSamples[i];


            for (i = beg2; i < end2; i++)
                sum2 += fftSamples[i];

            for (i = beg3; i < end3; i++)
                sum3 += fftSamples[i];

            sum1 = sum1 / (end1 - beg1);
            sum2 = sum2 / (end2 - beg2);
            sum3 = sum3 / (end3 - beg3);

            rel1 =sum2/ sum1;
            rel2 = sum2/sum3;
            if (sum2 > _detector.NoiseVowel/2 && rel1 > 1 && rel2 > 1)
                return 1;

            // There is no any chance
            return 0;
        }

        #endregion
    }
    
}
