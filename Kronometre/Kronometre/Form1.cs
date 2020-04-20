using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dakika = 0, saniye = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            timer1.Start();
            dakika = 0;
            saniye = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if(saniye == 60)
            {
                dakika++;
                saniye = 0;
            }
            label2.Text = Convert.ToString(dakika);
            label4.Text = Convert.ToString(saniye);
            progressBar1.Value = dakika;
            progressBar2.Value = saniye;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            progressBar1.Maximum = 59;
            progressBar2.Maximum = 59;
        }
    }
}
