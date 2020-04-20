using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Açı_derecelendirici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a;
        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            if (a==90)
            {
                label1.Text = "Dik Açı";
            }
            else if (a<90)
            {
                label1.Text = "Dar Açı";
            }
            else
            {
                label1.Text = "Geniş Açı";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
