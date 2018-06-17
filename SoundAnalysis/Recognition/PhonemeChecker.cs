// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoundAnalysis.Recognition
{
    // این کلاس یک سری احتمالات بودن انواع حروف را دریافت نموده و حرف را تخمین میزند
    public class PhonemeChecker
    {



        int vAH = 0;
        int vAA = 0;
        int vEH = 0;
        int vEE = 0;
        int vEU = 0;
        int vS = 0;
        int vSH = 0;
        int vZ = 0;
        int vZH = 0;
        int i = 0;
        PhonemeNames detectedPhoneme = PhonemeNames.None;
        
        public PhonemeNames Method1(PhonemeInfo Inf)
        {
            i++;
            if (i == 20)
                i = 0;

            int rep = 7;
            

            if (Inf.pS == 1)
            {
                if (Inf.pVowel == 1)
                {
                    if (++vZ > rep)
                        return PhonemeNames.Z;
                }
                else
                {
                    if (++vS > rep)
                        detectedPhoneme = PhonemeNames.S;
                }
            }
            else
                if (Inf.pSH == 1)
                {
                    if (Inf.pVowel == 1)
                    {

                        if (++vZH > rep)
                            detectedPhoneme = PhonemeNames.ZH;
                    }
                    else
                    {
                        if (++vSH > rep)
                            detectedPhoneme = PhonemeNames.SH;
                    }
                }
                // else

                    //if (Inf.hEE == 100)
                //{                        
                //    if (++vEE > rep)
                //        DetectedPhoneme = PhonemeNames.EE;
                //}
                else
                    if (Inf.pEH == 1)
                    {
                        if (++vEH > rep)
                            detectedPhoneme = PhonemeNames.EH;
                    }
                    else
                        if (Inf.pAH == 1)
                        {

                            if (++vAH > rep)
                                detectedPhoneme = PhonemeNames.AH;
                        }
                        else
                            if (Inf.pAA == 1)
                            {
                                if (++vAA > rep)
                                    detectedPhoneme = PhonemeNames.AA;

                            }




            if (vZ > rep || vZH > rep || vAH > rep || vEH > rep || vAA > rep || vEE > rep || vEU > rep || vS > rep || vSH > rep)
            {
                vZ = vZH = vAH = vEH = vAA = vEE = vEU = vS = vSH = 0;

            }

            return detectedPhoneme;

        }
        public PhonemeNames Method2(PhonemeInfo Inf)
        {
            int rep = 7;
 
            if (Inf.pS == 1)
            {
                if (Inf.pVowel == 1)
                {
                    if (++vZ > rep)
                        detectedPhoneme = PhonemeNames.Z;
                }
                else
                {
                    if (++vS > rep)
                        detectedPhoneme = PhonemeNames.S;
                }
            }
            else
                if (Inf.pSH == 1)
                {
                    if (Inf.pVowel == 1)
                    {

                        if (++vZH > rep)
                            detectedPhoneme = PhonemeNames.ZH;
                    }
                    else
                    {
                        if (++vSH > rep)
                            detectedPhoneme = PhonemeNames.SH;
                    }
                }
                else
                    if (Inf.pEH == 1)
                    {
                        vEH++;
                        if (vEH > rep)
                            detectedPhoneme = PhonemeNames.EH;
                    }
                    else
                        if (Inf.pAH == 1)
                        {
                            vAH++;
                            if (vAH > rep)
                                detectedPhoneme = PhonemeNames.AH;

                        }
                        else

                            if (Inf.pAA == 1)
                            {
                                vAA++;
                                if (vAA > rep)
                                    detectedPhoneme = PhonemeNames.AA;
                            }
                            else
                                if (Inf.pEE == 1)
                                {
                                    vEE++;
                                    if (vEE > rep)
                                        detectedPhoneme = PhonemeNames.EE;
                                }
                                else
                                    if (Inf.pEU == 1)
                                    {
                                        vEU++;
                                        if (vEU++ > rep)
                                            detectedPhoneme = PhonemeNames.EU;
                                    }


            if (vZ > rep || vZH > rep || vAH > rep || vEH > rep || vAA > rep || vEE > rep || vEU > rep || vS > rep || vSH > rep)
            {
                vZ = vZH = vAH = vEH = vAA = vEE = vEU = vS = vSH = 0;

            }

            return detectedPhoneme;
        }
    }
}
