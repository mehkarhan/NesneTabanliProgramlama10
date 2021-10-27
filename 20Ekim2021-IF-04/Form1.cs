using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20Ekim2021_IF_04
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
                label1.Text = "Girilen sayı Çifttir.";
                label1.ForeColor = Color.Purple;
                groupBox1.BackColor = Color.Green;
            }
            if (sayi%2!=0)
            {
                label1.Text = "Girilen sayı Tektir.";
                label1.ForeColor = Color.Orange;
                groupBox1.BackColor = Color.Blue;
            }
        }
    }
}
