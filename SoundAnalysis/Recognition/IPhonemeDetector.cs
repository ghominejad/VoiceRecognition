// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;

namespace SoundAnalysis.Recognition
{
    public interface IPhonemeDetector
    {
        double Detect(double[] fftSamples);
    }
}
