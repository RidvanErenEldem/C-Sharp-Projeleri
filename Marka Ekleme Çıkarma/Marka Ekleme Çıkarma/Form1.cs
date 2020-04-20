using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marka_Ekleme_Çıkarma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!comboBox1.Items.Contains(textBox1.Text))
                comboBox1.Items.Add(textBox1.Text);
            else
                MessageBox.Show("Aynı Markadan 2 kez ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!listBox1.Items.Contains(comboBox1.Text))
                listBox1.Items.Add(comboBox1.SelectedItem);
            else
                MessageBox.Show("Aynı Markadan 2 kez ekleyemezsiniz","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
