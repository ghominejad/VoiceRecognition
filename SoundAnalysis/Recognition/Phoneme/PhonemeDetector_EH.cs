// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;

namespace SoundAnalysis.Recognition.Phoneme
{
    //
    public class PhonemeDetector_EH : PhonemeDetectorBase
    {
          
        #region Fields

        int beg1, end1;
        int beg2, end2;
        int beg3, end3;

        // Reletive between two are
        double rel1, rel2, rel3;

        int i = 0; // loop index

        double sum1 = 0, sum2 = 0, sum3=0, sum4=0;

        #endregion

        #region Constructors

        public PhonemeDetector_EH(PhonemeDetector detector)
            : base(detector)
        {
            beg1 = (int)(1440 * FrequencyScale);
            end1 = (int)(1687 * FrequencyScale);

            //Women
            beg2 = (int)(1687 * FrequencyScale);
            end2 = (int)(2250 * FrequencyScale);//2100

            //Women
            beg3 = (int)(2250 * FrequencyScale);
            end3 = (int)(2718 * FrequencyScale);

        }

        #endregion


        
        #region Meethods

        public override double Detect(double[] fftSamples)
        {
            sum1 = sum2 = sum3 = 0;


            for (i = beg1; i < end1; i++)
                sum1 += fftSamples[i];


            for (i = beg2; i < end2; i++)
                sum2 += fftSamples[i];

            for (i = beg3; i < end3; i++)
                sum3 += fftSamples[i];


            sum1 = sum1 / (end1 - beg1);
            sum2 = sum2 / (end2 - beg2);
            sum3 = sum3 / (end3 - beg3);

            if (sum2 > sum1)//  && sum2 >= sum3)
                return 1;


            // There is no any chance
            return 0;
        }

        #endregion
    }
}
