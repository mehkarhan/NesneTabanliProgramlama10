using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27Ekim2021_ElseIf_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(textBox1.Text);
            if (sayi < 0)
            {
                label1.Text = "0'dan küçük not girdiniz";
            }
            else if (sayi < 25)
            {
                label1.Text = "Notunuz 0";
            }
            else if (sayi < 50)
            {
                label1.Text = "Notunuz 1";
            }
            else if (sayi < 60)
            {
                label1.Text = "Notunuz 2";
            }
            else if (sayi < 70)
            {
                label1.Text = "Notunuz 3";
            }
            else if (sayi < 85)
            {
                label1.Text = "Notunuz 4";
            }
            else if (sayi <= 100)
            {
                label1.Text = "Notunuz 5";
            }
            else
            {
                label1.Text = "100'den büyük not girdiniz";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi =double.Parse( textBox1.Text);

            if (sayi<0 || sayi>100)
            {
                label1.Text = "Hatalı Not Girişi";
            }
            else if (sayi>=85)
            {
                label1.Text = "5";
            }
            else if (sayi >= 70)
            {
                label1.Text = "5";
            }
            else if (sayi >= 60)
            {
                label1.Text = "5";
            }
            else if (sayi >= 50)
            {
                label1.Text = "5";
            }
            else if (sayi >= 25)
            {
                label1.Text = "5";
            }
            else
            {
                label1.Text = "0";
            }
        }
    }
}
