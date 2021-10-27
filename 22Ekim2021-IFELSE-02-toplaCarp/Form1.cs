using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22Ekim2021_IFELSE_02_toplaCarp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                    int sayi1 = int.Parse(textBox1.Text);
                    int sayi2 = int.Parse(textBox2.Text);

                    if (radioButton1.Checked == true)
                    {
                        //label4.Text = (sayi1 + sayi2).ToString();
                        int sonuc = sayi1 + sayi2;
                        label4.Text = sonuc.ToString();
                    }
                    else if (radioButton2.Checked == true)
                    {
                        int sonuc = sayi1 - sayi2;
                        label4.Text = sonuc.ToString();
                    }
                    else if (radioButton3.Checked == true)
                    {
                        int sonuc = sayi1 * sayi2;
                        label4.Text = sonuc.ToString();
                    }
                    else if (radioButton4.Checked == true)
                    {
                        double sonuc = (double)sayi1 / sayi2;
                        label4.Text = sonuc.ToString();
                    }
                    else if (radioButton5.Checked == true)
                    {
                        int sonuc = sayi1 % sayi2;
                        label4.Text = sonuc.ToString();
                    }
                    else
                    {
                        label4.Text = "İşlem seçmediniz.";
                        label4.ForeColor = Color.Red;
                    }
                }
                
            
        }
    }
