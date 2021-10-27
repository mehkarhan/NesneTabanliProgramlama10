using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22Eylul2021_Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstBxListele.Items.Add(txtEkle.Text);
            txtEkle.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstBxListele.Items.Remove(lstBxListele.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int sec = lstBxListele.SelectedIndex;
            //lstBxListele.SelectedItems[sec] = txtEkle.Text;
        }

        private void lstBxListele_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtEkle.Text = lstBxListele.SelectedItem.ToString();
        }
    }
}
