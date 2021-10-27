using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06Ekim2021_Uyg12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            // convert
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = int.Parse(textBox2.Text);

            int topla = sayi1 + sayi2;

            textBox3.Text = topla.ToString();


        }
    }
}
