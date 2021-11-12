using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10112021_OR_Odeme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double aylik;
            double ode = double.Parse(textBox1.Text);

            if(radioButton1.Checked==true)
            {
                this.BackColor = Color.Green;
                label3.Text = ode.ToString() + "TL";
                label4.Visible = false;
                label5.Visible = false;
            }
            if (radioButton2.Checked==true || radioButton3.Checked==true)
            {
                label4.Visible = true;
                label5.Visible = true;
                ode = ode * 1.05;
                label3.Text = ode.ToString() + "TL";
                if (radioButton2.Checked==true)
                {
                    aylik = ode / 2;
                    label5.Text = aylik.ToString() + "TL";
                }
                else
                {
                    aylik = ode / 3;
                    label5.Text = aylik.ToString() + "TL";
                }
            }
            if (radioButton4.Checked==true || radioButton5.Checked==true)
            {
                label4.Visible = true;
                label5.Visible = true;
                ode = ode * 1.10;
                label3.Text = ode.ToString() + "TL";
                if (radioButton4.Checked == true)
                {
                    aylik = ode / 4;
                    label5.Text = aylik.ToString()+" TL";
                }
                else
                {
                    aylik = ode / 5;
                    label5.Text = aylik.ToString()+"TL";
                }
            }
            
        }

        //private void groupBox1_Enter(object sender, EventArgs e)
        //{

        //}
    }
}
