using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_Dönüşümleri
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        Button[] btns = new Button[10];
        
        
        private void main_Load(object sender, EventArgs e) /* yeni yöntem  178 satır daha az kod*/
        {
            Button[] btns = { bir, iki, uc, dort, bes, altı, yedi, sekiz, dokuz, sıfır, A,B,C,D,E,F };
            for (int i = 0; i < 16; i++)
            {
                btns[i].Click += button_click;
            }

        }

        public void button_click(object sender, EventArgs e)
        {
            Button btns = (Button)sender;
            sayi_girisi.Text += btns.Text;
        }

        /*private void bir_Click(object sender, EventArgs e)
        {
            sayi_girisi.Text += "1";
        }

        private void iki_Click(object sender, EventArgs e)
        {
            sayi_girisi.Text += "2";
        }

        private void uc_Click(object sender, EventArgs e)
        {
            sayi_girisi.Text += "3";
        }

        private void dort_Click(object sender, EventArgs e)
        {
            sayi_girisi.Text += "4";
        }

        private void bes_Click(object sender, EventArgs e)
        {
            sayi_girisi.Text += "5";
        }

        private void altı_Click(object sender, EventArgs e)
        {
            sayi_girisi.Text += "6";
        }

        private void yedi_Click(object sender, EventArgs e)
        {
            sayi_girisi.Text += "7";
        }

        private void sekiz_Click(object sender, EventArgs e)
        {
            sayi_girisi.Text += "8";
        }

        private void dokuz_Click(object sender, EventArgs e)
        {
            sayi_girisi.Text += "9";
        }

        private void sıfır_Click(object sender, EventArgs e)
        {
            sayi_girisi.Text += "0";
        } 

        private void A_Click(object sender, EventArgs e)
        {
            sayi_girisi.Text += "A";
        }

        private void B_Click(object sender, EventArgs e)
        {
            sayi_girisi.Text += "B";
        }

        private void C_Click(object sender, EventArgs e)
        {
            sayi_girisi.Text += "C";
        }

        private void D_Click(object sender, EventArgs e)
        {
            sayi_girisi.Text += "D";
        }

        private void E_Click(object sender, EventArgs e)
        {
            sayi_girisi.Text += "E";
        }

        private void F_Click(object sender, EventArgs e)
        {
            sayi_girisi.Text += "F";
        } eski yöntem */

        private void ikilik_1_CheckedChanged(object sender, EventArgs e)
        {
            if(ikilik_1.Checked == true)
            {
                Button[] btns = { sıfır, bir, iki, uc, dort, bes, altı, yedi, sekiz, dokuz,  A, B, C, D, E, F };
                sayi_girisi.Text = "";
                /*bir.Enabled = true;
                sıfır.Enabled = true; 
                iki.Enabled = false;
                uc.Enabled = false;
                dort.Enabled = false;
                bes.Enabled = false;
                altı.Enabled = false;
                yedi.Enabled = false;
                sekiz.Enabled = false;
                dokuz.Enabled = false;
                A.Enabled = false;
                B.Enabled = false;
                C.Enabled = false;
                D.Enabled = false;
                E.Enabled = false;
                F.Enabled = false; eski yöntem */
                for(int i = 0; i< 16; i++) 
                {
                    if (i < 2)
                        btns[i].Enabled = true;
                    else
                        btns[i].Enabled = false;
                }
                
            }
        }

        private void sekizlik_1_CheckedChanged(object sender, EventArgs e)
        {
            if(sekizlik_1.Checked == true)
            {
                sayi_girisi.Text = "";
                Button[] btns = { sıfır, bir, iki, uc, dort, bes, altı, yedi, sekiz, dokuz,  A, B, C, D, E, F };
                /*bir.Enabled = true;
                sıfır.Enabled = true;
                iki.Enabled = true;
                uc.Enabled = true;
                dort.Enabled = true;
                bes.Enabled = true;
                altı.Enabled = true;
                yedi.Enabled = true;
                sekiz.Enabled = false;
                dokuz.Enabled = false;
                A.Enabled = false;
                B.Enabled = false;
                C.Enabled = false;
                D.Enabled = false;
                E.Enabled = false;
                F.Enabled = false; */
                for (int i = 0; i < 16; i++)
                {
                    if (i < 8)
                        btns[i].Enabled = true;
                    else
                        btns[i].Enabled = false;
                }
            }
        }

        private void onluk_1_CheckedChanged(object sender, EventArgs e)
        {
            if(onluk_1.Checked == true)
            {
                sayi_girisi.Text = "";
                Button[] btns = { sıfır, bir, iki, uc, dort, bes, altı, yedi, sekiz, dokuz,  A, B, C, D, E, F };
                /*bir.Enabled = true;
                sıfır.Enabled = true;
                iki.Enabled = true;
                uc.Enabled = true;
                dort.Enabled = true;
                bes.Enabled = true;
                altı.Enabled = true;
                yedi.Enabled = true;
                sekiz.Enabled = true;
                dokuz.Enabled = true;
                A.Enabled = false;
                B.Enabled = false;
                C.Enabled = false;
                D.Enabled = false;
                E.Enabled = false;
                F.Enabled = false; */
                for(int i = 0; i <16; i++)
                {
                    if (i < 10)
                        btns[i].Enabled = true;
                    else
                        btns[i].Enabled = false;
                }
            }
        }

        private void onaltılık_1_CheckedChanged(object sender, EventArgs e)
        {
            if(onaltılık_1.Checked == true)
            {
                sayi_girisi.Text = "";
                Button[] btns = { sıfır, bir, iki, uc, dort, bes, altı, yedi, sekiz, dokuz, A, B, C, D, E, F };
                /*bir.Enabled = true;
                sıfır.Enabled = true;
                iki.Enabled = true;
                uc.Enabled = true;
                dort.Enabled = true;
                bes.Enabled = true;
                altı.Enabled = true;
                yedi.Enabled = true;
                sekiz.Enabled = true;
                dokuz.Enabled = true;
                A.Enabled = true;
                B.Enabled = true;
                C.Enabled = true;
                D.Enabled = true;
                E.Enabled = true;
                F.Enabled = true; */
                for (int i = 0; i < 16; i++)
                {
                    btns[i].Enabled = true;
                }
            }
        }

        private void donustur_Click(object sender, EventArgs e)
        {
            try
            {
                if (sayi_girisi.Text == "")
                    MessageBox.Show("Sayı Giriniz", "BOŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (ikilik_1.Checked == true && sekizlik_2.Checked == true)
                    {
                        sonuc.Text = Convert.ToString(Convert.ToUInt32(sayi_girisi.Text, 2), 8);
                    }
                    else if (ikilik_1.Checked == true && onluk_2.Checked == true)
                    {
                        sonuc.Text = Convert.ToString(Convert.ToUInt32(sayi_girisi.Text, 2), 10);
                    }
                    else if (ikilik_1.Checked == true && onaltılık_2.Checked == true)
                    {
                        sonuc.Text = Convert.ToString(Convert.ToUInt32(sayi_girisi.Text, 2), 16);
                    }
                    else if (sekizlik_1.Checked == true && ikilik_2.Checked == true)
                    {
                        sonuc.Text = Convert.ToString(Convert.ToUInt32(sayi_girisi.Text, 8), 2);
                    }
                    else if (sekizlik_1.Checked == true && onluk_2.Checked == true)
                    {
                        sonuc.Text = Convert.ToString(Convert.ToUInt32(sayi_girisi.Text, 8), 10);
                    }
                    else if (sekizlik_1.Checked == true && onaltılık_2.Checked == true)
                    {
                        sonuc.Text = Convert.ToString(Convert.ToUInt32(sayi_girisi.Text, 8), 16);
                    }
                    else if (onluk_1.Checked == true && ikilik_2.Checked == true)
                    {
                        sonuc.Text = Convert.ToString(Convert.ToUInt32(sayi_girisi.Text, 10), 2);
                    }
                    else if (onluk_1.Checked == true && sekizlik_2.Checked == true)
                    {
                        sonuc.Text = Convert.ToString(Convert.ToUInt32(sayi_girisi.Text, 10), 8);
                    }
                    else if (onluk_1.Checked == true && onaltılık_2.Checked == true)
                    {
                        sonuc.Text = Convert.ToString(Convert.ToUInt32(sayi_girisi.Text, 10), 16);
                    }
                    else if (onaltılık_1.Checked == true && ikilik_2.Checked == true)
                    {
                        sonuc.Text = Convert.ToString(Convert.ToUInt32(sayi_girisi.Text, 16), 2);
                    }
                    else if (onaltılık_1.Checked == true && sekizlik_2.Checked == true)
                    {
                        sonuc.Text = Convert.ToString(Convert.ToUInt32(sayi_girisi.Text, 16), 8);
                    }
                    else if (onaltılık_1.Checked == true && onluk_2.Checked == true)
                    {
                        sonuc.Text = Convert.ToString(Convert.ToUInt32(sayi_girisi.Text, 16), 10);
                    }
                    else
                    {
                        sonuc.Text = "Hatalı Kullanım";
                    }
                }
            }
            catch (OverflowException)
            {
                sonuc.Text = "Değer Çok Büyük";
            }
            }

        private void sayi_girisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void neye_Enter(object sender, EventArgs e)
        {

        }
    }
    }
