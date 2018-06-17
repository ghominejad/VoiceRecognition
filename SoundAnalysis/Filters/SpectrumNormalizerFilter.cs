// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;

namespace SoundAnalysis.Filters
{   
    // جهت نرمال نمودن اسپکتروم بکار میرود
    // جهت تشخیص زیر و بمی استفاده میکنیم
    public class SpectrumNormalizerFilter : IFreqFilter
    {
        // اندازه تغییرات قله جهت نرمال سازی
        double DELTA = 0.062;
        public void ProcessData(double[] spec, double[] data)
        {

            //double[] spec = new double[40] { 1, 2, 3, 4, 5, 6, 7, 8, 10, 100, 99.9, 99.8, 99.1, 200, 1, 2, 3, 1, 2, 3,
            // 1, 2, 3, 4, 5, 6, 7, 8, 10, 100, 99.9, 99.8, 99.1, 200, 1, 2, 3, 1, 2, 3};


            //double[] specx = new double[48] 
            //    { 1, 2, 3, 4, 5, 4, 3, 2, 1, 2, 3, 4, 3, 2, 1, 0,100, 1, 1, 2, 3,2,1,2,
            //         1, 2, 3, 4, 5, 4, 3, 2, 1, 2, 3, 4, 3, 2, 1, 2, 3, 1, 2, 3,2,1,2,3};

                  


            List<int> list = new List<int>();
            List<double> listVal = new List<double>();
            int iHead = 0;
            int oldi = 0;

            double val1=spec[0];
            int max=(spec.Length/2)-1;
            int i = max;
            //spec= spec.Reverse().ToArray();
            //if (spec[i] < spec[i + 1])
              //  goto ASC;
        DES:

            //DELTA = DELTA / (i / 100);
            //if (i > 50) DELTA = 1;
            //if (i > 100) DELTA = 0.5;


            val1 = spec[i];
    
            i--;
            if (i <= 0)
                goto END;

            if (spec[i] < val1)
            { val1 = spec[i]; goto DES; }
             oldi = i;
            while (spec[i] - val1 <= DELTA && i >0 && spec[--i] > val1) ;
               

            if (i <= 0)
                goto END;
            if (spec[i] - val1 > DELTA) { i = oldi; goto ASC; }
            if (spec[i] <= val1) goto DES;
            
        ASC:
            val1 = spec[i];
            iHead = i;
            
            i--;
            if (i <= 0)
                goto END;

            if (spec[i] > val1)
            { iHead = i; val1 = spec[i]; goto ASC; }

            oldi = i;
            while (val1 - spec[i] <= DELTA && i >0 && spec[--i] < val1) ;

            if (i <= 0) 
                goto END;
            if (val1 - spec[i] > DELTA)
            {
               // if (spec[i] > 0.00001)
                    list.Add(iHead);
                    listVal.Add(spec[iHead]);
                    i=oldi;
                goto DES;
            }
            if (spec[i] >= val1) goto ASC;

        END:
            for (int x = 0; x < max; x++)
                spec[x] = 0;
            for (int x = 0; x < list.Count; x++)
                spec[list[x]] = listVal[x];

            //list.Reverse();
            //listVal.Reverse();
            //for (int idx = 1; idx < list.Count; idx++)
            //{
            //    int begin = 0;
            //    // if (idx != 0)
            //    begin = list[idx - 1];


            //    for (int x = begin; x <= list[idx]; x++)
            //    {
            //        if (x >= begin + 5) break;
            //        //spec[x] = listC[idx];//? 10000 : 0;
            //        spec[x] = listVal[idx];
            //    }
            //    //m = !m;

            //}
           
            
        }
    }
}
