// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;

namespace SoundAnalysis.Recognition.Phoneme
{
    // ا آ
    public class PhonemeDetector_EU : PhonemeDetectorBase
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

        public PhonemeDetector_EU(PhonemeDetector detector)
            : base(detector)
        {
            beg1 = (int)(296 * FrequencyScale);
            end1 = (int)(657 * FrequencyScale);

            //Men
            beg2 = (int)(1600 * FrequencyScale);
            end2 = (int)(3300 * FrequencyScale);

            //Men
            beg3 = (int)(4300 * FrequencyScale);
            end3 = (int)(5600 * FrequencyScale);

        }

        #endregion


        
        #region Meethods
        double oldsum3 = 0;
        public override double Detect(double[] fftSamples)
        {
            double amp = 0; 
            sum1 = sum2 = sum3 = 0;
            sum3= fftSamples[beg3];


            for (i = 3; i < 10; i++)
                if (fftSamples[i] > amp) amp = fftSamples[i];

            for (i = beg1; i < end1; i++)
                sum1 += fftSamples[i];


            for (i = beg2; i < end2; i++)
                sum2 += fftSamples[i];

            for (i = beg3+1; i < end3; i++)
                if (sum3 < fftSamples[i])
                    sum3 = fftSamples[i];

            //if (oldsum3 != 0)
            //{
                
            //    sum3 = (sum3 + oldsum3) / 2;
                

            //}
            //oldsum3 = sum3;

            //sum2 *= 100;

            rel1 = (sum1 / (end1 - beg1)) / (sum2 / (end2 - beg2));

          //  3    0.5
          //  20

          // 50  2
          //  5   0.7


           // amp = ((amp *0.04)+0.5) /50;
            rel2 = (sum2 / (end2 - beg2)) / 0.005; //(sum3 / (end3 - beg3));
            rel2= ((5-rel2)/5)*100;
            
            if(rel2<0) rel2 =0;


            return (int)rel2;
            if (sum1 > 0.1 && rel1 < 4) //20 2.5 
            {
               // LastVowel = PhonemeNames.EU;
                return 1;

            }

            // There is no any chance
            return 0;
        }

        #endregion
    }
}
