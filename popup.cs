using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_tp
{
    public partial class popup : Form
    {
        public int tb_val { set; get; }
        
        public popup()
        {
            InitializeComponent();
            tb_val = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tb_val = trackBar1.Value;
            label2.Text=("Valeur: " + trackBar1.Value.ToString());
        }
    }
}
