// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;
using SoundAnalysis.Filters;

namespace SoundAnalysis.Recognition.Phoneme
{
    // ا آ
    public class PhonemeDetector_Vowel : PhonemeDetectorBase
    {
        #region Fields

        public NoiseAnalyserFilter levelR1;
    

        #endregion

        #region Constructors

        public PhonemeDetector_Vowel(PhonemeDetector detector)
            : base(detector)
        {
            beg1 = (int)(187 * FrequencyScale);//1500
            end1 = (int)(800 * FrequencyScale);

            beg2 = (int)(2000 * FrequencyScale);
            end2 = (int)(4000 * FrequencyScale);

            beg3 = (int)(2500 * FrequencyScale);
            end3 = (int)(2900 * FrequencyScale);

            beg4 = (int)(1220 * FrequencyScale);
            end4 = (int)(1600 * FrequencyScale);


            levelR1 = new NoiseAnalyserFilter(beg1, end1, 2.8);
        }

        #endregion


        
        #region Meethods

        public override double Detect(double[] fftSamples)
        {
            levelR1.ProcessData(fftSamples, null);
            if (levelR1.IsSpeaking)
                return 1;
            else return 0;
            //sum1 = sum2=sum3=sum4 = 0;

            //for (i = beg1; i <= end1; i++)
            //    sum1 += fftSamples[i];


            //for (i = beg2; i <= end2; i++)
            //   //if (sum2 < fftSamples[i])
            //        sum2 += fftSamples[i];

          
          
            //sum1= sum1 / (end1 - beg1);
            //sum2 = sum2 / (end2 - beg2);

            //if (sum2 > sum1 )
            //    return 100;
      
         

            // There is no any chance
            return 0;
        }

        #endregion
    }
}













     //sum1 = sum2=sum3=sum4 = 0;
     //       double max = 0;
     //       for (i = beg1; i <= end1; i++)
     //       {
     //           if (max < fftSamples[i])
     //               max = fftSamples[i];
     //           sum1 += fftSamples[i];
     //       }


     //       for (i = beg2; i <= end2; i++)
     //          //if (sum2 < fftSamples[i])
     //               sum2 += fftSamples[i];

     //       for (i = beg3; i < end3; i++)
     //               sum3 += fftSamples[i];
           
     //       for (i = beg4; i < end4; i++)
     //           sum4 += fftSamples[i];

            
     //       sum1 = sum1 / ((end1+1) - beg1);

     //       sum3= sum3 / (end3 - beg3);
     //       sum2 = sum2 / (end2 - beg2);

     //       sum4 = sum4 / (end4 - beg4);

     //       rel2 = sum3 / sum2;
     //       rel1 = max / sum2;
     //       rel3 = max / sum4;
     //       rel0 = sum1 / sum2;

            
     //       rel1=(rel1 - 8)*10;
     //       if (rel2 >= 0.91)
     //           rel1 *= 1.3;

     //       if (rel2 <= 0.31)
     //           rel1 *= 0.7;
     //       if (rel0 > 6)
     //           rel1 *= 0.5;

     //       if (rel1 > 100) rel1 = 100;
     //       if (rel1 <0) rel1 = 0;

     //       if (rel3 < 5)
     //       {
     //           rel1 /= 10;//(5 - rel3)*5;
     //       }
     //       else
     //       {

     //       }
     //      // rel2 =  sum3/sum2;

     //       return (int)rel1;

     //       if (sum1 > 0.1 && rel1 > 9)
     //       {
     //           LastVowel = VowlName.AH;
     //           //if (vcount >= 3)

     //           // It must be آ
     //           return 100;
     //       }
         

     //       // There is no any chance
     //       return 0;