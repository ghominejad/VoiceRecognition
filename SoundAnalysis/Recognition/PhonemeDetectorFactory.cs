// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;
using SoundAnalysis.Recognition.Phoneme;

namespace SoundAnalysis.Recognition
{
    public class PhonemeDetectorFactory
    {

   
        public static PhonemeDetector CreatePhonemeDetectors(int fftIntercal = 1024, int sampleRate = 192000)
        {

             PhonemeDetector detector = detector = new PhonemeDetector(fftIntercal, sampleRate);

            // زیر و بمی
            detector.VowelDetectors[PhonemeNames.AA] = new PhonemeDetector_AA(detector);
            detector.VowelDetectors[PhonemeNames.AH] = new PhonemeDetector_AH(detector);
            //detector.VowelDetectors[PhonemeNames.O] = new PhonemeDetector_O(detector);
            //detector.VowelDetectors[PhonemeNames.EU] = new PhonemeDetector_EU(detector);
            detector.VowelDetectors[PhonemeNames.EH] = new PhonemeDetector_EH(detector);
            detector.VowelDetectors[PhonemeNames.EE] = new PhonemeDetector_E(detector);
            detector.VowelDetectors[PhonemeNames.S] = new PhonemeDetector_S(detector);
            detector.VowelDetectors[PhonemeNames.SH] = new PhonemeDetector_SH(detector);
           // detector.VowelDetectors[PhonemeNames.Consonant] = new PhonemeDetector_Consonant(detector);
            //detector.VowelDetectors[PhonemeNames.Vowel] = new PhonemeDetector_Vowel(detector);
            return detector;
        }

     
        public PhonemeDetectorFactory()
        {

        }
    }
}
