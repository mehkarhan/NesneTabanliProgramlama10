using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20Ekim2021_IF_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yas;
            yas = Convert.ToInt32(textBox2.Text);  //sayıya çevirme
            //yas = int.Parse(textBox2.Text);
            if (yas>=18)
            {
                label4.Text = "Sayın " + textBox1.Text + ". Ehliyet Alabilirsiniz.";        
                label4.ForeColor = Color.Green;

            }
            if (yas<18)
            {
                label4.Text = "Sayın " + textBox1.Text + ". Ehliyet  Alamazsınız.";
               
                label4.ForeColor = Color.Red;
            }



            //int yas = int.Parse(textBox2.Text);

            //if (yas>=18)
            //{
            //    label4.Text = "Sayın " + textBox1.Text + ". Ehliyet Alabilirsiniz.";
            //    label4.ForeColor = Color.Green;
            //}
            //if (yas<18)
            //{
            //    label4.Text = "Sayın " + textBox1.Text + ". Ehliyet Alamazsınız";
            //    label4.ForeColor = Color.Red;

            //}
        }
    }
}
