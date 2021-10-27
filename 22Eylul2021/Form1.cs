using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22Eylul2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("GÜNAYDIN","Mehmet KARAHAN",MessageBoxButtons.YesNoCancel);
            textBox1.Text = "Selam Pelin AYDIN. Kahvaltı yapmadan gelme.";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "Günaydın TUANA. Okula gelirken kahvaltı yapmalısın";
            textBox1.ForeColor = Color.OrangeRed;
            //textBox1.Visible = false;
            textBox1.Enabled = true;
            
           
            label1.Text = "Günaydın CerenU. Kahvaltı Önemlidir.";
            //MessageBox.Show
        }
    }
}
