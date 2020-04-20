using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_boxa_yazı_aktarma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void yazidan_resime()
        {
           
            var resim = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height); //resmin boyutlarını ayarlıyorum
            var grafik = Graphics.FromImage(resim); //grafik kısmını ayarlıyorum
            grafik.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit; //resmin kalitesini yükseltme
            grafik.DrawString(textBox1.Text, textBox1.Font, Brushes.AliceBlue, new Point(0, 0)); //resimi çizdiriyorum textboxt1 den alıyrum metni sonra textbox1 den fontunu alıyorum renginide ayarladıktan sonr başlangıç noktasını belirliyorum
            this.pictureBox1.Image = resim; //picturebox1 e resimi atıyorum
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Font Ayarları
            FontDialog tip = new FontDialog();
            tip.ShowDialog();
            textBox1.Font = tip.Font;
            yazidan_resime(); //burda da methodumu çağırıyorum ki font değiştiğinde picturebox da değişsin
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            yazidan_resime(); //textbox1 in texti değiştiğinde methodumu çağırıyorum ki anlık olarak picture boxa yazsın
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kaydetme kısmı
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp"; //kayıt türleri

            sfd.Title = "Kayıt"; //sol üst kısmında ne yazacağı

            sfd.FileName = "Adsız"; //varsayılan ad

            DialogResult sonuç = sfd.ShowDialog();

            if (sonuç == DialogResult.OK) // tamama bastığında kaydetmesi için
            {
                pictureBox1.Image.Save(sfd.FileName);
            }
        }
    }
}
