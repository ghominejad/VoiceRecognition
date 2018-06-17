// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;

namespace SoundAnalysis.Recognition.Phoneme
{
    // ا آ
    public class PhonemeDetector_Consonant : PhonemeDetectorBase
    {


        #region Constructors

        public PhonemeDetector_Consonant(PhonemeDetector detector)
            : base(detector)
        {
            beg1 = (int)(1600 * FrequencyScale);//1500
            end1 = (int)(2000 * FrequencyScale);

            beg2 = (int)(2000 * FrequencyScale);
            end2 = (int)(4000 * FrequencyScale);

        }

        #endregion


        
        #region Meethods

        public override double Detect(double[] fftSamples)
        {
            sum1 = sum2=sum3=sum4 = 0;

            for (i = beg1; i <= end1; i++)
                sum1 += fftSamples[i];


            for (i = beg2; i <= end2; i++)
                    sum2 += fftSamples[i];

          
          
            sum1= sum1 / (end1 - beg1);
            sum2 = sum2 / (end2 - beg2);

            if (sum2 > sum1 )
                return 1;
      
         

            // There is no any chance
            return 0;
        }

        #endregion
    }
}










