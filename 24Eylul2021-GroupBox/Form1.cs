using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24Eylul2021_GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = Color.Purple;
        }
    }
}
