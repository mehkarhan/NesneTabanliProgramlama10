using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15Ekim2021_Soru15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //KDV hesapla -- %18 hesapla
            double sayi = double.Parse(textBox1.Text);

            double kdvHesapla=sayi*0.18;

            double kdvHesapla2 = sayi * 18 / 100;

            //MessageBox.Show(kdvHesapla.ToString());
            //MessageBox.Show(kdvHesapla2.ToString());

            label1.Text = kdvHesapla.ToString();
        }
    }
}
