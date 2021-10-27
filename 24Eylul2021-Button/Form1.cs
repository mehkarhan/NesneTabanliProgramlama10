using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24Eylul2021_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button1 e tıkladınız");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button2 e tıkladınız");
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Fare üzerinde");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Fare üzerinde değil");
        }
        private void button1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("2 kere tıkla");
        }
    }
}
