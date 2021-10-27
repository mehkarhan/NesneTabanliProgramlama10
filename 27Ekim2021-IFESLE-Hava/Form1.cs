using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27Ekim2021_IFESLE_Hava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hava = int.Parse(textBox1.Text); // sayıya cevirme

            if (hava<10)
            {
                label2.Text = "Hava soğuk";
                label2.ForeColor = Color.Blue;
            }
            else if (hava>25)
            {
                label2.Text = "Hava Sıcak";
                label2.ForeColor = Color.Red;
            }
            else
            {
                label2.Text = "Hava Ilıman";
                label2.ForeColor = Color.Orange;
            }
        }
    }
}
