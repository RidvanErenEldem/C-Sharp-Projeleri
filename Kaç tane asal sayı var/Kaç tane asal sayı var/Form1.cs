using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaç_tane_asal_sayı_var
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int start, over;
            start = Convert.ToInt32(textBox1.Text);
            over = Convert.ToInt32(textBox2.Text);
            int num = start;
            bool stat = true;
            while(num < over)
            {
                num++;
                for (int i = 2; i < num; i++)
                {
                    if(num % i == 0)
                    {
                        stat = false;
                    }
                }
                if (stat == true && num != 1)
                {
                    listBox1.Items.Add(num.ToString());
                }
                stat = true;
            }
            MessageBox.Show(listBox1.Items.Count.ToString() + " Adet asal sayı var", "Adet", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
