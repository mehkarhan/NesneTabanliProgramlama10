using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05112021_MantıksalOpAnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secim = comboBox1.SelectedIndex;

            if (secim>=0 && secim<4)
            {
                label1.Text = "İlkokul kademesi";
            }
            else if (secim>=4 && secim<8)
            {
                label1.Text = "Ortaokul Kademesi";
            }
            else if (secim>=8 && secim<12)
            {
                label1.Text = "Lise Kademesi";
            }
        }
    }
}
