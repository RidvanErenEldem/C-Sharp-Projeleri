using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Yakalamaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int zorluk;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button2.Visible = false;
            button1.Visible = false;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button2.Visible = true;
            button1.Visible = true;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(zorluk == 1)
            {
                MessageBox.Show( "Kolayda olsada başardın", "Eh işte", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (zorluk == 2)
            {
                MessageBox.Show( "İyi iş başardın birde şansını zorda dene","Helal!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (zorluk == 3)
            {
                MessageBox.Show( "Gerçekten de çok iyisin", "İnanılmaz!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show( "Senden daha iyisi yok", "Çılgınsın!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zorluk = 1;
            timer1.Start();
            timer1.Interval = 1000;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button9.Enabled = true;
            button9.Visible = true;
            button8.Enabled = true;
            button8.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            button8.Left = r.Next(0, 900);
            button8.Top = r.Next(0, 900);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button2.Visible = false;
            button1.Visible = false;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            timer1.Stop();
            button8.Visible = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button9.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zorluk = 2;
            timer1.Start();
            timer1.Interval = 750;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button9.Enabled = true;
            button9.Visible = true;
            button8.Enabled = true;
            button8.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zorluk = 3;
            timer1.Start();
            timer1.Interval = 500;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button9.Enabled = true;
            button9.Visible = true;
            button8.Enabled = true;
            button8.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            zorluk = 4;
            timer1.Start();
            timer1.Interval = 250;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button9.Enabled = true;
            button9.Visible = true;
            button8.Enabled = true;
            button8.Visible = true;
        }
    }
}
