using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.Red;

            progressBar1.Value = 0;

            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                
            }
        }
    }
}
