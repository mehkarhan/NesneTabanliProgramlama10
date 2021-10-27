using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06Ekim2021_Dortislem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;

            sayi1 = int.Parse(textBox1.Text);
            sayi2 = int.Parse(textBox2.Text);

            sonuc = sayi1 + sayi2;

            label3.Text = "Toplam :";
            label4.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;

            sayi1 = int.Parse(textBox1.Text);
            sayi2 = int.Parse(textBox2.Text);

            sonuc = sayi1 - sayi2;
            label3.Text = "Çıkarma :";
            label4.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;

            sayi1 = int.Parse(textBox1.Text);
            sayi2 = int.Parse(textBox2.Text);

            sonuc = sayi1 * sayi2;
            label3.Text = "Çarpma :";
            label4.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;

            sayi1 = int.Parse(textBox1.Text);
            sayi2 = int.Parse(textBox2.Text);

            sonuc = sayi1 / sayi2;
            label3.Text = "Bölme :";
            label4.Text = sonuc.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;

            sayi1 = int.Parse(textBox1.Text);
            sayi2 = int.Parse(textBox2.Text);

            sonuc = sayi1 % sayi2;
            label3.Text = "Mod :";
            label4.Text = sonuc.ToString();
        }
    }
}
