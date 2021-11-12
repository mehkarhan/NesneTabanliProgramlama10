using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10112021_Form_BackCOlor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                this.BackColor = Color.Black;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
                radioButton3.ForeColor = Color.White;
                radioButton4.ForeColor = Color.White;
            }
            if (radioButton2.Checked == true)
            {
                this.BackColor = Color.White;
                radioButton1.ForeColor = Color.Black;
                radioButton2.ForeColor = Color.Black;
                radioButton3.ForeColor = Color.Black;
                radioButton4.ForeColor = Color.Black;
            }
            if (radioButton3.Checked == true)
            {
                this.BackColor = Color.Blue;
                radioButton1.ForeColor = Color.Purple;
                radioButton2.ForeColor = Color.Purple;
                radioButton3.ForeColor = Color.Purple;
                radioButton4.ForeColor = Color.Purple;
            }
            if (radioButton4.Checked == true)
            {
                this.BackColor = Color.Red;
                radioButton1.ForeColor = Color.Yellow;
                radioButton2.ForeColor = Color.Yellow;
                radioButton3.ForeColor = Color.Yellow;
                radioButton4.ForeColor = Color.Yellow;
            }
        }
    }
}
