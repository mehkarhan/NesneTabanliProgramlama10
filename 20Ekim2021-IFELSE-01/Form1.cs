using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20Ekim2021_IFELSE_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;

            if (kullaniciAdi=="mehmet" || kullaniciAdi=="Mehmet"  || kullaniciAdi=="MEHMET")  
            {
                label2.Visible = false;
                MessageBox.Show("Tebrikler. Anasayfaya yönlendiriliyorsunuz.");
                
            }
            else
            {
                label2.Visible = true;
                label2.Text = "* Hatalı Kullanıcı Adı";
            }
        }
    }
}
