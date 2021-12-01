using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01122021_For_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int baslangic = int.Parse(textBox1.Text);
            int son = int.Parse(textBox2.Text);
            int adim = int.Parse(textBox3.Text);

            for (int i = baslangic; i <= son; i+=adim)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
