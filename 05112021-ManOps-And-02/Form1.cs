using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05112021_ManOps_And_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy = double.Parse(textBox1.Text);
            double kilo = double.Parse(textBox2.Text);
            //label1.Text = (boy*boy).ToString();
            double vki = kilo / (boy*boy);
            label6.Text = vki.ToString();

            if (vki<18.5)
            {
                label4.Text = "İdeal Kilonun Altındasınız.";
                Form1.ActiveForm.BackColor = Color.GreenYellow;
            }
            else if (vki>=18.5 && vki<25)
            {
                label4.Text = "İdeal Kilo";
                Form1.ActiveForm.BackColor = Color.Green;
            }
            else if (vki>=25 && vki<30)
            {
                label4.Text = "İdeal Kilonun Üzerinde";
                Form1.ActiveForm.BackColor = Color.Orange;
            }
            else
            {
                label4.Text = "İdeal kilonun Çok Üzeri(Obezite)";
                Form1.ActiveForm.BackColor = Color.Red;
            }


        }
    }
}
