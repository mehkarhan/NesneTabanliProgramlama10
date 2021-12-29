using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15122021_Continue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 15;
            //while (i>15)
            //{

            //    listBox1.Items.Add(i);
            //    i++;

            //}
            do
            {
                listBox1.Items.Add(i);
                i++;
            } while (i<15);

        }
    }
}
