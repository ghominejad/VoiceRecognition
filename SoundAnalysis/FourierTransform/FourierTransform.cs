// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
namespace SoundAnalysis
{
    public class FourierTransform
    {
        public static double[] Compute(double[] sampleData, long fftFrameSize, int pos)
        {

            // آرایه را دو برابر میکنیم تا فرکانسها واضح تر مشخص شوند
            // اطلاعات اظافه تر با صفر مقدار دهی میشوند
            // در تبدیل استاندارد این عمل وجود ندارد
            double[] fftBuffer=new double[fftFrameSize *2 ];
            Array.Copy(sampleData, fftFrameSize * pos, fftBuffer, 0, fftFrameSize);

            //fftFrameSize = fftFrameSize / 2;
            // تبدیل سریع فوریه
            long sign = 1;
            double wr, wi, arg, temp;
            double tr, ti, ur, ui;
            long i, bitm, j, le, le2, k;

            for (i = 2; i < 2 * fftFrameSize - 2; i += 2)
            {
                for (bitm = 2, j = 0; bitm < 2 * fftFrameSize; bitm <<= 1)
                {
                    if ((i & bitm) != 0) j++;
                    j <<= 1;
                }
                if (i < j)
                {
                    temp = fftBuffer[i];
                    fftBuffer[i] = fftBuffer[j];
                    fftBuffer[j] = temp;
                    temp = fftBuffer[i + 1];
                    fftBuffer[i + 1] = fftBuffer[j + 1];
                    fftBuffer[j + 1] = temp;
                }
            }
            long max = (long)(Math.Log(fftFrameSize) / Math.Log(2.0) + .5);
            for (k = 0, le = 2; k < max; k++)
            {
                le <<= 1;
                le2 = le >> 1;
                ur = 1.0F;
                ui = 0.0F;
                arg = (double)Math.PI / (le2 >> 1);
                wr = (double)Math.Cos(arg);
                wi = (double)(sign * Math.Sin(arg));
                for (j = 0; j < le2; j += 2)
                {

                    for (i = j; i < 2 * fftFrameSize; i += le)
                    {
                        tr = fftBuffer[i + le2] * ur - fftBuffer[i + le2 + 1] * ui;
                        ti = fftBuffer[i + le2] * ui + fftBuffer[i + le2 + 1] * ur;
                        fftBuffer[i + le2] = fftBuffer[i] - tr;
                        fftBuffer[i + le2 + 1] = fftBuffer[i + 1] - ti;
                        fftBuffer[i] += tr;
                        fftBuffer[i + 1] += ti;

                    }
                    tr = ur * wr - ui * wi;
                    ui = ur * wi + ui * wr;
                    ur = tr;
                }
            }

            // خروجی بصورت اعداد مختلط میباشند
            // به اندازه صوتی تبدیل میکنیم
           //new Filters.ToAmpFilter().ProcessData(
            double re, im;
            i = 0;
            for (int x = 0; x < fftBuffer.Length; x += 2)
            {
                re = fftBuffer[x];
                im = fftBuffer[x + 1];
                if (re != 0 || re != 0)
                    fftBuffer[i] = Math.Sqrt((re * re) + (im * im));
                else fftBuffer[i] = 0;

                i++;
            }




            return fftBuffer;
        }
    }
}
