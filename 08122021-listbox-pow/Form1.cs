using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08122021_listbox_pow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(textBox1.Text);
            double us = double.Parse(textBox2.Text);

            //double kuvvet = Math.Pow(sayi,us);
            //listBox1.Items.Add(kuvvet);

            for (int i = 0; i <= us; i++)
            {
                double kuvvet = Math.Pow(sayi, i);
                listBox1.Items.Add(kuvvet);
                //listBox1.Items.Add(sayi + " sayısının " + i + ".kuvvet :" + kuvvet);
            }
        }
    }
}
