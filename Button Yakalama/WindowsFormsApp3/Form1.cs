using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            button1.Left = r.Next(0, 400);
            button1.Top = r.Next(0, 400);
        }
    }
}
