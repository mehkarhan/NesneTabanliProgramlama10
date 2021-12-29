using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22122021_Form_Metod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);

            BuyukSayiBul(sayi1, sayi2); 

        }
        private void BuyukSayiBul(int a,int b)
        {
            if (a > b)
            {
                label4.Text = a.ToString();
            }
            else
            {
                label4.Text = b.ToString();
            }
        }
        private void Carp(int a,int b)
        {
            label4.Text = (a * b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            Carp(sayi1,sayi2);
        }
    }
}
