// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;

namespace SoundAnalysis.Filters
{
    // جهت حذف نویز از این فیلتر استفاده میکنیم
    // فعلا دیگر در این پروژه استفاده ای ندارد
    public class NoiseReductionFilter : IFreqFilter
    {


        int _isSpeackingCounter = 0;

        public int IsSpeackingCounter
        {
            get { return _isSpeackingCounter; }         
        }


        Random r = new Random();
        int noiseSlots = 10;
        double[][] LatestNoiseSamples = null;
        bool sampleCompleted = false;
        int iSampleCount=0;
        int slotNo = 0;
        void AddNoiseSample(double [] spec)
        {
            if(!sampleCompleted)
            {
                LatestNoiseSamples[iSampleCount++] = (double[])spec.Clone();
                if (iSampleCount == noiseSlots)
                    sampleCompleted = true;
                return;
            }

            //int slot = r.Next(0, noiseSlots);
            slotNo++;
            if (slotNo > noiseSlots-1) slotNo = 0;
            LatestNoiseSamples[slotNo] = (double[])spec.Clone();
            

        }

        public static double[] oldSpecData = null;

        public void ProcessData(double[] specData, double[] data)
        {
            
            
            if(LatestNoiseSamples ==null)
                LatestNoiseSamples = new double[noiseSlots][];

            // margin after speacking
            if (_isSpeackingCounter > 0)
                _isSpeackingCounter--;

            if (specData[4] > specData[17] * 50 || specData[50] > (specData[200]*50))
                _isSpeackingCounter = 100;
            // find is any speaker speaking
           //for (int i = 7; i <= 10; i++)
           //    if (specData[i]>4)
                //         _isSpeackingCounter = 100;
            
           //for (int i = 60; i <= 80; i++)
           //    if (specData[i] > 2)
           //        _isSpeackingCounter = 100; 

            // Adding new noises to list if speacker is not speaking
            if (_isSpeackingCounter <= 0)
                AddNoiseSample(specData);

            
            // Reducing latest noises
            if (!sampleCompleted)
                return;
            int len = specData.Length / 2;

            for (int i = 0; i < len; i++)
            {
                
                double noiseAvg = 0;
                for (int slot = 0; slot < noiseSlots; slot++)
                {
                    noiseAvg += LatestNoiseSamples[slot][i];
                    //if (noiseAvg < LatestNoiseSamples[slot][i])
                      //  noiseAvg = LatestNoiseSamples[slot][i];
                }
                noiseAvg = noiseAvg / noiseSlots;
                //if (noiseAvg<1)
                //    noiseAvg = noiseAvg * 1.8;
                //else
                //    noiseAvg = noiseAvg * 1.8;



                //if (specData[i] <= noiseAvg)
                //{
                //    specData[i] = 0;
                //    if (oldSpecData == null || _isSpeackingCounter < 88 || i > 5)
                //        specData[i] = 0;
                //    else
                //    {
                //        specData[i] = oldSpecData[i];
                //    }
                //}
                    specData[i] = specData[i] - noiseAvg;
                //if(specData[i]<0) specData[i]=0; 
                
            }
           // oldSpecData = (double[])specData.Clone();

          ////  double[] newData = new double[specData.Length / 2];
          //  double re, im, d;
          //  int i=0;
          //  for (int x = 0; x < specData.Length; x += 2)
          //  {



          //      re = specData[x];
          //      im = specData[x + 1];
          //      if (re != 0 || re != 0)                    
          //          specData[i] = 10 * Math.Sqrt((re * re) + (im * im));
          //      else specData[i] = 0;

          //      i++;
          //  }
        }
    }
}
