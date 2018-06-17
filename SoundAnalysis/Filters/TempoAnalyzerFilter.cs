// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;

using System.Text;

namespace SoundAnalysis.Filters
{
    public enum TempoCharacter
    {
        Male,
        Female,        
        Child


    }
    // تشخیص زیر و بمی صدا
    public class TempoAnalyserFilter : IFreqFilter
    {
        #region Properties
        TempoCharacter _character = TempoCharacter.Male;

        public TempoCharacter Character
        {
            get { return _character; }
            set { _character = value; }
        }

        int _tempo = 0;
        public int Tempo
        {
            get { return _tempo; }
            set { _tempo = value; }
        }

        #endregion
        #region Fields
        int[] chCount = new int[3];
        // indexer
        int i = 0;
        #endregion
        #region Methods

      
       
        public void ProcessData(double[] specData, double[] data)
        {
            if (specData.Length < 8000)
                return; // man
            // determinig max item
            double max=0;            
            for (i=0 ; i<2500; i++)
            {
                if(specData[i] > max)
                    max=specData[i]; 
            }

          
            List<int> items=new List<int>();
            
            // 
            double div =3;
            if(max>50) div = max / 15;    
 
            // Determining harmonics lines                 
            for (i = 8; i < 2500 && items.Count< 5; i++)
            {

                if (specData[i] < max)
                {
                    if (max / specData[i] <= div)
                    {
                        max = specData[i];
                        items.Add(i);
                    }
                }
                else
                {
                    max = specData[i];
                    items.Add(i);
                }
            }
            if (items.Count < 2)
                return;
            // Checking same spaces with at last 1 item
            int [] occures=new int[items.Count];
            for (int j = 0; j < items.Count - 1; j++)
            {
                int width_j = items[j + 1] - items[j];
                int err = 0;
                for (i = 0; i < items.Count - 1; i++)
                {
                    int width_i = items[i + 1] - items[i];
                    
                    if (width_i < 5)
                        err++;

                    if (err > 2)
                        return;
                    int diff = Math.Abs(width_i - width_j);
                    if (diff == 0 || diff == 1)
                    {
                        occures[j]++;
                        // if (occures[i] >= 2)
                        //Tempo = width_i;
                    }


                }
            }

            // checking greater value
            int maxcount=0;
            for (int i = 1; i < occures.Length; i++)
                if (occures[i] > maxcount)
                    maxcount = i;

            _tempo = items[maxcount+1] - items[maxcount];


            if (chCount[0] > 3 || chCount[1] > 3 || chCount[0] > 3)
                Reset();

            if (_tempo > 6 && _tempo < 22)
                chCount[0]++;
            else
                if (_tempo >= 22 && _tempo < 31)
                    chCount[1]++;
                else
                    if (_tempo >= 31 && _tempo < 45)
                        chCount[2]++;
                    else
                        _tempo = 0;
            if (chCount[0] >= chCount[1] && chCount[0] >= chCount[2])
                _character = TempoCharacter.Male;
            else
                if (chCount[1] >= chCount[0] && chCount[1] >= chCount[2])
                    _character = TempoCharacter.Female;
                else
                    if (chCount[2] >= chCount[0] && chCount[2] >= chCount[1])
                        _character = TempoCharacter.Child;

        }
        public void Reset()
        {
            Tempo = 0;
            chCount[2] = chCount[1] = chCount[0] = 0;


        }

        public string GetCharachterTitle()
        {
            switch (_character)
            {
                case TempoCharacter.Female: return "زن";
                case TempoCharacter.Male: return "مرد";
                case TempoCharacter.Child: return "بچه";
            }
            return "";
        }
    


       #endregion
      
    }
}
