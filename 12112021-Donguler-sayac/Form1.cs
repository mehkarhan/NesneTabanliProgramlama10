using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12112021_Donguler_sayac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            sayi += 5;  // sayi=sayi+5
            //sayi++  --> 1 artırma
            textBox1.Text = sayi.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            sayi -= 1;  //sayi=sayi-1
            //sayi--
            textBox1.Text = sayi.ToString();
        }
    }
}
