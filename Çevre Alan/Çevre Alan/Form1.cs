using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çevre_Alan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, alan , cevre;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Değer Girmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                a = Convert.ToInt32(textBox1.Text);

                alan = a * a;
                cevre = a * 4;

                label10.Text = cevre.ToString();
                label11.Text = alan.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b, c, alan, cevre;
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Değer Girmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                b = Convert.ToInt32(textBox2.Text);

                c = Convert.ToInt32(textBox3.Text);

                alan = b * c;
                cevre = b + c + b + c;

                label12.Text = alan.ToString();
                label13.Text = cevre.ToString();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar<= 57)
            {
                e.Handled = false;
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
    


}
