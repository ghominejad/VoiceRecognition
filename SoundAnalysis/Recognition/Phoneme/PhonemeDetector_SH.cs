// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;

namespace SoundAnalysis.Recognition.Phoneme
{
    // ا آ
    public class PhonemeDetector_SH : PhonemeDetectorBase
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

        public PhonemeDetector_SH(PhonemeDetector detector) : base(detector)
        {
            beg1 = (int)(4000 * FrequencyScale);
            end1 = (int)(6000 * FrequencyScale);

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


            rel1 = sum1 / sum2;
           // rel2 = sum2 / sum3;
            if (sum1 > _detector.NoiseVowel/3 && rel1 > 1.1)
                return 1;

            // There is no any chance
            return 0;
        }

        #endregion
    }
}
