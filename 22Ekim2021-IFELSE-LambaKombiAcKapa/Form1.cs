using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22Ekim2021_IFELSE_LambaKombiAcKapa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //*****Lamba aç kapa******
            if (chkLamba.Checked==true)
            {
                listBox1.Items.Add("Lamba Açık");
                listBox2.Items.Add(DateTime.Now);
            }
            else
            {
                listBox1.Items.Add("Lamba Kapalı");
                listBox2.Items.Add(DateTime.Now);
            }

            //***********Kombi Aç kapa***************
            if (chkKombi.Checked==true)
            {
                listBox1.Items.Add("Komni Açık");
                listBox2.Items.Add(DateTime.Now);
            }
            else
            {
                listBox1.Items.Add("Kombi Kapalı");
                listBox2.Items.Add(DateTime.Now);
            }


        }
    }
}
