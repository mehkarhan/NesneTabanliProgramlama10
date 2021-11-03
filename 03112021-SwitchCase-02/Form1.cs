using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03112021_SwitchCase_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay = int.Parse(textBox1.Text);
                switch (ay)
                {
                    
                    case 12: case 1: case 2:
                        label3.Visible = false;
                        label2.Text = "Kış Mevsimi";
                        label2.ForeColor = Color.Blue;
                        break;
                    case 3: case 4:
                    case 5:
                        label3.Visible = false;
                        label2.Text = "İlkbahar Mevsimi";
                        label2.ForeColor = Color.Green;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        label3.Visible = false;
                        label2.Text = "Yaz Mevsimi";
                        label2.ForeColor = Color.Yellow;
                        break;
                    case 9:
                    case 10:
                    case 11:
                        label3.Visible = false;
                        label2.Text = "Sonbahar Mevsimi";
                        label2.ForeColor = Color.Coral;
                        break;
                    default:
                        label3.Visible = true;
                        label3.Text = "1-12 arası sayı giriniz.";
                        break;
                }

            
            
        }
    }
}
