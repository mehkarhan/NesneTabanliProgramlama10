using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27Ekim2021_ICICEIF_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = "CerenU";
            string parola = "Samsun55";
            
            string kadi = textBox1.Text;
            string pass = textBox2.Text;

            if (kullaniciAdi==kadi || kullaniciAdi.ToUpper()==kadi || kullaniciAdi.ToLower()==kadi)
            {
                if (parola==pass)
                {
                    label4.Text = "Giriş Başarılı";
                }
                else
                {
                    label4.Text = "Parola Hatası";
                }
            }
            else
            {
                label4.Text = "Kullanıcı Adı yanlış";
            }
        }
    }
}
