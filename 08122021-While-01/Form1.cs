using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08122021_While_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
            


        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            string musteri = textBox1.Text;
            int say = listBox1.Items.Count;
            int i = 0;
            while(i<say)
            {
                if (listBox1.Items[i].ToString().ToLower() == musteri || listBox1.Items[i].ToString().ToUpper() == musteri)
                {
                    label4.Text = "Müşteri Bulundu";
                    label3.Text = listBox1.Items[i].ToString();
                    
                    break;
                }
                else
                {
                    //label4.Text = "Müşteri YOK";
                    //label3.Text = "";
                    if (i >= say)
                    {
                        listBox1.Items.Add(musteri);
                    }
                }
                i++;   
            }
            //**********************************************************************************************
            // for ile yapımı
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    if (listBox1.Items[i].ToString().ToLower()==musteri || listBox1.Items[i].ToString().ToUpper() == musteri)
            //    {
            //        label4.Text = "Müşteri Bulundu";
            //        label3.Text = listBox1.Items[i].ToString();
            //        break;
            //    }
            //    else
            //    {
            //        label4.Text = "Müşteri YOK";
            //        label3.Text = "";
            //    }
            //}

        }
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //label5.Text = listBox1.SelectedItem.ToString();
            //label6.Text = listBox1.SelectedIndex.ToString();
            textBox1.Text = listBox1.SelectedItem.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string guncel = textBox1.Text;
            int indekslist = listBox1.SelectedIndex;
            listBox1.Items[indekslist] = guncel;
        }
    }
}
