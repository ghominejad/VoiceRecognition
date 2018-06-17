// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;

namespace SoundAnalysis.Filters
{
    // فعلا فقط نویز را تشخیص میدهد
    // فیلتر نویز 2 که دیگر از آن استفاده نمیکنیم نویز را  بر طرف میکند
    public class IntensityAnalyserFilter : IFreqFilter
    {
        double _th = 3;
        public IntensityAnalyserFilter(double th = 1.3)
        {
            _th = th;

            
        }
       
        #region Properties

        private double _avg = 0;
        private double _low = 10; // noise level       
        private double _high = 0;

        public double NoiseLevel
        {
            get { return _low; }
            set { _low = value; }
        }
        public double High
        {
            get { return _high; }
            set { _high = value; }
        }

        public double Avg
        {
            get { return _avg; }
            set { _avg = value; }
        }

        public bool IsSpeaking = false;

        #endregion

        #region Fields
   

      
        long counter = 0;
        int speakingCounter=0;

        // Checking minimum noise level 
        int minCount = 0;
        int maxCount = 0;
        double sum = 0;
        double minavg = 0;
        const int minRepeat = 10;
        int i = 0;
        #endregion
     
        
        public void ProcessData(double[] specData, double[] data)
        {
            // محاسبه میانگین کل
            for (i = 0, _avg = 0; i < data.Length; i++)
                _avg += Math.Abs(data[i]);           
            
            _avg = _avg / data.Length ;


            // محاسبه بیشترین حد
            if (_avg > _high)
                maxCount++;
            else maxCount = 0;

            // محاسبه کمترین حد
            if (_avg < _low)
            {
                //_minavg += _avg; _minCount++; 
                if (_avg > minavg)
                    minavg = _avg;
                minCount++;
            }
            else
            {
                minCount = 0;
                minavg = 0;
            }

            // اگر کمترین مقدار 10 بار تکرار شد
            if (minCount >= minRepeat)
            {
                _low = minavg; // (minavg / minRepeat) * 1.1;
                minavg = 0;
                minCount = 0;
            }

            // اگر کمترین مقدار 10 بار تکرار شد
            if (maxCount >= minRepeat)
                _high = _avg;

            //  اگر میانگین کنونی بیشتر از کمترین مقدار با محاسبه ضریب خطا بود 
            if (_avg > _low * (double)_th)
                speakingCounter++;         
            else
                speakingCounter--;
              
            // اگر تا سه بار محاسبه صببت اتفاق افتاد
            if (speakingCounter >= 3)
            {
                IsSpeaking = true;
                speakingCounter = 3;
            }

            if (speakingCounter <=0)
            {
                IsSpeaking = false;
                speakingCounter = 0;
            }

            // حدود هر 5 ثانیه برای بین 1024 و ریت 192000
            // دوباره حد اقل را محاسبه کن
            if (++counter > 1000/8)
            {
                // If the loudness lasts longer than 10000, probabely we have reached new noise level.
                // We need to wait until speaker silence
                if (IsSpeaking && counter < 10000/8)
                    return;

                // اینجا صحبت کننده صحبت نمیکند
                counter = 0;
                _high = _avg;
                minavg = _low;
                 _low = _low *2;//_avg * 1.2;
            }

            
       
        }
      
    }
}
