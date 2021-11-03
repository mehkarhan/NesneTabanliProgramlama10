using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03112021_switchCase_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gun = int.Parse(textBox1.Text);
            switch (gun)
            {
                case 1:
                    label2.Text = "Pazartesi";
                    break;
                case 2:
                    label2.Text = "Salı";
                    break;
                case 3:
                    label2.Text = "Çarşamba";
                    break;
                case 4:
                    label2.Text = "Perşembe";
                    break;
                case 5:
                    label2.Text = "Cuma";
                    break;
                case 6:
                    label2.Text = "Cumartesi";
                    break;
                case 7:
                    label2.Text = "Pazar";
                    break;
                default:
                    label2.Text = "Hatalı gün ";
                    break;
            }

            
        }
    }
}
