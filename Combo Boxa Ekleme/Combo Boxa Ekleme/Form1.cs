using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo_Boxa_Ekleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(comboBox1.SelectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Rıdvan"); comboBox1.Items.Add("Muhammet"); comboBox1.Items.Add("Asrın"); comboBox1.Items.Add("Hüseyin"); comboBox1.Items.Add("Tuğran");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Add(textBox1.Text);
        }
    }
}
