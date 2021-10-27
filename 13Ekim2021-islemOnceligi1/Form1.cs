using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13Ekim2021_islemOnceligi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, topla;
            sayi1 = int.Parse(textBox1.Text);
            sayi2 = int.Parse(textBox2.Text);

            topla = sayi1 + sayi2;
            int sonuc = topla * 2 - 5;

            MessageBox.Show(sonuc.ToString());

        }
    }
}
