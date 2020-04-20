using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullanıcı_giriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "riot" && textBox2.Text == "thanos")
            {
                MessageBox.Show("Giriş Yapıldı", "Başarlı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre yi yanlış giridiniz", "Hatalı giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkış", "Emin misin ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Çıkış yapamadın", "KEL");
            }
            
        }
    }
}
