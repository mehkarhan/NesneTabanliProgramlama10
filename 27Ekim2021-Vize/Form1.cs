using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27Ekim2021_Vize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize = double.Parse(textBox1.Text);
            double final = double.Parse(textBox2.Text);

            // vizenin %40   vize*40/100

            vize=vize*0.4;
            final = final * 0.6;
            double sonuc = vize + final;

            label8.Text = sonuc.ToString();
            if (sonuc>=50)
            {
                label5.Text = "Derste Başarılı";
                label5.ForeColor = Color.Green;
            }
            else
            {
                label5.Text = "Derste Başarısız.Dersten Kaldınız";
                label5.ForeColor = Color.Red;
            }
        }
    }
}
