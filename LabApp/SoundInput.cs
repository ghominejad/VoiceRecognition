// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;
using System.Text;
using SoundCapture;

namespace RecognizerApp
{
    public delegate void SampleDataReceiverDelegate(short[] data);

    public class SoundInput : SoundCaptureBase
    {
        public event SampleDataReceiverDelegate FrequencyDetected = null;


        public SoundInput(SampleDataReceiverDelegate receiver) : base(SoundCaptureDevice.GetDevices()[0])
        {
            SampleRate = 192000;
            FrequencyDetected += new SampleDataReceiverDelegate(receiver);
        }
       

        protected override void ProcessData(short[] data)
        {
            // convert to double
            // apply window function filter
            // 
            if (FrequencyDetected != null)
                FrequencyDetected( data);

        }

    }
}
