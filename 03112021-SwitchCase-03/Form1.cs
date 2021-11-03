using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03112021_SwitchCase_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int harfNo =comboBox1.SelectedIndex;
            label1.Text = comboBox1.SelectedItem.ToString()+" harfi, Alfabemizin "+(harfNo+1)+". harfidir";
            

        }
    }
}
