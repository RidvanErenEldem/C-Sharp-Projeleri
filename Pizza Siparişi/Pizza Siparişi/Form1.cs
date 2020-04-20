using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Siparişi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ınce = 6, klasik = 8, peynir= 1.5, mantar = 1, zeytin = 1, sosis = 2 , sucuk = 2.5, domates = 1.25, biber = 2.25, ayran = 2, gazoz= 2, cay= 2, kola= 2.5, toplam=0;

            if(checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Hamur Seçmediniz", "Hamursuz pizza mı olur ?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(checkBox1.Checked == true )
            {
                toplam = toplam + ınce;
            }
            if (checkBox2.Checked == true)
            {
                toplam = toplam + klasik;
            }
            if (checkBox3.Checked == true)
            {
                toplam = toplam + peynir;
            }
            if (checkBox4.Checked == true)
            {
                toplam = toplam + mantar;
            }
            if (checkBox5.Checked == true)
            {
                toplam = toplam + zeytin;
            }
            if (checkBox6.Checked == true)
            {
                toplam = toplam + sosis;
            }
            if (checkBox7.Checked == true)
            {
                toplam = toplam + sucuk;
            }
            if (checkBox8.Checked == true)
            {
                toplam = toplam + domates;
            }
            if (checkBox9.Checked == true)
            {
                toplam = toplam + biber;
            }
            if (checkBox10.Checked == true)
            {
                toplam = toplam + ayran;
            }
            if (checkBox11.Checked == true)
            {
                toplam = toplam + gazoz;
            }
            if (checkBox12.Checked == true)
            {
                toplam = toplam + cay;
            }
            if (checkBox13.Checked == true)
            {
                toplam = toplam + kola;
            }
            if(checkBox1.Checked == true && checkBox2.Checked == true)
            {
                MessageBox.Show("Birden Fazla Hamur Seçilir Mi Hiç ?", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            label15.Text = toplam.ToString();



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }
    }
}
