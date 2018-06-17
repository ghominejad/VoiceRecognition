// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;

namespace SoundAnalysis.Filters
{
    // بصورت پیشفرض تبدیل فوریه بصورت مستطیلی محاسبه میشود
    // جهت اجتناب از پخش شدن قدرت از فرمول بلکمن استفاده نمودیم
    public class WindowFilter : IFreqFilter
    {
        int _frameSize=1024;
        double _dPi;
        double _dTwoPi;
        double _dTemp;

        public WindowFilter(int frameSize)
        {
            _frameSize = frameSize;
            _dPi = 4 * Math.Atan(1);
            _dTwoPi = _dPi + _dPi;
        }

        public void ProcessData(double[] spec, double[] data)
        {

            for (int i = 0; i < data.Length; i++)
            {  
                _dTemp = _dTwoPi * i / _frameSize;
                data[i] = data[i] * (0.42 - 0.5 * Math.Cos(_dTemp) + 0.08 * Math.Cos(2 * _dTemp));

            }   
        }
    }
}
