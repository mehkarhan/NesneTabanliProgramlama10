using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01122021_for_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            label5.Text = listBox1.Items.Count.ToString();
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count>0)
            {
                if (listBox1.SelectedItem!=null)
                {
                    listBox2.Items.Add(listBox1.SelectedItem.ToString());
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    label6.Text = listBox2.Items.Count.ToString();
                    label5.Text = listBox1.Items.Count.ToString();
                }
                else
                {
                    MessageBox.Show("Seçim Yapmadınız.");
                }
                
            }
            else
            {
                MessageBox.Show("Parça Bulunamadı");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                if (listBox1.SelectedItem != null)
                {
                    listBox3.Items.Add(listBox1.SelectedItem.ToString());
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    label7.Text = listBox1.Items.Count.ToString();
                    label5.Text = listBox1.Items.Count.ToString();
                }
                else
                {
                    MessageBox.Show("Seçim Yapmadınız.");
                }

            }
            else
            {
                MessageBox.Show("Parça Bulunamadı");
            }
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.label5.Text = listBox1.Items.Count.ToString();
            this.label6.Text = listBox2.Items.Count.ToString();
            this.label7.Text = listBox3.Items.Count.ToString();
           

        }
    }
}
