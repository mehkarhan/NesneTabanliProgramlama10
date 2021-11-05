using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05112021_KararSesBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int sesDegeri = trackBar1.Value;
            
           
            if (sesDegeri==0)
            {
                
                label1.Text = "Ses Yok";
                label1.ForeColor = Color.Black;
            }
            else if (sesDegeri>0 && sesDegeri<=10)
            {
                label1.Text = "Normal Ses Seviyesi";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "Yüksek Ses Seviyesi";
                label1.ForeColor = Color.Red;
            }
            
        }
    }
}
