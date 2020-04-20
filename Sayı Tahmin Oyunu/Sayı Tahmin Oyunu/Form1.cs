using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_Tahmin_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random(); 
        int b;
        private void button2_Click(object sender, EventArgs e)
        {
            b = rnd.Next(0, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;

            a = Convert.ToInt32(textBox1.Text);

            if(a==b)
            {
                MessageBox.Show("You are goddamn right !!!", "Congrats",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (a<b)
            {
                label1.Text = "Biraz Yükselt";
            }
            else
            {
                label1.Text = "Biraz Düşür";
            }
        }
    }
}
