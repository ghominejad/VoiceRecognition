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
    public class NoiseAnalyserFilter : IFreqFilter
    {
        public NoiseAnalyserFilter(int startFreq = 0, int endFreq = 0, double th = 2.5)
        {
            _startBin = startFreq;
            _endBin = endFreq;
            _th = th;
            
            
        }

        #region Properties
        private double _avg = 0;

        public double Avg
        {
            get { return _avg; }
            set { _avg = value; }
        }
        private double _low = 10;

        public double NoiseLevel
        {
            get { return _low; }
            set { _low = value; }
        }
        private double _high = 0;

        public double High
        {
            get { return _high; }
            set { _high = value; }
        }
        public bool IsSpeaking = false;

        #endregion

        #region Fields

        int _startBin = 0;
        int _endBin = 0;
        double _th = 3;

 
        long _counter = 0;
        int _speakingCounter=0;

        // Checking minimum noise level 
        int _minCount = 0;
        int _maxCount = 0;

        double _sum = 0;
        double _minavg = 0;
        const int _minRepeat = 10;
        int i = 0;
        #endregion

        public void ProcessData(double[] specData, double[] data)
        {
            if (_endBin == 0)
                _endBin = specData.Length / 2;

            // محاسبه میانگین در رنج مورد نظر
            for (i = _startBin, _avg = 0; i < _endBin; i++)
                _avg += specData[i];
            _avg = _avg / (_endBin - _startBin);


            // محاسبه بیشترین حد
            if (_avg > _high)
                _maxCount++;
            else _maxCount = 0;

            // محاسبه کمترین حد
            if (_avg < _low)
            { 
                //_minavg += _avg; _minCount++; 
                if (_avg > _minavg)
                    _minavg = _avg;
                _minCount++; 
            }
            else
            {
                _minCount = 0;
                _minavg = 0;
            }

            // اگر کمترین مقدار 10 بار تکرار شد
            if (_minCount >= _minRepeat)
            {
                _low = _minavg  ;// (_minavg / _minRepeat) * 1.1;
                _minavg = 0;
                _minCount = 0;
            }

            // اگر کمترین مقدار 10 بار تکرار شد
            if (_maxCount >= _minRepeat)
                _high = _avg;

            //  اگر میانگین کنونی بیشتر از کمترین مقدار با محاسبه ضریب خطا بود 
            if (_avg > _low * (double)_th)
                _speakingCounter++;         
            else
                _speakingCounter--;
              
            // اگر تا سه بار محاسبه صببت اتفاق افتاد
            if (_speakingCounter >= 3)
            {
                IsSpeaking = true;
                _speakingCounter = 3;
            }

            if (_speakingCounter <=0)
            {
                IsSpeaking = false;
                _speakingCounter = 0;
            }

            // حدود هر 5 ثانیه برای بین 1024 و ریت 192000
            // دوباره حد اقل را محاسبه کن
            if (++_counter > 1000/8)
            {
                // If the loudness lasts longer than 10000, probabely we have reached new noise level.
                // We need to wait until speaker silence
                if (IsSpeaking && _counter < 10000/8)
                    return;

                // اینجا صحبت کننده صحبت نمیکند
                _counter = 0;
                _high = _avg;
                _minavg = _low;
                _low = _low*1.2;
            }

            
       
        }
      
    }
}
