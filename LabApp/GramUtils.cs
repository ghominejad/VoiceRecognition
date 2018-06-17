// Author : Hosseini Ghominejad, Ghominejad@gmail.com
// File Description :
// History : 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoundAnalysis.Filters;
using System.Drawing;
using System.Windows.Forms;

namespace LabApp
{
    public class GramUtils
    {

        #region Storing
        public static List<double[]> Archive = new List<double[]>();
        public static List<double[]> RoundedArchive = new List<double[]>();
        public static List<double[]> NormalArchive = new List<double[]>();
        public static List<double[]> SampleArchive = new List<double[]>();
        public static List<bool> TalkArchive = new List<bool>();

        public static void ClearData()
        {
            RoundedArchive.Clear();
            Archive.Clear();
            NormalArchive.Clear();
        }
        public static void ArchiveData(double[] specData)
        {
            GramUtils.NormalArchive.Add(specData);
            var roundedRow = (double[])specData.Clone();
            new SpectrumNormalizerFilter().ProcessData(roundedRow, null);
            GramUtils.RoundedArchive.Add(roundedRow);
        }

        public static void SaveGram(string filename, int zoom, int w, int b, int amp, int filter)
        {
            int len = NormalArchive[0].Length;

            System.IO.BinaryWriter sw = new System.IO.BinaryWriter(new System.IO.FileStream(filename, System.IO.FileMode.Create));

            sw.Write(len);
            sw.Write(zoom);
            sw.Write(w);
            sw.Write(b);
            sw.Write(amp);
            sw.Write(filter);

            foreach (double[] ar in NormalArchive)
            {
                foreach (double d in ar)
                    sw.Write(d);
                //sw.WriteLine(DoubleArToString(ar));
            }

            //System.IO.TextWriter  sw = new System.IO.StreamWriter("d:\\text.txt");

            //foreach(double[] ar in NormalArchive)
            //{
            //    sw.WriteLine(DoubleArToString(ar));
            //}
            sw.Close();
        }
        public static void LoadGram(string filename, ref int zoom, ref int w, ref int b, ref int amp, ref int filter)
        {
            int len = 0;
            System.IO.BinaryReader sw = new System.IO.BinaryReader(
                new System.IO.FileStream(filename, System.IO.FileMode.Open)
                );
            len = sw.ReadInt32();
            zoom = sw.ReadInt32();
            w = sw.ReadInt32();
            b = sw.ReadInt32();
            amp = sw.ReadInt32();
            filter = sw.ReadInt32();


            while (sw.BaseStream.CanRead)
            {
                try
                {
                    List<double> list = new List<double>();
                    for (int i = 0; i < len; i++)
                    {

                        list.Add(sw.ReadDouble());
                    }
                    GramUtils.ArchiveData(list.ToArray<double>());
                }
                catch
                {
                    break;
                }
            }


            //System.IO.TextReader sw = new System.IO.StreamReader("d:\\text.txt");
            //this.RoundedArchive.Clear();
            //this.Archive.Clear();
            //this.NormalArchive.Clear();
            //while (true)
            //{   
            //    LoadData(StrToDoubleAr(sw.ReadLine()));
            //}


            sw.Close();
        }

        #endregion

        #region Drawing

        public static void DrawGram(int zoom, int amp, int balance, int wide, Bitmap bmp)
        {

            // g.FillRectangle(Brushes.White, 0, 0, 1024, 800);
            int from = Math.Max(GramUtils.Archive.Count - 800, 0);
            int j = 0;
            for (int row = GramUtils.Archive.Count - 1; row >= from; row--)
            {
                int i = 0;
                int alpha = 0;

                float step = 1;
                double d = 0;
                bool b = false;


            
                for (int x = 0; x < GramUtils.Archive[row].Length / 2; x++)
                {


           
                    d = GramUtils.Archive[row][x];
                    d = d * amp;
                    alpha = (int)(d * (255.0 / 2000));
                    alpha *= (wide / 5);
                    alpha += (255 / 5) * ((balance - 5) + 1);

                    if (alpha < 0) alpha = 0;

                    if (alpha > 255) alpha = 255;

                    if (((i + 1) * step * zoom) >= 512)
                        break;

                    //if (!TalkArchive[row])
                      //  alpha = 0;
                    if ((j + 1) * zoom >= 800)
                        break;
                    for (int h = (int)(i * step * zoom); h < (i * step * zoom) + step * zoom; h++)
                    {

                        for (int hj = (int)(j * zoom); hj < (j * zoom) + zoom; hj++)
                            bmp.SetPixel(h, hj, GramUtils.CurrentPalette[alpha]);
                    }

                    i++;
                }
                j++;
            }

        }

       // static NoiseAnalyserFilter noiseFilterVowelChecker = new NoiseAnalyserFilter(7, 50, 3);
        public static void DrawIntensity(int zoom ,  Bitmap bmp, IntensityAnalyserFilter filter)
        {
            Graphics g =Graphics.FromImage(bmp);


            Point[] linePoints = new Point[Math.Min(800 / zoom, Math.Min(GramUtils.Archive.Count, 800))];
            

            // g.FillRectangle(Brushes.White, 0, 0, 1024, 800);
            int from = Math.Max(GramUtils.Archive.Count - 800, 0);
            int j = 0; float step = 1;
            for (int row = GramUtils.Archive.Count - 1; row >= from; row--)
            {
               
                // zoom = int.Parse(cmbZoom.SelectedItem.ToString().Replace("x", ""));
                //int amp = int.Parse(cmdAmp.SelectedItem.ToString().Replace("x", ""));
               

              //  for (int x = 0; x < GramUtils.Archive[row].Length / 2; x++)
               // {
                if ((j + 1) * zoom >= 800)
                        break;
                    filter.ProcessData(null, SampleArchive[row]);

                    linePoints[j].X=(int)(filter.Avg * 1000.0);
                    linePoints[j].Y = (int)(j * zoom);
          ;
                   /// for (int hj = (int)(j * zoom); hj < (j * zoom) + zoom; hj++)
                    //bmp.SetPixel((int)(filter.avg * 500.0), (j * zoom), Color.Blue);
                  


                          
                 
                //}
                j++;
            }
            linePoints[0].X = 0;
            linePoints[linePoints.Length-1].X = 0;
            g.DrawPolygon(Pens.Blue, linePoints);
            g.Dispose();

        }
        #endregion

        #region Palette
        public static List<Color> CurrentPalette = null;
        public static void LoadPalettes(ToolStripMenuItem menuItem)
        {

            string[] files = System.IO.Directory.GetFiles("./palettes");
            foreach (string palFile in files)
            {
                List<Color> list = new List<Color>();
                System.IO.StreamReader sr = System.IO.File.OpenText(palFile);
                string txtPal = sr.ReadToEnd();
                sr.Close();
                int idx = txtPal.IndexOf("[Colors]") + 8;
                int idx2 = txtPal.IndexOf("[", idx + 1);
                if (idx2 > 0)
                    txtPal = txtPal.Substring(idx, idx2 - idx);
                else
                    txtPal = txtPal.Substring(idx, txtPal.Length - idx);
                idx = 0;
                while (idx >= 0)
                {
                    idx = txtPal.IndexOf("=", idx);
                    if (idx > 0)
                    {
                        try
                        {
                            string colstr = "#" + txtPal.Substring(idx + 3, 6);
                            Color c = System.Drawing.ColorTranslator.FromHtml(colstr);

                            list.Add(c);
                            idx += 8;
                        }
                        catch
                        {
                        }
                    }
                }


                ToolStripMenuItem item = new ToolStripMenuItem();

                item.TextImageRelation = TextImageRelation.TextAboveImage;
                item.ImageScaling = ToolStripItemImageScaling.None;

                item.ImageAlign = ContentAlignment.MiddleCenter;

                item.Image = new Bitmap(256, 17);
                Graphics g = Graphics.FromImage(item.Image);
                int i = 0;
                if (palFile.IndexOf("spectrogram") > 0)
                    CurrentPalette = list;
                foreach (Color c in list)
                {
                    g.DrawLine(new Pen(c), i, 0, i, 30);
                    i++;
                }

                g.Dispose();

                item.Text = palFile.Substring(palFile.IndexOf("\\") + 1, palFile.IndexOf(".pal") - (palFile.IndexOf("\\") + 1));
                item.Tag = list;
                item.Click += new EventHandler(item_Click);
                menuItem.DropDownItems.Add(item);

            }


        }

        static void item_Click(object sender, EventArgs e)
        {
                CurrentPalette = (sender as ToolStripMenuItem).Tag as List<Color>;
        }
        #endregion

    }
}
