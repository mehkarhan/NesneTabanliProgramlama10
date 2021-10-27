using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13Ekim2021_indirimliUrun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int etiketFiyati,indirimliFiyat;

            etiketFiyati = int.Parse(textBox1.Text);

            indirimliFiyat = etiketFiyati - etiketFiyati * 10 / 100;

            // ef=100   indOran=10       ef-100*10/100 -->  100-10=90

            label3.Text = indirimliFiyat.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int etiketFiyati, indirimliFiyat;

            etiketFiyati = int.Parse(textBox1.Text);

            indirimliFiyat = etiketFiyati - etiketFiyati * 75 / 100;

            label3.Text = indirimliFiyat.ToString();
        }
    }
}
