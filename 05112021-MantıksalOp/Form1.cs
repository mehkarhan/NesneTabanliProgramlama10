using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05112021_MantıksalOp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yas = 16;
            string kadi = "husnanur";
            string parola = "PelinA";
            if (kadi=="husnanur" && parola=="PelinA" && yas>=15)
            {
                label1.Text = "Sisteme Giriş Başarılı";
            }
            else
            {
                label1.Text = "Hatalı Kullanıcı,parola veya yaş girişi";
            }
        }
    }
}
