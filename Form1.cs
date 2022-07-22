using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Project_tp
{
    public partial class Form1 : Form
    {
        Class_img my_obj;
        public Form1()
        {
            InitializeComponent();
        }


        private void importerUnImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap o_img = new Bitmap(openFileDialog1.FileName);
                my_obj = new Class_img(o_img);
                pictureBox1.Image = my_obj.o_img;
            }
        }

        private void rendreLimageGriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            my_obj.fun_gris(my_obj.o_img);
            pictureBox3.Image = my_obj.g_img;
        }


        private void histogrammeSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (my_obj.g_img == null)
            {

                MessageBox.Show("vous devez calculer l\'image gris avant d\'effectuer ce traitement", "pas d\'image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                my_obj.fun_hs(my_obj.g_img);

                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                for (int i = 0; i < my_obj.h.Length; i++)
                {
                    chart1.Series["Series1"].Points.AddXY(i, my_obj.h[i]);
                    chart1.Series["Series1"].LegendText = "histogramme Simple";
                }


            }

        }

        private void lhistogrammeNormaliséToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (my_obj.g_img == null)
            {
                MessageBox.Show("vous devez calculer l\'image gris avant d\'effectuer ce traitement", "pas d\'image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (my_obj.h == null)
                {
                    my_obj.fun_hs(my_obj.g_img);
                }
                    my_obj.fun_hn(my_obj.h, my_obj.g_img.Width, my_obj.g_img.Height);

                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }

                for (int i = 0; i < my_obj.hn.Length; i++)
                {
                    Console.WriteLine("my_obj.hcn[i]: " + my_obj.hn[i] + " my_obj.hc[i]: " + my_obj.h[i]);
                    chart1.Series["Series1"].Points.AddXY(i, my_obj.hn[i]);
                    chart1.Series["Series1"].LegendText = "histogramme Normalisé";
                }

            }

        }

        private void lhistogrammeCumuléToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (my_obj.g_img == null)
            {
                MessageBox.Show("vous devez calculer l\'image gris avant d\'effectuer ce traitement", "pas d\'image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (my_obj.h == null)
                {
                    my_obj.fun_hs(my_obj.g_img);
                    
                }
                
                    my_obj.fun_hc(my_obj.h);
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }


                for (int i = 0; i < my_obj.hc.Length; i++)
                {
                    chart1.Series["Series1"].Points.AddXY(i, my_obj.hc[i]);
                    chart1.Series["Series1"].LegendText = "histogramme Cumulé";
                }

            }
        }

        private void lhistogrammeCumuléNormaliséToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (my_obj.g_img == null)
            {
                MessageBox.Show("vous devez calculer l\'image gris avant d\'effectuer ce traitement", "pas d\'image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (my_obj.hc == null)
                {
                    if (my_obj.h == null)
                    {
                        my_obj.fun_hs(my_obj.g_img);
                    }
                    my_obj.fun_hc(my_obj.h);

                }

                my_obj.fun_hcn(my_obj.hc, my_obj.g_img.Width, my_obj.g_img.Height);

                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                for (int i = 0; i < my_obj.hcn.Length; i++)
                {
                    
                    chart1.Series["Series1"].Points.AddXY(i, my_obj.hcn[i]);
                    chart1.Series["Series1"].LegendText = "histogramme Cumulé Normalisé";
                }

            }



        }

        private void laTranslationDhistogrammeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int tran_val;
            if (my_obj.g_img == null)
            {
                MessageBox.Show("vous devez calculer l\'image gris avant d\'effectuer ce traitement", "pas d\'image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (popup p = new popup())
                {
                    if (p.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        tran_val = p.tb_val;
                        my_obj.laTranslationDhistogramme(my_obj.g_img, tran_val);
                        pictureBox2.Image = my_obj.translation_img;
                        label4.Text = " " + (sender as ToolStripMenuItem).Text;
                    }
                }
            }



        }

        private void linversionDhistogrammeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (my_obj.g_img == null)
            {
                MessageBox.Show("vous devez calculer l\'image gris avant d\'effectuer ce traitement", "pas d\'image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                my_obj.linversionDhistogramme(my_obj.g_img);
                pictureBox2.Image = my_obj.inversion_img;
                label4.Text = " " + (sender as ToolStripMenuItem).Text;
                
            }

        }

        private void lexpansionDeDynamiqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (my_obj.g_img == null)
            {
                MessageBox.Show("vous devez calculer l\'image gris avant d\'effectuer ce traitement", "pas d\'image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                my_obj.lexpansionDeDynamique(my_obj.g_img, my_obj.max, my_obj.min);
                pictureBox2.Image = my_obj.Expansion_img;
                label4.Text = " " + (sender as ToolStripMenuItem).Text;

            }
        }

        private void egalisationDeLhistogrammeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (my_obj.g_img == null)
            {
                MessageBox.Show("vous devez calculer l\'image gris avant d\'effectuer ce traitement", "pas d\'image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                my_obj.fun_heq(my_obj.max, my_obj.hcn);
                my_obj.Egalisation(my_obj.heq,my_obj.g_img);
                pictureBox2.Image = my_obj.Egalisation_img;
                label4.Text = " " + (sender as ToolStripMenuItem).Text;

            }
        }

        
    }
}
