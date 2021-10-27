using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15Ekim2021_if01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int takim1 = int.Parse(textBox1.Text); //sayıya çevirme işlemi
            int takim2 = int.Parse(textBox2.Text);

            if (takim1>takim2)  // Eğer takım1 kazandıysa
            {
                label5.Text = "Takım-1";
                label5.ForeColor = Color.Red;
                label6.Text = takim1.ToString() + " - " + takim2.ToString();
                label6.ForeColor = Color.Red;
            }
            if (takim1 < takim2)  //eğer takım2 kazandıysa
            {
                label5.Text = "Takım-2";
                label5.ForeColor = Color.Blue;
                label6.Text = takim1.ToString() + " - " + takim2.ToString();
                label6.ForeColor = Color.Blue;
            }
            if (takim1==takim2)
            {
                label5.Text = "Berabere kaldı";
                label5.ForeColor = Color.Yellow;
                label6.Text = takim1.ToString() + " - " + takim2.ToString();
                label6.ForeColor = Color.Yellow;
            }

        }
    }
}
