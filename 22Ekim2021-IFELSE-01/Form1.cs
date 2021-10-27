using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22Ekim2021_IFELSE_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);

            if (sayi%2==0)
            {
                label2.Text = "Girilen sayı Çifttir.";
            }
            else
            {
                label2.Text = "Girilen sayı Tektir.";
            }

        }
    }
}
