using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şehirler_ve_İlçeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                comboBox2.Visible = true;
                comboBox2.Enabled = true;
                comboBox3.Visible = false;
                comboBox3.Enabled = false;
                comboBox4.Visible = false;
                comboBox4.Enabled = false;
                comboBox5.Visible = false;
                comboBox5.Enabled = false;
            }
            if(comboBox1.SelectedIndex == 1)
            {
                comboBox3.Visible = true;
                comboBox3.Enabled = true;
                comboBox2.Visible = false;
                comboBox2.Enabled = false;
                comboBox4.Visible = false;
                comboBox4.Enabled = false;
                comboBox5.Visible = false;
                comboBox5.Enabled = false;
            }
            if(comboBox1.SelectedIndex == 2)
            {
                comboBox4.Visible = true;
                comboBox4.Enabled = true;
                comboBox2.Visible = false;
                comboBox2.Enabled = false;
                comboBox3.Visible = false;
                comboBox3.Enabled = false;
                comboBox5.Visible = false;
                comboBox5.Enabled = false;
            }
            if(comboBox1.SelectedIndex == 3)
            {
                comboBox5.Visible = true;
                comboBox5.Enabled = true;
                comboBox2.Visible = false;
                comboBox2.Enabled = false;
                comboBox3.Visible = false;
                comboBox3.Enabled = false;
                comboBox4.Visible = false;
                comboBox4.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Konya"); comboBox1.Items.Add("Ankara"); comboBox1.Items.Add("Antalya"); comboBox1.Items.Add("İstanbul");
            comboBox2.Items.Add("Selçuklu"); comboBox2.Items.Add("Karatay"); comboBox2.Items.Add("Meram");comboBox3.Items.Add("Beypazarı"); comboBox3.Items.Add("Çankaya"); comboBox3.Items.Add("Polatlı");
            comboBox4.Items.Add("Aksu"); comboBox4.Items.Add("Gazipaşa"); comboBox4.Items.Add("Konyaaltı"); comboBox5.Items.Add("Levent"); comboBox5.Items.Add("Kağıthane"); comboBox5.Items.Add("Beşiktaş");
        }
    }
}
