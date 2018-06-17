// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace LabApp
{
    public partial class SpectrumViewer : UserControl
    {


        double[] _specData;
        public double[] SpecData
        {
            get
            {
                return _specData;
            }

            set{
                _specData = value;
                Invalidate();
            }
        }
        public SpectrumViewer()
        {
            InitializeComponent();

            InitializeComponent2();
        }

        public SpectrumViewer(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            InitializeComponent2();
        }
       
        private void InitializeComponent2()
        {
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            XScale = 1;
            YScale = 1;
            Redraw();
        }

        static Pen MarkerPen = new Pen(Color.FromArgb(100,0,10,50));
        static Pen MarkerPenSolidBlack = new Pen(Color.Black);
        static Brush ActiveSliderBrush1 = new SolidBrush(Color.GreenYellow);
        static Brush ActiveSliderBrush2 = new SolidBrush(Color.Green);
        static Brush InactiveSliderBrush1 = new SolidBrush(Color.FromArgb(70, Color.Gray));
        static Brush InactiveSliderBrush2 = new SolidBrush(Color.FromArgb(50, Color.Black));
        const int DisplayPadding = 5;
        const int MarkWidth = 6;
        const int LabelMarkSize = 9;
        int oldx = -1; int oldy = -1;
        void setPixel(int x, int y, Graphics g)
        {
            if (x >= this.Width || y>= this.Height)
                return;
            //g.DrawRectangle(MarkerPen, x, y,1,  1);
            //g.DrawLine(MarkerPenSolidBlack, x, 0, x, y);
            g.DrawLine(MarkerPen, oldx, oldy, x, y);
            oldx = x;
            oldy = y;
        }

        //int xScale = 1;
        //int yScale = 1;

        public float XScale
        {
            get;
            set;
        }
        public float YScale
        {
            get;
            set;
        }

        int scrollWidth = 15;
        public void Redraw(int width=0, int height=0)
        {
            if (width != 0)
            {
                this.Width = width-20;
                this.Height = height-40;
            }
            vScrollBar1.Width = scrollWidth;
            hScrollBar1.Height = scrollWidth;

            /*hScrollBar1.Width = this.Width;
            vScrollBar1.Height = this.Height - scrollWidth;

           // pnlCanvas.Left = vScrollBar1.Width;
            //pnlCanvas.Width = this.Width - vScrollBar1.Width;
            //pnlCanvas.Height = this.Height - hScrollBar1.Height;
            hScrollBar1.Left = vScrollBar1.Width;
            hScrollBar1.Top = this.Height - scrollWidth;
            vScrollBar1.Left = 0;
            vScrollBar1.Top = 0;
            */
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = (int)((this.Width - scrollWidth) * (YScale - 1));

            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = (int)(this.Height * (XScale-1));
            
            hScrollBar1.Scroll += new ScrollEventHandler(hScrollBar1_Scroll);
            vScrollBar1.Scroll += new ScrollEventHandler(vScrollBar1_Scroll);


            vScrollBar1.Dock = DockStyle.Left;
            hScrollBar1.Dock = DockStyle.Bottom;
            hScrollBar1.Refresh();
            vScrollBar1.Refresh();
        }

        void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //throw new NotImplementedException();
        }

        double min = 0;
        double max = 0;
        int maxbin = 512;
        //void DrawSpecLine(int x, int y)
        protected override void OnPaint(PaintEventArgs e)
        {
            maxbin = (int)MainForm.FftPeechInterval / 4;


            //Redraw();
            //e.
           // pnlCanvas.Invalidate(e.ClipRectangle;
            e.Graphics.FillRectangle(Brushes.White, 0, 0, Width, Height);

            if (SpecData == null)
                return;
         //   int minFreq = 0, maxFreq = 420, sampleRate = 44100;
         //   int usefullMinSpectr = Math.Max(0,
         //       (int)(minFreq * SpecData.Length / sampleRate));
          ///  int usefullMaxSpectr = Math.Min(SpecData.Length,
          //      (int)(maxFreq * SpecData.Length / sampleRate) + 1);
            //
            // usefullMaxSpectr = this.Width;
            int usefullMaxSpectr = (int)((maxbin) / XScale);
            //int step = 420  / this.Width;
            float step = (float)usefullMaxSpectr / (float)(this.Width-scrollWidth);
      //      if (step == 0)
           //     step = 1;
            //  float step = 22000.0f / (float)this.Width;
            //float step = 1; //1.0f / this.Width;
            //step = 1;
            //float yscale=(this.Height/ 20000.0f);
            double usefullMaxAmp = ((float)maxbin) / YScale;
            //double ystep=  usefullMaxAmp /(this.Height);
            double ystep = (Height / 255.0);
            double d=0;
            oldy = -1;
            oldx = -1;
            bool odd = false;
            for (int i = (int)((float)hScrollBar1.Value*step); i < (hScrollBar1.Value *step)+ (usefullMaxSpectr ); i++)
            {
                //odd = !odd;
                //if (!odd)
                  //  continue;




                //if (SpecData[i] > 0)           
                //    SpecData[i] = -SpecData[i];
               // SpecData[i] = Math.Pow( SpecData[i], 5);
             //   if (SpecData[i] > SoundFrequencyInfoSource.FftLength) SpecData[i] = 0;

                d = 0;

                if (i > maxbin)
                    return;
                d = Math.Abs(SpecData[i]) * 5;// % 256.0;

                    //d = 20 * Math.Log10(Math.Abs(d));
                 //  d /= 1000;
                 //Math.Pow(d, -1.2);
                 ///if (d < -20) d = 0;

                 
                //if (min > d) min = d;
                //if (max < d) max= d;

                //d *= -1;
                //if (SpecData[i] < 10)
                 //{
                   //  continue;
                     //SpecData[i] = 1;
                 //}
                /* if (d > 100 || d < -100)
                 {
                     d = 0;
                     continue;
                 }
                */
               // d =(-d)+ 100;
                   //  d += 100;
                d *= ystep;
                d = -d +  (Height-200);
                if (((int)d) < 0)
                    continue;
                //((float)vScrollBar1.Value & YScale)
                //setPixel(scrollWidth+ (int)(((float)(i - (hScrollBar1.Value * step))) / step), (int)(SpecData[(int)(i)] * yscale), e.Graphics);
                //setPixel(scrollWidth + (int)(((float)(i - (hScrollBar1.Value * step))) / step), (int)ypos, e.Graphics);
                setPixel(scrollWidth + (int)(((float)(i - (hScrollBar1.Value * step))) / step), (int)d, e.Graphics);
            }   


        }

        public void ProcessData(double[] specData, short[] data)
        {
            SpecData = specData;
        }
     
     
    }
}
