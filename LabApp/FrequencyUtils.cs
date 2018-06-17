// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecognizerApp
{
    public class FrequencyUtils
    {
        public delegate void FrequencyDataReceiverDelegate(double[] spectrum, double[] samples);
        
        /// <summary>
        /// دریافت فرکانسهای داده نمونه
        /// </summary>
        /// <param name="sampleData">داده های نمونه</param>
        /// <param name="bin1024Callback">تابعی که داده های اسپکتروم 1024 تایی دریافت میکند</param>
        /// <param name="bin8192Callback">تابعی که داده های اسپکتروم 8192 تایی دریافت میکند</param>        
        public static void ProcessForierTransfer(short[] sampleData, 
            FrequencyDataReceiverDelegate Callback, int bin)
            
        {

            // تبدیل داده های صحیح به داده های اعشاری کوچک جهت انجام محاسبات مثلثاتی
            double[] fSampleData = new double[sampleData.Length];
            double[] fSampleDataOriginal = new double[sampleData.Length];
            for (int i = 0; i < sampleData.Length; i++)
                fSampleDataOriginal[i]=fSampleData[i] = ((double)sampleData[i]) / 32768.0;

            // اِعمال تابع پنجره به داده های اعشاری  
            SoundAnalysis.Filters.WindowFilter windowFilter = new SoundAnalysis.Filters.WindowFilter(bin);
            windowFilter.ProcessData(null, fSampleData);


            // تقسیم داده ها به تکه های 8192 تایی و اِعمال تبدیل فوریه
            int count = sampleData.Length / bin;
            for (int pos = 0; pos < count; pos++)
            {
                // تبدیل فوریه 
                double[] spec = SoundAnalysis.FourierTransform.Compute(fSampleData, bin, pos);
                double[] samples = new double[bin];
                Array.Copy(fSampleDataOriginal, pos * bin, samples, 0, bin);
                Callback(spec, samples);
          
            }

          
            

            

        }


        public static void ComputeFFT1024(double[] fSampleData)
        {

        }
    }
}
