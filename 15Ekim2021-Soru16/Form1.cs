using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15Ekim2021_Soru16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            // Dairenin Alanı ve Cevresini Hesaplama
            int yaricap = int.Parse(textBox1.Text);

            double pi = 3.14;

            //alanı= pi*r*r
            //cevresi= 2*pi*r

            double alan = pi * yaricap * yaricap;

            double cevre = 2 * pi * yaricap;
            //label4  --> cevresi
            // label5 --> alanı
            label4.Text = cevre.ToString();
            label5.Text = alan.ToString();

        }
    }
}
