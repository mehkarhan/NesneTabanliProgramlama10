using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10112021_mantikOp_BuyukKucukSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            int sayi3 = int.Parse(textBox3.Text);

            if (sayi1>sayi2)
            {
                if (sayi1>sayi3)
                {
                    label6.Text = sayi1.ToString();
                    if (sayi2>sayi3)
                    {
                        label8.Text = sayi3.ToString();
                    }
                    else
                    {
                        label8.Text = sayi2.ToString();
                    }
                }
                else
                {
                    label6.Text = sayi3.ToString();
                    label8.Text = sayi2.ToString();
                }

            }
            else
            {
                if (sayi2>sayi3)
                {
                    label6.Text = sayi2.ToString();
                    if (sayi3>sayi1)
                    {
                        label8.Text = sayi1.ToString();
                    }
                    else
                    {
                        label8.Text = sayi3.ToString();
                    }
                }
                else
                {
                    label6.Text = sayi3.ToString();
                    label8.Text = sayi1.ToString();
                }
                
            }

        }
    }
}
