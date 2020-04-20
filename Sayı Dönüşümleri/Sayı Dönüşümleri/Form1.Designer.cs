namespace Sayı_Dönüşümleri
{
    partial class main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.neyden = new System.Windows.Forms.GroupBox();
            this.sekizlik_1 = new System.Windows.Forms.RadioButton();
            this.onaltılık_1 = new System.Windows.Forms.RadioButton();
            this.ikilik_1 = new System.Windows.Forms.RadioButton();
            this.onluk_1 = new System.Windows.Forms.RadioButton();
            this.neye = new System.Windows.Forms.GroupBox();
            this.sekizlik_2 = new System.Windows.Forms.RadioButton();
            this.onaltılık_2 = new System.Windows.Forms.RadioButton();
            this.ikilik_2 = new System.Windows.Forms.RadioButton();
            this.onluk_2 = new System.Windows.Forms.RadioButton();
            this.donustur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sonuc = new System.Windows.Forms.Label();
            this.bir = new System.Windows.Forms.Button();
            this.iki = new System.Windows.Forms.Button();
            this.uc = new System.Windows.Forms.Button();
            this.dort = new System.Windows.Forms.Button();
            this.bes = new System.Windows.Forms.Button();
            this.altı = new System.Windows.Forms.Button();
            this.yedi = new System.Windows.Forms.Button();
            this.dokuz = new System.Windows.Forms.Button();
            this.sıfır = new System.Windows.Forms.Button();
            this.sekiz = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.sayi_girisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.neyden.SuspendLayout();
            this.neye.SuspendLayout();
            this.SuspendLayout();
            // 
            // neyden
            // 
            this.neyden.Controls.Add(this.sekizlik_1);
            this.neyden.Controls.Add(this.onaltılık_1);
            this.neyden.Controls.Add(this.ikilik_1);
            this.neyden.Controls.Add(this.onluk_1);
            this.neyden.Location = new System.Drawing.Point(13, 13);
            this.neyden.Name = "neyden";
            this.neyden.Size = new System.Drawing.Size(193, 86);
            this.neyden.TabIndex = 0;
            this.neyden.TabStop = false;
            this.neyden.Text = "Neyden ?";
            // 
            // sekizlik_1
            // 
            this.sekizlik_1.AutoSize = true;
            this.sekizlik_1.Location = new System.Drawing.Point(97, 19);
            this.sekizlik_1.Name = "sekizlik_1";
            this.sekizlik_1.Size = new System.Drawing.Size(75, 17);
            this.sekizlik_1.TabIndex = 0;
            this.sekizlik_1.Text = "8\'lik sistem";
            this.sekizlik_1.UseVisualStyleBackColor = true;
            this.sekizlik_1.CheckedChanged += new System.EventHandler(this.sekizlik_1_CheckedChanged);
            // 
            // onaltılık_1
            // 
            this.onaltılık_1.AutoSize = true;
            this.onaltılık_1.Location = new System.Drawing.Point(97, 54);
            this.onaltılık_1.Name = "onaltılık_1";
            this.onaltılık_1.Size = new System.Drawing.Size(81, 17);
            this.onaltılık_1.TabIndex = 0;
            this.onaltılık_1.Text = "16\'lık sistem";
            this.onaltılık_1.UseVisualStyleBackColor = true;
            this.onaltılık_1.CheckedChanged += new System.EventHandler(this.onaltılık_1_CheckedChanged);
            // 
            // ikilik_1
            // 
            this.ikilik_1.AutoSize = true;
            this.ikilik_1.Location = new System.Drawing.Point(6, 19);
            this.ikilik_1.Name = "ikilik_1";
            this.ikilik_1.Size = new System.Drawing.Size(75, 17);
            this.ikilik_1.TabIndex = 0;
            this.ikilik_1.Text = "2\'lik sistem";
            this.ikilik_1.UseVisualStyleBackColor = true;
            this.ikilik_1.CheckedChanged += new System.EventHandler(this.ikilik_1_CheckedChanged);
            // 
            // onluk_1
            // 
            this.onluk_1.AutoSize = true;
            this.onluk_1.Location = new System.Drawing.Point(6, 54);
            this.onluk_1.Name = "onluk_1";
            this.onluk_1.Size = new System.Drawing.Size(85, 17);
            this.onluk_1.TabIndex = 0;
            this.onluk_1.Text = "10\'luk sistem";
            this.onluk_1.UseVisualStyleBackColor = true;
            this.onluk_1.CheckedChanged += new System.EventHandler(this.onluk_1_CheckedChanged);
            // 
            // neye
            // 
            this.neye.Controls.Add(this.sekizlik_2);
            this.neye.Controls.Add(this.onaltılık_2);
            this.neye.Controls.Add(this.ikilik_2);
            this.neye.Controls.Add(this.onluk_2);
            this.neye.Location = new System.Drawing.Point(297, 13);
            this.neye.Name = "neye";
            this.neye.Size = new System.Drawing.Size(193, 86);
            this.neye.TabIndex = 0;
            this.neye.TabStop = false;
            this.neye.Text = "Neye ?";
            this.neye.Enter += new System.EventHandler(this.neye_Enter);
            // 
            // sekizlik_2
            // 
            this.sekizlik_2.AutoSize = true;
            this.sekizlik_2.Location = new System.Drawing.Point(97, 19);
            this.sekizlik_2.Name = "sekizlik_2";
            this.sekizlik_2.Size = new System.Drawing.Size(75, 17);
            this.sekizlik_2.TabIndex = 0;
            this.sekizlik_2.Text = "8\'lik sistem";
            this.sekizlik_2.UseVisualStyleBackColor = true;
            // 
            // onaltılık_2
            // 
            this.onaltılık_2.AutoSize = true;
            this.onaltılık_2.Location = new System.Drawing.Point(97, 54);
            this.onaltılık_2.Name = "onaltılık_2";
            this.onaltılık_2.Size = new System.Drawing.Size(81, 17);
            this.onaltılık_2.TabIndex = 0;
            this.onaltılık_2.Text = "16\'lık sistem";
            this.onaltılık_2.UseVisualStyleBackColor = true;
            // 
            // ikilik_2
            // 
            this.ikilik_2.AutoSize = true;
            this.ikilik_2.Location = new System.Drawing.Point(6, 19);
            this.ikilik_2.Name = "ikilik_2";
            this.ikilik_2.Size = new System.Drawing.Size(75, 17);
            this.ikilik_2.TabIndex = 0;
            this.ikilik_2.Text = "2\'lik sistem";
            this.ikilik_2.UseVisualStyleBackColor = true;
            // 
            // onluk_2
            // 
            this.onluk_2.AutoSize = true;
            this.onluk_2.Location = new System.Drawing.Point(6, 54);
            this.onluk_2.Name = "onluk_2";
            this.onluk_2.Size = new System.Drawing.Size(85, 17);
            this.onluk_2.TabIndex = 0;
            this.onluk_2.Text = "10\'luk sistem";
            this.onluk_2.UseVisualStyleBackColor = true;
            // 
            // donustur
            // 
            this.donustur.Location = new System.Drawing.Point(212, 32);
            this.donustur.Name = "donustur";
            this.donustur.Size = new System.Drawing.Size(79, 52);
            this.donustur.TabIndex = 1;
            this.donustur.Text = "Dönüştür";
            this.donustur.UseVisualStyleBackColor = true;
            this.donustur.Click += new System.EventHandler(this.donustur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "SONUÇ =";
            // 
            // sonuc
            // 
            this.sonuc.AutoSize = true;
            this.sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuc.Location = new System.Drawing.Point(85, 327);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(0, 16);
            this.sonuc.TabIndex = 3;
            // 
            // bir
            // 
            this.bir.Enabled = false;
            this.bir.Location = new System.Drawing.Point(13, 141);
            this.bir.Name = "bir";
            this.bir.Size = new System.Drawing.Size(80, 39);
            this.bir.TabIndex = 4;
            this.bir.Text = "1";
            this.bir.UseVisualStyleBackColor = true;
            // 
            // iki
            // 
            this.iki.Enabled = false;
            this.iki.Location = new System.Drawing.Point(99, 141);
            this.iki.Name = "iki";
            this.iki.Size = new System.Drawing.Size(80, 39);
            this.iki.TabIndex = 4;
            this.iki.Text = "2";
            this.iki.UseVisualStyleBackColor = true;
            // 
            // uc
            // 
            this.uc.Enabled = false;
            this.uc.Location = new System.Drawing.Point(185, 141);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(80, 39);
            this.uc.TabIndex = 4;
            this.uc.Text = "3";
            this.uc.UseVisualStyleBackColor = true;
            // 
            // dort
            // 
            this.dort.Enabled = false;
            this.dort.Location = new System.Drawing.Point(13, 186);
            this.dort.Name = "dort";
            this.dort.Size = new System.Drawing.Size(80, 39);
            this.dort.TabIndex = 4;
            this.dort.Text = "4";
            this.dort.UseVisualStyleBackColor = true;
            // 
            // bes
            // 
            this.bes.Enabled = false;
            this.bes.Location = new System.Drawing.Point(99, 186);
            this.bes.Name = "bes";
            this.bes.Size = new System.Drawing.Size(80, 39);
            this.bes.TabIndex = 4;
            this.bes.Text = "5";
            this.bes.UseVisualStyleBackColor = true;
            // 
            // altı
            // 
            this.altı.Enabled = false;
            this.altı.Location = new System.Drawing.Point(185, 186);
            this.altı.Name = "altı";
            this.altı.Size = new System.Drawing.Size(80, 39);
            this.altı.TabIndex = 4;
            this.altı.Text = "6";
            this.altı.UseVisualStyleBackColor = true;
            // 
            // yedi
            // 
            this.yedi.Enabled = false;
            this.yedi.Location = new System.Drawing.Point(13, 231);
            this.yedi.Name = "yedi";
            this.yedi.Size = new System.Drawing.Size(80, 39);
            this.yedi.TabIndex = 4;
            this.yedi.Text = "7";
            this.yedi.UseVisualStyleBackColor = true;
            // 
            // dokuz
            // 
            this.dokuz.Enabled = false;
            this.dokuz.Location = new System.Drawing.Point(185, 231);
            this.dokuz.Name = "dokuz";
            this.dokuz.Size = new System.Drawing.Size(80, 39);
            this.dokuz.TabIndex = 4;
            this.dokuz.Text = "9";
            this.dokuz.UseVisualStyleBackColor = true;
            // 
            // sıfır
            // 
            this.sıfır.Enabled = false;
            this.sıfır.Location = new System.Drawing.Point(99, 276);
            this.sıfır.Name = "sıfır";
            this.sıfır.Size = new System.Drawing.Size(80, 39);
            this.sıfır.TabIndex = 4;
            this.sıfır.Text = "0";
            this.sıfır.UseVisualStyleBackColor = true;
            // 
            // sekiz
            // 
            this.sekiz.Enabled = false;
            this.sekiz.Location = new System.Drawing.Point(99, 231);
            this.sekiz.Name = "sekiz";
            this.sekiz.Size = new System.Drawing.Size(80, 39);
            this.sekiz.TabIndex = 4;
            this.sekiz.Text = "8";
            this.sekiz.UseVisualStyleBackColor = true;
            // 
            // A
            // 
            this.A.Enabled = false;
            this.A.Location = new System.Drawing.Point(324, 141);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(80, 39);
            this.A.TabIndex = 4;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.Enabled = false;
            this.B.Location = new System.Drawing.Point(410, 141);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(80, 39);
            this.B.TabIndex = 4;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.Enabled = false;
            this.C.Location = new System.Drawing.Point(324, 186);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(80, 39);
            this.C.TabIndex = 4;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            // 
            // D
            // 
            this.D.Enabled = false;
            this.D.Location = new System.Drawing.Point(410, 186);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(80, 39);
            this.D.TabIndex = 4;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            // 
            // E
            // 
            this.E.Enabled = false;
            this.E.Location = new System.Drawing.Point(324, 231);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(80, 39);
            this.E.TabIndex = 4;
            this.E.Text = "E";
            this.E.UseVisualStyleBackColor = true;
            // 
            // F
            // 
            this.F.Enabled = false;
            this.F.Location = new System.Drawing.Point(410, 231);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(80, 39);
            this.F.TabIndex = 4;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            // 
            // sayi_girisi
            // 
            this.sayi_girisi.Enabled = false;
            this.sayi_girisi.Location = new System.Drawing.Point(64, 106);
            this.sayi_girisi.Name = "sayi_girisi";
            this.sayi_girisi.Size = new System.Drawing.Size(426, 20);
            this.sayi_girisi.TabIndex = 5;
            this.sayi_girisi.TextChanged += new System.EventHandler(this.sayi_girisi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sayı Girişi";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 355);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sayi_girisi);
            this.Controls.Add(this.sekiz);
            this.Controls.Add(this.F);
            this.Controls.Add(this.E);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.sıfır);
            this.Controls.Add(this.dokuz);
            this.Controls.Add(this.yedi);
            this.Controls.Add(this.altı);
            this.Controls.Add(this.bes);
            this.Controls.Add(this.dort);
            this.Controls.Add(this.uc);
            this.Controls.Add(this.iki);
            this.Controls.Add(this.bir);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.donustur);
            this.Controls.Add(this.neye);
            this.Controls.Add(this.neyden);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "Sayı Dönüşümleri";
            this.Load += new System.EventHandler(this.main_Load);
            this.neyden.ResumeLayout(false);
            this.neyden.PerformLayout();
            this.neye.ResumeLayout(false);
            this.neye.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox neyden;
        private System.Windows.Forms.RadioButton sekizlik_1;
        private System.Windows.Forms.RadioButton onaltılık_1;
        private System.Windows.Forms.RadioButton ikilik_1;
        private System.Windows.Forms.RadioButton onluk_1;
        private System.Windows.Forms.GroupBox neye;
        private System.Windows.Forms.RadioButton sekizlik_2;
        private System.Windows.Forms.RadioButton onaltılık_2;
        private System.Windows.Forms.RadioButton ikilik_2;
        private System.Windows.Forms.RadioButton onluk_2;
        private System.Windows.Forms.Button donustur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sonuc;
        private System.Windows.Forms.Button bir;
        private System.Windows.Forms.Button iki;
        private System.Windows.Forms.Button uc;
        private System.Windows.Forms.Button dort;
        private System.Windows.Forms.Button bes;
        private System.Windows.Forms.Button altı;
        private System.Windows.Forms.Button yedi;
        private System.Windows.Forms.Button dokuz;
        private System.Windows.Forms.Button sıfır;
        private System.Windows.Forms.Button sekiz;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Button F;
        private System.Windows.Forms.TextBox sayi_girisi;
        private System.Windows.Forms.Label label2;
    }
}

