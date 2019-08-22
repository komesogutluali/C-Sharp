using Bunifu.Framework.UI;
using LimonOtomasyon.Sınıflar;
using LimonOtomasyon1.Formlar;
using LimonOtomasyon1.Formlar.KucukFormlar;
using LimonOtomasyon1.Sınıflar;
using System;
using System.Data.SQLite;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LimonOtomasyon1.Formlar
{
    public partial class login : Form
    {
        /*Form Arası Geçiş Yaparken Efekt Kullanmak İçin Aşağıdaki Kodları Yazıyoruz.*/
        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, AnimateWindowFlags flags);

        Database veritabani = new Database();
        BaslangicAyarlari ayarlar = new BaslangicAyarlari();

        cGenel genel = new cGenel();
        byte sifre_deneme = 0;
        int timer_sayac = 0;


        public login()
        {
            //raporum.dosya_ziple("\\limon_veri.db","Haziran Ayı Raporu");
            //raporum.ftp_dosyayukle("veritabani.zip", "SiberGuvenlik");

            InitializeComponent();
            ayarlar.internet_var_mi();
           
            programacildi();
        }
        //Login Ekranını Kapatma Buton Fonksiyonu
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void login_Enter(object sender, EventArgs e)
        {

            BunifuMaterialTextbox gelen = (sender as BunifuMaterialTextbox);
            string isim = gelen.Name;

            if (gelen.Text == "E-posta Adresiniz")
                gelen.Text = "";
            else if (gelen.Text == "Şifreniz")
            {
                gelen.Text = "";
                bmt_sifre.isPassword = true;
            }
            else if (gelen.Text == "Mesajınız")
                gelen.Text = "";
            else if (gelen.Text == "Cevap")
                gelen.Text = "";
            else if (gelen.Text == "Personel Şifreniz")
                gelen.Text = "";


        }

        private void login_Leave(object sender, EventArgs e)
        {
            string isim = "";

            BunifuMaterialTextbox gelen = (sender as BunifuMaterialTextbox);
            isim = gelen.Name;

            if (gelen.Text == "")
            {
                if (gelen.Name == "bmt_eposta")
                    bmt_eposta.Text = "E-posta Adresiniz";
                else if (gelen.Name == "bmt_sifre")
                {
                    bmt_sifre.Text = "Şifreniz";
                    bmt_sifre.isPassword = false;
                }
                else if (gelen.Name == "bmt_sifreyenile")
                    bmt_personelsifre.Text = "E-posta Adresiniz";
                else if (gelen.Name == "bmt_personelgiris")
                    bmt_personelsifre.Text = "Personel Şifreniz";

            }
        }

        //Animasyon için gerekli ayarlamalar mevcut.
        enum AnimateWindowFlags : uint
        {
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000
        }

        // Giriş Yap Butonu Click Kodları
        private void bfb_girisyap_Click(object sender, EventArgs e)
        {
    

           
                if (bmt_eposta.Text != "E-posta Adresiniz" && bmt_sifre.isPassword == true)
                {
                    if (veritabani.girisyap(bmt_eposta.Text,bmt_sifre.Text))
                    {
                        //Yönetici olarak girişi yaptığım için cGenel.kim_girisyapti değerini değiştiriyorum.
                        cGenel.kim_girisyapti = true; //yönetici = true || personel = false
                        this.Hide();
                        anasayfa ac = new anasayfa();
                        //Animasyon DLL'ini alt kısımda kullanıyoruz.
                        AnimateWindow(ac.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
                        ac.Show();
                    }
                    else
                    {
                            alarm.Show("E-posta Adresiniz veya Şifreniz Yanlış !", alarm.Alarmtur.hata);
                    }
                }
                else
                    alarm.Show("Lütfen E-posta veya Şifre Alanını Doldurunuz.", alarm.Alarmtur.dikkat);
           
        }

        //Şifre Unuttum Kısmının Click Kodları
        private void lb_unuttum_Click(object sender, EventArgs e)
        {
            pl_sifreguncelle.Visible = true;
            pl_sifreguncelle.Height = 452;
        }
        // Şifre Değiştirme Penceresini Gizlemek Amacı İle Kullanıyoruz.
        private void btn_sifregizle_Click(object sender, EventArgs e)
        {
        }
        //Şifre Yenileme Butonu Click Fonksiyonu
        private void bfb_yenisifre_Click(object sender, EventArgs e)
        {
            if (bmt_personelsifre.Text != "Personel Şifreniz" )
            {

                if (veritabani.personel_giris(bmt_personelsifre.Text))
                {   //masa isimli sınıfın p_id public degiskenine personelin id bilgisini yüklüyorum
                    cGenel.personel_no = veritabani.personel_id(bmt_personelsifre.Text);
                    //Yönetici olarak girişi yaptığım için cGenel.kim_girisyapti değerini değiştiriyorum.
                    cGenel.kim_girisyapti = false; //yönetici = true || personel = false
                    DateTime tarih = DateTime.Now;

                    veritabani.Son_islem_ekle("Programa giriş yapıldı.", tarih.ToString("yyyy/MM/dd H:mm"), cGenel.personel_no);
                    this.Hide();
                    anasayfa ac = new anasayfa();
                    //Animasyon DLL'ini alt kısımda kullanıyoruz.
                    AnimateWindow(ac.Handle, 1000, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
                    ac.Show();
                }
                else
                {
                 
                }
            }


        }

        private void giris_hakki_Tick(object sender, EventArgs e)
        {
            timer_sayac++;
            lbl_aciklama.Text = (5 - timer_sayac / 60) + " dakika sonra tekrar giriş yapabilirsiniz.";
            if (timer_sayac / 60 == 5)
            {
                sifre_deneme = 0;
                MessageBox.Show("Giriş Yapabilirsiniz.");
                lbl_aciklama.Visible = false;
                giris_hakki.Enabled = false;
            }
        }

        private void lbl_web_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://limoncreatif.com");
        }

        private void lbl_hakkimizda_Click(object sender, EventArgs e)
        {
            lb_limonhak.Text = "Limon Creatif 2018'den günümüze genç kadrosu ile web tasarım, kurumsal kimlik çalışmaları ve otomasyon sistemleri başta olmak üzere birçok alanda müşterilerine özel çözümler üretiyor. ";
            pl_iletisimbuton.Visible = false;
        }

        private void lbl_destek_Click(object sender, EventArgs e)
        {
            lb_limonhak.Text = "Limon Cafe otomasyonu ile ilgili tüm sorularınızı web sitemiz üzerinden veya e-posta yolu ile sorabilirsiniz. ";
            pl_iletisimbuton.Visible = true;
        }
        #region Destek E-postası yollanan panel tasarım kısmı
        private void bfb_iletisim_Click(object sender, EventArgs e)
        {
            pl_epostayolla.Height = 452;
            pl_epostayolla.Visible = true;
        }

        private void bfm_epostakapat_Click(object sender, EventArgs e)
        {
            pl_epostayolla.Visible = false;

        }
        #endregion

        private void dk_metin_Enter(object sender, EventArgs e)
        {
            TextBox gelen = (sender as TextBox);
            string isim = gelen.Name;

            if (gelen.Text == "Mesajınız")
                gelen.Text = "";
            else if (gelen.Text == "Cevap")
                gelen.Text = "";
        }

        private void dk_metin_Leave(object sender, EventArgs e)
        {
            TextBox gelen = (sender as TextBox);
            string isim = gelen.Name;

            if (gelen.Text == "")
            {
                if (gelen.Name == "dk_metin")
                    dk_metin.Text = "Mesajınız";
                else if (gelen.Name == "dk_dogru")
                    dk_dogru.Text = "Cevap";

            }
        }
        // İletişim Formu Gönder
        private void bfb_epostagonder_Click(object sender, EventArgs e)
        {

            if (dk_dogru.Text == "16" && dk_konu.SelectedText != "İletişim Sebeniz Nedir ?" && dk_metin.Text.Length > 5 && dk_eposta.Text.Length > 10)
            {
                string mesaj = "E-posta Gönderen : " + dk_eposta.Text + "\n\n" + dk_metin.Text;

                if (veritabani.eposta_gonder("iletisim@hasaneksi.net", dk_konu.Text, mesaj))
                    alarm.Show("Mesajınız başarı ile ulaştırıldı.En kısa sürede size dönüş sağlayacağız.", alarm.Alarmtur.eposta);
                else
                {
                    alarm.Show("Maalesef mesajınız iletilemedi.İnternet sitemiz üzerinden bize ulaşabilirsiniz.", alarm.Alarmtur.hata);
                    pl_mailposta.Visible = true;
                }
            }
            else
            {
                alarm.Show("Lütfen her şeyi doğru girdiğinize emin olun.", alarm.Alarmtur.dikkat);
            }

        }

        //Gölge efekti
      protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                cp.ClassStyle |= 0x20000;

                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }
        private void programacildi()
        {
            int masa_sayisi = 30;
            if (veritabani.program_basla())
            {
                if (veritabani.program_acildi())
                { 
                    alarm.Show("Limon Otomasyon Programı ilk defa açılmaya hazırlanıyor.", alarm.Alarmtur.basarili);
                    //Bu kısım sadece Böğürtlen Büfeye verilirken olacak.
                    //Bu kısımda bitiyor.
                    veritabani.masa_tablo_olustur();
                    veritabani.masa_olustur(masa_sayisi);

                        veritabani.eposta_gonder("iletisim@hasaneksi.net", "Limon Otomasyon Kuruldu", "Merhaba Hasan, Limon Otomasyon bir bilgisayara kuruldu.");
                }
            }
        }

        private void lbl_kullanicisozlesmesi_Click(object sender, EventArgs e)
        {
            kullanicisozlesmesi sozlesme = new kullanicisozlesmesi();
            sozlesme.ShowDialog();
        }

        //E-posta adresinin doğru olup olmadığını inceliyoruz.
        static bool eposta_kontrol(string inputEmail)
        {
            const string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            return (new Regex(strRegex)).IsMatch(inputEmail);
        }

        private void lb_yoneticiolarak_Click(object sender, EventArgs e)
        {
            pl_sifreguncelle.Visible = false;
        }

        private void lb_personelgirisi_Click(object sender, EventArgs e)
        {
            pl_sifreguncelle.Visible = true;
            pl_sifreguncelle.Height = pl_sol.Height;
        }
    }

}
