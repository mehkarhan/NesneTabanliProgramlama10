using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15122021_MODULsONUsORULARI_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayac, sonuc = 1;
                while (sayac < 6)
                {
                    sayac++;
                    sonuc *= sayac;
                    MessageBox.Show(sayac.ToString() + ".tur sonucu=" + sonuc.ToString());
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata bulundu");
            }
            
        }
    }
}
