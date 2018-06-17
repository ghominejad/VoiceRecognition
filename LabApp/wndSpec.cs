// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SoundAnalysis;
using RecognizerApp;

namespace LabApp
{
    public partial class WndSpec : Form, IFreqFilter
    {
        public double[] SpecData{
            get
            {
                return spectrumViewer1.SpecData;
            }
            set
            {
                spectrumViewer1.SpecData = value;
            }
        }
        public WndSpec()
        {
            
            InitializeComponent();
            
        }

        private void WndSpec_Resize(object sender, EventArgs e)
        {
            spectrumViewer1.Redraw(Width - spectrumViewer1.Left, Height - spectrumViewer1.Top);
        }

        public float XScale
        {
            get {
                return spectrumViewer1.XScale;
            }
            set
            {
                spectrumViewer1.XScale = value;
                spectrumViewer1.Redraw(0, 0);// refresh
            }
        }
        public float YScale
        {
            get
            {
                return spectrumViewer1.YScale;
            }
            set
            {
                spectrumViewer1.YScale = value;
                spectrumViewer1.Redraw(0, 0);// refresh
            }
        }


   
        public void ProcessData(double[] specData, double[] data)
        {
            double[] x = new double[specData.Length];
            for (int i = 0; i < x.Length/2 ; i++)
                x[i] = specData[i] / 32768.0;
                

    
            //int[] peaks = FindPeakValues(x, 44100, 100.0, 4000.0, ref specData);

            spectrumViewer1.SpecData = specData;
        }
    }
}
