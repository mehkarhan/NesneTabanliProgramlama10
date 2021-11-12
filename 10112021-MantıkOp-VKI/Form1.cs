using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10112021_MantıkOp_VKI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kilo = double.Parse(textBox1.Text);
            double boy = double.Parse(textBox2.Text);

            double vki = kilo / (boy * boy);

            label3.Text = vki.ToString();

            if (vki<18.5)
            {
                label6.Text = "İdeal Kilonun Altındasın";
            }
            else if (vki>=18.5 && vki<25)
            {
                label6.Text = "İdeal Kilodasınız";
            }
            else if (vki >= 25 && vki < 30)
            {
                label6.Text = "İdeal Kilonun Üzerindesin";
            }
            else //if(vki>=30)
            {
                label6.Text = "İdeal Kilonun Çok Üzerindesin";
            }


        }
    }
}
