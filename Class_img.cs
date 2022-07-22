using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_tp
{
    class Class_img
    {
        public Bitmap o_img;  //image originale
        public Bitmap g_img;  //image en gris
        public Bitmap translation_img;  //image après  translation
        public Bitmap inversion_img;    //image après  inversion
        public Bitmap Expansion_img;    //image après  Expansion
        public Bitmap Egalisation_img;  //image après  Egalisation

        public int max; //color max 
        public int min; //color min


        public int[] h; //Histogramme simple
        public double[] hn; //L'histogramme normalisé
        public int[] hc; //L'histogramme cumulé
        public double[] hcn; //L'histogramme cumulé normalisé
        public double[] heq;  //modification des intensités

        public Class_img(Bitmap o_img)
        {
            this.o_img = new Bitmap(o_img);
        }

        //histogramme s
        public void fun_hs(Bitmap img)
        {
            int[] level = new int[256];
            for (int i = 0; i < level.Length; i++)
            {
                level[i] = 0;
            }

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {

                    level[img.GetPixel(x, y).R]++;

                }
            }


            this.h = level;

            Tuple<int, int>  min_max = fun_max_min(this.h);

            this.min = min_max.Item2;
            this.max = min_max.Item1;
        }

        //L'histogramme normalisé
        public void fun_hn(int[] hs, int w, int h)
        {
            double[] levels = new double[256];
            double q = w * h;
            int i;
            for (i = 0; i < levels.Length; i++)
            {
                levels[i] = hs[i]/q;
            }

            this.hn =  levels;
        }

        //L'histogramme cumulé
        public void fun_hc(int[] hs)
        {
            int[] levels = new int[256];
            levels[0] = hs[0];

            for (int i = 1; i < levels.Length; i++)
            {
                levels[i] = levels[i - 1] + hs[i];
            }

            this.hc = levels;
        }

        //L'histogramme cumulé normalisé
        public void fun_hcn(int[] hc, int w, int h)
        {
            double[] levels = new double[256];
            double q = w * h;

            for (int i = 0; i < levels.Length; i++)
            {
                levels[i] =  hc[i]/q;
            }

            this.hcn = levels;

        }
        
        /// /////////////////////////////////////////////////////////
        
        //La translation d'histogramme
        public void laTranslationDhistogramme(Bitmap img, int val)
        {
            Bitmap img2 = new Bitmap(img.Width, img.Height);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)      {
                    Color pix;
                    pix = img.GetPixel(x, y);

                    if (val > 0)
                    {
                        //+ val
                        if (pix.R + val > 255)
                        {
                            img2.SetPixel(x, y, Color.FromArgb( 255,255, 255));
                        }
                        else
                        {
                            img2.SetPixel(x, y, Color.FromArgb(pix.R + val, pix.G + val, pix.B + val));
                        }

                    }
                    else
                    {
                        //- val

                        if (pix.R + val < 0)
                        {
                            img2.SetPixel(x, y, Color.FromArgb(0,0,0));
                        }
                        else
                        {
                            img2.SetPixel(x, y, Color.FromArgb(pix.R + val, pix.G + val, pix.B + val));
                        }

                    }

                }
            }

            this.translation_img = img2;

        }

        //L'inversion d'histogramme
        public void linversionDhistogramme(Bitmap img)
        {
            Bitmap img2 =new Bitmap(img.Width, img.Height); 
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pix;
                    pix = img.GetPixel(x, y);

                    img2.SetPixel(x, y, Color.FromArgb(255 - pix.R, 255 - pix.G, 255 - pix.B));

                }
            }

            this.inversion_img = img2;
        }

        //Expansion de dynamique
        public void lexpansionDeDynamique(Bitmap img, int max, int min)
        {
            //quotient = [255/(max[x,y] - min[x,y])]
            if (this.h==null) {
                fun_hs(this.g_img);
                max = this.max;
                min = this.min;
            }

            int max_min = max-min;
            double quotient = 255/max_min;

            Console.WriteLine("quotient: " + quotient);

            Bitmap img2 = new Bitmap(img.Width, img.Height);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pix;
                    pix = img.GetPixel(x, y);
                    int col = (int)Math.Round(quotient * (pix.R - min));
                    

                    if (col > 255)
                    {
                        img2.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else if (col < 0 )
                    {
                        img2.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        img2.SetPixel(x, y, Color.FromArgb(col, col, col));
                    }

                   
                }
            }

            this.Expansion_img = img2;
        }

        //modification des intensités
        public void fun_heq(int max, double[] hcn)
        {
           if (this.hcn == null) { 
                if (this.hc == null)
                {
                    if (this.h == null)
                    {
                        this.fun_hs(this.g_img);
                        max = this.max;
                    }
                    this.fun_hc(this.h);

                }
                

                this.fun_hcn(this.hc, this.g_img.Width, this.g_img.Height);
                hcn = this.hcn;
            }
            double[] levels = new double[256];

            for (int i = 0; i < levels.Length; i++)
            {
                levels[i] = max * hcn[i];
            }
            this.heq =  levels;
        }

        //Egalisation d'histogramme
        public void Egalisation(double[] heq,Bitmap img)
        {
            Bitmap img2 = new Bitmap(img.Width, img.Height);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    img2.SetPixel(x, y, Color.FromArgb((int)Math.Round(heq[img.GetPixel(x, y).R]), (int)Math.Round(heq[img.GetPixel(x, y).G]), (int)Math.Round(heq[img.GetPixel(x, y).B])));


                }
            }

            this.Egalisation_img = img2;
        }



        //rendre L'image Grise
        public void fun_gris(Bitmap img)
        {
            Color gpb = Color.FromArgb(255, 255, 255);
            Color gpw = Color.FromArgb(0, 0, 0);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pix;
                    pix = img.GetPixel(x, y);

                    Byte gray = (byte)(0.299 * pix.R + 0.587 * pix.G + 0.114 * pix.B);
                    Color gray_val = Color.FromArgb(gray, gray, gray);
                    if (gray_val.R > 255)
                    {
                        img.SetPixel(x, y, gpb);
                    }
                    else
                    {
                        img.SetPixel(x, y, gray_val);
                    }
                    if (gray_val.R < 0)
                    {
                        img.SetPixel(x, y, gpw);
                    }
                    else
                    {
                        img.SetPixel(x, y, gray_val);
                    }

                }
            }

            this.g_img = img;
        }
        
        //max - min 
        public Tuple<int, int> fun_max_min(int[] h)
        {
            int max = 0;
            int min = 255;
            for (int i =0; i < h.Length; i++)
            {
                if (h[i] !=0 && i>max ) { max = i; }
                if (h[i] !=0 && i<min) { min = i; }
            }
            Console.WriteLine("max:" + max + " min: " + min);
            return Tuple.Create(max, min);
        }
    }
}
