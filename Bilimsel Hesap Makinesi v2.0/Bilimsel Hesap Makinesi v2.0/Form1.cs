using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilimsel_Hesap_Makinesi_v2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int faktoriyel(int a) //faktöriyel hesapamak için öz yenilemeli fonksiyon
        {
            if (a != 1)
                return a * faktoriyel(a - 1);
            else
                return 1;
        }
        double deger1, deger2, sonuc; // Normal Hesap Makinesi için değişkenler
        double bilimsel_deger, hesaplanmıs, bilimsel_deger_2, hesaplanmıs_2, sonuc_2; //bilimsel hesapmakinesi için değişkenler

        private void ilk_sayi_enabler_CheckedChanged(object sender, EventArgs e) //Aynı anda iki checkboxda true veya false olmaması için gerek kodlar
        {
            if (ilk_sayi_enabler.Checked == true)
                ikinci_sayi_enabler.Checked = false;
        }

        private void ikinci_sayi_enabler_CheckedChanged(object sender, EventArgs e)
        {
            if (ikinci_sayi_enabler.Checked == true)
                ilk_sayi_enabler.Checked = false;
        }

        private void tus_7_Click(object sender, EventArgs e) // buttonlardan textboxa giriş için
        {
            if (ilk_sayi_enabler.Checked == true)
                ilk_sayi_giris.Text += 7;
            else
                ikinci_sayi_girisi.Text += 7;
        }

        private void tus_8_Click(object sender, EventArgs e)
        {
            if (ilk_sayi_enabler.Checked == true)
                ilk_sayi_giris.Text += 8;
            else
                ikinci_sayi_girisi.Text += 8;
        }

        private void tus_9_Click(object sender, EventArgs e)
        {
            if (ilk_sayi_enabler.Checked == true)
                ilk_sayi_giris.Text += 9;
            else
                ikinci_sayi_girisi.Text += 9;
        }

        private void tus_4_Click(object sender, EventArgs e)
        {
            if (ilk_sayi_enabler.Checked == true)
                ilk_sayi_giris.Text += 4;
            else
                ikinci_sayi_girisi.Text += 4;
        }

        private void tus_5_Click(object sender, EventArgs e)
        {
            if (ilk_sayi_enabler.Checked == true)
                ilk_sayi_giris.Text += 5;
            else
                ikinci_sayi_girisi.Text += 5;
        }

        private void tus_6_Click(object sender, EventArgs e)
        {
            if (ilk_sayi_enabler.Checked == true)
                ilk_sayi_giris.Text += 6;
            else
                ikinci_sayi_girisi.Text += 6;
        }

        private void tus_1_Click(object sender, EventArgs e)
        {
            if (ilk_sayi_enabler.Checked == true)
                ilk_sayi_giris.Text += 1;
            else
                ikinci_sayi_girisi.Text += 1;
        }

        private void tus_2_Click(object sender, EventArgs e)
        {
            if (ilk_sayi_enabler.Checked == true)
                ilk_sayi_giris.Text += 2;
            else
                ikinci_sayi_girisi.Text += 2;
        }

        private void tus_3_Click(object sender, EventArgs e)
        {
            if (ilk_sayi_enabler.Checked == true)
                ilk_sayi_giris.Text += 3;
            else
                ikinci_sayi_girisi.Text += 3;
        }

        private void tus_0_Click(object sender, EventArgs e)
        {
            if (ilk_sayi_enabler.Checked == true)
                ilk_sayi_giris.Text += 0;
            else
                ikinci_sayi_girisi.Text += 0;
        }

        private void topla_Click(object sender, EventArgs e) //toplama işlemi
        {
            if(ilk_sayi_giris.Text == "" || ikinci_sayi_girisi.Text == "") //textboxlar boş ise uyarması için
            {
                MessageBox.Show("Boşları Toplayamazsın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Hesaplama
            {
                deger1 = Convert.ToDouble(ilk_sayi_giris.Text);
                deger2 = Convert.ToDouble(ikinci_sayi_girisi.Text);

                sonuc = deger1 + deger2;

                sonuc_goster.Text = sonuc.ToString();
            }
        }

        private void cikar_Click(object sender, EventArgs e)
        {
            if (ilk_sayi_giris.Text == "" || ikinci_sayi_girisi.Text == "")
            {
                MessageBox.Show("Boşları Çıkaramazsın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                deger1 = Convert.ToDouble(ilk_sayi_giris.Text);
                deger2 = Convert.ToDouble(ikinci_sayi_girisi.Text);

                sonuc = deger1 - deger2;

                sonuc_goster.Text = sonuc.ToString();
            }
        }

        private void carp_Click(object sender, EventArgs e)
        {
            if (ilk_sayi_giris.Text == "" || ikinci_sayi_girisi.Text == "")
            {
                MessageBox.Show("Boşları Çarpamazsın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                deger1 = Convert.ToDouble(ilk_sayi_giris.Text);
                deger2 = Convert.ToDouble(ikinci_sayi_girisi.Text);

                sonuc = deger1 * deger2;

                sonuc_goster.Text = sonuc.ToString();
            }
        }

        private void bol_Click(object sender, EventArgs e)
        {
            if (ilk_sayi_giris.Text == "" || ikinci_sayi_girisi.Text == "")
            {
                MessageBox.Show("Boşları Bölemezsin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                deger1 = Convert.ToDouble(ilk_sayi_giris.Text);
                deger2 = Convert.ToDouble(ikinci_sayi_girisi.Text);

                if(deger2 == 0) //0' bölündüğünde program çökmemesi için
                {
                    sonuc_goster.Text = "Tanımsız";
                }
                else
                {
                    sonuc = deger1 / deger2;

                    sonuc_goster.Text = sonuc.ToString();
                }
            }
        }

        private void hepsini_temizle_Click(object sender, EventArgs e) //hepsini temizle
        {
            if (ilk_sayi_enabler.Checked == true)
                ilk_sayi_giris.Text = "";
            else
                ikinci_sayi_girisi.Text = "";
        }

        private void cos_tus_Click(object sender, EventArgs e) //cos hesaplama
        {
            bilimsel_deger = Convert.ToDouble(bilimsel_text.Text);

            hesaplanmıs = Math.Cos(Math.PI * bilimsel_deger / 180);

            sonuc_bilmsel.Text = hesaplanmıs.ToString();
        }

        private void karekok_tus_Click(object sender, EventArgs e) //karekök hesaplama
        {
            bilimsel_deger = Convert.ToDouble(bilimsel_text.Text);

            hesaplanmıs = Math.Sqrt(bilimsel_deger);

            sonuc_bilmsel.Text = hesaplanmıs.ToString();
        }

        private void faktoriyel_tus_Click(object sender, EventArgs e) //faktöriyel hesaplama
        {
            int fak;
            fak = Convert.ToInt32(bilimsel_text.Text); 
            
            sonuc_bilmsel.Text = faktoriyel(fak).ToString(); //fonk çağırma
        }

        private void kare_tus_Click(object sender, EventArgs e) //karesini alma
        {
            bilimsel_deger = Convert.ToDouble(bilimsel_text.Text);

            bilimsel_deger = bilimsel_deger * bilimsel_deger;
            sonuc_bilmsel.Text = bilimsel_deger.ToString();
        }

        private void ln_tus_Click(object sender, EventArgs e) //10 tabanında logaritma alma
        {
            bilimsel_deger = Convert.ToDouble(bilimsel_text.Text);

            if(bilimsel_deger <= 0)
            {
                MessageBox.Show("Hata", "Logaritmanın içi 0 veya 0 dan küçük olamaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                hesaplanmıs = Math.Log10(bilimsel_deger);
                sonuc_goster.Text = (hesaplanmıs.ToString());
            }
        }

        private void tan_tus_Click(object sender, EventArgs e) //tan hesaplama
        {
            bilimsel_deger = Convert.ToDouble(bilimsel_text.Text);

            hesaplanmıs = Math.Tan(Math.PI * bilimsel_deger / 180);

            sonuc_bilmsel.Text = hesaplanmıs.ToString();
        }

        private void cot_tus_Click(object sender, EventArgs e) // cot hesaplama
        {
            bilimsel_deger = Convert.ToDouble(bilimsel_text.Text);

            hesaplanmıs = Math.Cos(Math.PI * bilimsel_deger / 180);

            bilimsel_deger_2 = Convert.ToDouble(bilimsel_text.Text);

            hesaplanmıs_2 = Math.Sin(Math.PI * bilimsel_deger / 180);

            if(hesaplanmıs_2 == 0)
            {
                sonuc_bilmsel.Text = "Tanımsız";
            }
            else
            {
                sonuc_2 = hesaplanmıs / hesaplanmıs_2;
                sonuc_bilmsel.Text = sonuc_2.ToString();
            }
        }

        private void bilimsel_text_KeyPress(object sender, KeyPressEventArgs e) //sadece rakam ve 1 tane virgül girdirme
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
                e.Handled = true;
        }

        private void sin_tus_Click(object sender, EventArgs e) //sin hesaplama
        {
            bilimsel_deger = Convert.ToDouble(bilimsel_text.Text);

            hesaplanmıs = Math.Sin(Math.PI*bilimsel_deger/180);

            sonuc_bilmsel.Text = hesaplanmıs.ToString();
        }

        private void virgul_Click(object sender, EventArgs e) //Normal hesap makinesinde virgül girişi
        {
            if (ilk_sayi_enabler.Checked == true)
                ilk_sayi_giris.Text += ",";
            else
                ikinci_sayi_girisi.Text += ",";
        }

        private void temizle_Click(object sender, EventArgs e) //tek tel silme
        {
            if (ilk_sayi_enabler.Checked == true)
            {
                if (ilk_sayi_giris.Text == "")
                    MessageBox.Show("Boş yerden silme yapıyorsun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    ilk_sayi_giris.Text = ilk_sayi_giris.Text.Substring(0, ilk_sayi_giris.Text.Length - 1);
            }
            else
            {
                if (ikinci_sayi_girisi.Text == "")
                    MessageBox.Show("Boş yerden silme yapıyorsun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    ikinci_sayi_girisi.Text = ikinci_sayi_girisi.Text.Substring(0, ikinci_sayi_girisi.Text.Length - 1);
            }
        }
    }
}
