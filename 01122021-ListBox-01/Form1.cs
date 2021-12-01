using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01122021_ListBox_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem!=null)  //Listboxta item seçildiğinde çalışır
            {
                listBox2.Items.Add(listBox1.SelectedItem); //item ekleme
                listBox1.Items.Remove(listBox1.SelectedItem); //seçili nesneyi siler
                label1.Text = listBox1.Items.Count.ToString();
                label2.Text = listBox2.Items.Count.ToString();
            }
            else  //item seçili değilse burası çalışır
            {
                MessageBox.Show("Seçmediniz");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = listBox1.Items.Count.ToString();
            this.label2.Text = listBox2.Items.Count.ToString();
        }
    }
}
