// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;

namespace SoundAnalysis.Filters
{
    // جهت نرمال نمودن ویژه اسپکتروم جهت صدا بکار میرود
    // فعلا به نتیجه نرسیدیم
    public class SpectrumNormalizerFilter2 : IFreqFilter
    {
        enum FindMode { Upper, Lower };

        // اندازه تغییرات قله جهت نرمال سازی
        double DELTA = 0.5;

        double[] _spec = null;
        int max = 0;
        FindMode mode= FindMode.Upper;
        double oldVal = 0;
        double val = 0;

        double th = 0;

        double th_sense = 1.1;
        int partLength = 4;
        double  GetAverage(ref int index )
        {
            double avg = 0;

            int to = index + partLength;
            if (to > max) to = max ;
            
            while (index < to)
                avg += _spec[index++];

            avg /= partLength;

            return avg;
           
            
        }
        

        public void ProcessData(double[] spec, double[] data)
        {
            
         //   //double[] spec = new double[40] { 1, 2, 3, 4, 5, 6, 7, 8, 10, 100, 99.9, 99.8, 99.1, 200, 1, 2, 3, 1, 2, 3,
         //   // 1, 2, 3, 4, 5, 6, 7, 8, 10, 100, 99.9, 99.8, 99.1, 200, 1, 2, 3, 1, 2, 3};

         ////   return;
         //   double[] specx = new double[48] 
         //       { 5, 6, 7, 8, 9, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 2,3, 4, 5, 6, 7,8,9,10,
         //            1, 2, 3, 4, 5, 4, 3, 2, 1, 2, 3, 4, 3, 2, 1, 2, 3, 1, 2, 3,2,1,2,3};

            _spec = spec;


            List<int> list = new List<int>();
            List<double> listC = new List<double>();
       
            
            
            max=(spec.Length/2)-1;
            double th = 0;
            int i = 7;

            list.Add(7);
            listC.Add(0);

            // حرکت به طرف بالا جهت پیدا کردن بیشترین مقدار
        UPPER: // Find Upder
            if (i >= max) goto END;
            oldVal = val;
            val = GetAverage(ref i);


            if (val < oldVal)
                th = val * th_sense;      // 5% up of new value
            else                     // because of old condition
                if (val >= th) { list.Add(i); listC.Add(0);  goto LOWER; }


            goto UPPER;

            // حرکت به طرف پایین جهت پیدا کردن کمترین مقدار
        LOWER:// Find Lower
            if (i >= max) goto END;

            oldVal = val;
            val = GetAverage(ref i);

            if (val > oldVal)
                th = val * (1.0 / th_sense);    // 5% down of new value
            else                   // because of old condition
                if (val <= th) { list.Add(i); listC.Add(spec[i]); goto UPPER; }


            goto LOWER;



        END:

            bool m=false;
            
            for (int idx = 1; idx < list.Count; idx++)
            {
               int begin =0;
               // if (idx != 0)
                    begin = list[idx-1];

                
                for (int x = begin; x <= list[idx]; x++)
                {
                    spec[x] = listC [idx];//? 10000 : 0;
                }
                m=!m;

            }
         

            
        }
    }
}
