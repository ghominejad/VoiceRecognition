// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;

namespace SoundAnalysis.Filters
{
    // این فیلتر داده های مختلط را به مقدار بلندی صدا تبدیل میکند
    public class ToAmpFilter : IFreqFilter
    {



        public void ProcessData(double[] specData, double[] data)
        {
          //  double[] newData = new double[specData.Length / 2];
            double re, im, d;
            int i=0;
            for (int x = 0; x < specData.Length; x += 2)
            {
                re = specData[x];
                im = specData[x + 1];
                if (re != 0 || re != 0)                    
                    specData[i] = Math.Sqrt((re * re) + (im * im));
                else specData[i] = 0;

                i++;
            }
        }
    }
}
