// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;

namespace SoundAnalysis.Recognition.Phoneme
{
    // ا آ
    public class PhonemeDetector_O : PhonemeDetectorBase
    {
        #region Fields
        int beg1;// = (int)(650 * FrequencyScale);
        int end1;// = (int)(1200 * FrequencyScale);

        // Men
        //int beg2 = (int)(1500 * FreuencyScale);
        //int end2 = (int)(1700 * FreuencyScale);

        //Women
        int beg2;// = (int)(1800 * FrequencyScale);
        int end2;// = (int)(2000 * FrequencyScale);

        int beg3;// = (int)(1800 * FrequencyScale);
        int end3;// = (int)(2000 * FrequencyScale);

        // Reletive between two are
        double rel1;
        double rel2;

        int i = 0; // loop index

        double sum1 = 0, sum2 = 0, sum3 = 0;

        #endregion

        #region Constructors

        public PhonemeDetector_O(PhonemeDetector detector)
            : base(detector)
        {
            beg1 = (int)(296 * FrequencyScale);
            end1 = (int)(657 * FrequencyScale);

            //Men
            beg2 = (int)(657 * FrequencyScale);
            end2 = (int)(1200 * FrequencyScale);

            //Men
            beg3 = (int)(500 * FrequencyScale);
            end3 = (int)(4100 * FrequencyScale);


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

            //sum2 *= 100;

            rel1 = (sum1 / (end1 - beg1)) / (sum2 / (end2 - beg2));


            rel2 = (sum1 / (end1 - beg1)) / (sum3 / (end3 - beg3));



            if (sum1 > 0.1 && rel1 >= 5) //20 2.5 
            {
               // LastVowel = PhonemeNames.O;
                return 1;

            }


            // There is no any chance
            return 0;
        }

        #endregion
    }
}
