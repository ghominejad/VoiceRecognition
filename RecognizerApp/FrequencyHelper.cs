// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecognizerApp
{
    public class FrequencyHelper
    {
        public delegate void FrequencyDataReceiverDelegate(double[] spectrum, double[] samples);
        static SoundAnalysis.Filters.WindowFilter windowFilter1024 = new SoundAnalysis.Filters.WindowFilter(1024);
        static SoundAnalysis.Filters.WindowFilter windowFilter8192 = new SoundAnalysis.Filters.WindowFilter(8192);
        static double[] fSampleDataWnd1024 = null;
        static double[] fSampleDataWnd8192 = null;
        static double[] fSampleDataOrg = null;
        /// <summary>
        /// دریافت فرکانسهای داده نمونه
        /// </summary>
        /// <param name="sampleData">داده های نمونه</param>
        /// <param name="bin1024Callback">تابعی که داده های اسپکتروم 1024 تایی دریافت میکند</param>
        /// <param name="bin8192Callback">تابعی که داده های اسپکتروم 8192 تایی دریافت میکند</param>        
        public static void ProcessForierTransfer(short[] sampleData, 
            FrequencyDataReceiverDelegate bin1024Callback, 
            FrequencyDataReceiverDelegate bin8192Callback)
        {
            // اختصاص حافظه مناسب به فیلد ها
            CheckInit(sampleData.Length);
            
            // تبدیل داده های صحیح به داده های اعشاری کوچک جهت انجام محاسبات مثلثاتی
            for (int i = 0; i < sampleData.Length; i++)
                fSampleDataOrg[i] = fSampleDataWnd8192[i] = fSampleDataWnd1024[i] 
                    = ((double)sampleData[i]) / 32768.0;

            // اِعمال تابع پنجره به داده های اعشاری  
            windowFilter1024.ProcessData(null, fSampleDataWnd1024);
            windowFilter8192.ProcessData(null, fSampleDataWnd8192);


            // تقسیم داده ها به تکه های 8192 تایی و اِعمال تبدیل فوریه
            int count = sampleData.Length/8192;
            for (int pos = 0; pos < count; pos++)
            {
                // تبدیل فوریه 
                double[] spec8192 = SoundAnalysis.FourierTransform.Compute(fSampleDataWnd8192, 8192, pos);

                // داده های نمونه این رنج
                double[] samples8192 = new double[8192];
                Array.Copy(fSampleDataOrg, pos * 8192, samples8192, 0, 8192);
                
                bin8192Callback(spec8192, samples8192);

               //  تبدیل فوریه زیر مجموعه با بازه های کوچک تر 1024 تایی
                for (int subpos = 0; subpos < 8; subpos++)
                {
                    double[] spec1024 = SoundAnalysis.FourierTransform.Compute(fSampleDataWnd1024, 1024, (pos * 8) + subpos);
                    // داده های نمونه این رنج
                    double[] samples1024 = new double[8192];
                    Array.Copy(fSampleDataOrg, subpos * 1024, samples1024, 0, 1024);
                
                    bin1024Callback(spec1024, samples1024);

                }
            }

          
            

            

        }

        public static void CheckInit(int len)
        {
            if (fSampleDataOrg == null || fSampleDataOrg.Length != len)
            {
                fSampleDataOrg = new double[len];
                fSampleDataWnd8192 = new double[len];
                fSampleDataWnd1024 = new double[len];
            }

        }
        public static void ComputeFFT1024(double[] fSampleData)
        {

        }
    }
}
