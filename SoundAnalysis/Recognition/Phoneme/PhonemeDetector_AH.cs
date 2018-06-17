// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;

namespace SoundAnalysis.Recognition.Phoneme
{
    public class PhonemeDetector_AH : PhonemeDetectorBase
    {  
        // سازنده ملاس
        public PhonemeDetector_AH(PhonemeDetector detector)
            : base(detector)
        {
            // آغاز و پایان منطقه اول
            beg1 = (int)(842 * FrequencyScale); 
            end1 = (int)(1200 * FrequencyScale); 

            // آغاز و پایان منطقه دوم
            beg2 = (int)(1400 * FrequencyScale);
            end2 = (int)(1600 * FrequencyScale);

        }

        // متود تشخیص
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
            avg1 = sum1 / (end1 - beg1);
            avg2 = sum2 / (end2 - beg2);

            // نسبت دو منطقه
            rel1 = sum1 / sum2;
           
           
            if (rel1 > 4)
                return 1;
            else
                return 0;
        }
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