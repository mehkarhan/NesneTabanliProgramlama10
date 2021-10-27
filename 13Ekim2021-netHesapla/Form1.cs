using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13Ekim2021_netHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double matD, matY, matNet;
            double turkceD, turkceY, turkceNet;

            matD = double.Parse(textBox1.Text);
            matY = double.Parse(textBox3.Text);

            turkceD = double.Parse(textBox2.Text);
            turkceY = double.Parse(textBox4.Text);

            matNet = matD - matY / 4;
            turkceNet = turkceD - turkceY / 4;

            textBox5.Text = matNet.ToString();
            textBox6.Text = turkceNet.ToString();
        }
    }
}
