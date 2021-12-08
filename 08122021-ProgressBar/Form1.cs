using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08122021_ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yuzde = int.Parse(textBox1.Text);
            if (yuzde <=progressBar1.Maximum && yuzde>=progressBar1.Minimum )
            {
                progressBar1.Value = yuzde;
            }
            else
            {
                label2.Text="Geçerli aralıkta değer girmediniz";
            }
            
        }
    }
}
