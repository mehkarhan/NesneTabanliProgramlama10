using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03112021_ICICEIF_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double urun1 = double.Parse(txtUrun1.Text);
            double urun2 = double.Parse(txtUrun2.Text);

            double toplam = urun1 + urun2;

            if (toplam>=200)
            {
                label6.Text = toplam.ToString();
                if (urun1>urun2)
                {
                    //double indirim = urun2 - urun2 * 0.25;
                    //lblindirimMiktari.Text = (urun2 * 0, 25).ToString();
                    double indirimMiktari = urun2 * 0.25;
                    double indirim = urun2 - indirimMiktari;
                    lblindirimMiktari.Text = indirimMiktari.ToString();

                    toplam = urun1 + indirim;
                    lblToplam.Text = toplam.ToString();
                }
                else
                {
                    double indirimMiktari = urun1 * 0.25;
                    double indirim = urun1 - indirimMiktari;
                    lblindirimMiktari.Text = indirimMiktari.ToString();

                    toplam = urun2 + indirim;
                    lblToplam.Text = toplam.ToString();
                }
            }
            else
            {
                lblindirimMiktari.Text = "İndirim yok";
                lblToplam.Text = toplam.ToString();
                label4.Visible = false;
                label6.Visible = false;
            }
        }
    }
}
