// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;

namespace SoundAnalysis
{
    public interface IFreqFilter
    {
        void ProcessData(double[] specData, double[] samples);
    }
}
