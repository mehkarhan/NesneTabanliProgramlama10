using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20Ekim2021_IF_03
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

            if (sayi1>sayi2)
            {
                label4.Text = "1.sayı büyüktür.";
            }
            if (sayi1<sayi2)
            {
                label4.Text = "2.sayı büyüktür.";
            }
            if (sayi1==sayi2)
            {
                label4.Text = " 2 sayıda eşittir.";
            }
        }
    }
}
