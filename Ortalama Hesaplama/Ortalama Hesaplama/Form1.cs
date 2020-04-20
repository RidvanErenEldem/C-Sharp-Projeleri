using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ortalama_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Boş girdi var", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double yazili1, yazili2, perfomans1, performans2, ortalama, toplama;

                yazili1 = Convert.ToDouble(textBox1.Text);
                yazili2 = Convert.ToDouble(textBox2.Text);
                perfomans1 = Convert.ToDouble(textBox3.Text);
                performans2 = Convert.ToDouble(textBox4.Text);
                toplama = yazili1 + yazili2 + perfomans1 + performans2;

                ortalama = toplama / 4;

                label7.Text = ortalama.ToString();
                
                if(ortalama < 50)
                {
                    label8.Text = "KALDIN";
                    label8.ForeColor = Color.Red;
                }
                else
                {
                    label8.Text = "GEÇTİN";
                    label8.ForeColor = Color.Green;
                }
               
            }
        }
    }
}
