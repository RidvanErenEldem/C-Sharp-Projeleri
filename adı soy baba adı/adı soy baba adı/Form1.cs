using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adı_soy_baba_adı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add(textBox2.Text);
                listBox3.Items.Add(textBox3.Text);
            }
            else
            {
                MessageBox.Show("Hata", "Hepsini Doldurmadım", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                listBox3.Items.RemoveAt(listBox3.SelectedIndex);
            }
        }
    }
}
