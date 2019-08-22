using LimonOtomasyon.Sınıflar;
using LimonOtomasyon1.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimonOtomasyon1.Formlar.KucukFormlar
{
    public partial class personel_giris : Form
    {
        Database veritabanı = new Database();
        BaslangicAyarlari ayarlar = new BaslangicAyarlari();

        sbyte giris_hakki = 0;
        string gelen_sayfa;
        bool internet_lazim;
        
        public personel_giris(String gelensayfa,bool internete_gerek_var)
        {
            InitializeComponent();
            internet_lazim = internete_gerek_var;
            //Sadece yönetici girişi izni olan sayfaları öğrenebilmek adına "personel_giris" formun nereden
            //çağırıldığını öğrenmek için böyle yapıyoruz.
            gelen_sayfa = gelensayfa;
            if (gelen_sayfa == "yonetici")
                personel_tasarimi();
        }
        //Kapat butonu
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Hide();
            cGenel.personel_girisi = false;

        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            personel_girsin();
        }
        #region PlaceHolder Özellikleri
        private void bmt_sifre_Leave(object sender, EventArgs e)
        {
            string isim = "";

            Bunifu.Framework.UI.BunifuMetroTextbox gelen = (sender as Bunifu.Framework.UI.BunifuMetroTextbox);
            isim = gelen.Name;

            if (gelen.Text == "")
            {
                if (gelen.Name == "bmt_sifre")
                {
                    bmt_sifre.Text = "Personel Şifreniz";
                    bmt_sifre.isPassword = false;
                }
                else if (gelen.Name == "bmt_eposta")
                    bmt_eposta.Text = "E-posta Adresiniz";
                else if(gelen.Name == "bmt_personelsifre")
                {
                    bmt_yoneticisifre.Text = "Şifreniz";
                    bmt_yoneticisifre.isPassword = false;
                }
            }
        }

        private void bmt_sifre_Enter(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMetroTextbox gelen = (sender as Bunifu.Framework.UI.BunifuMetroTextbox);
            string isim = gelen.Name;

            if (gelen.Text == "Personel Şifreniz")
            {
                gelen.Text = "";
                bmt_sifre.isPassword = true;
            }
            else if (gelen.Text == "E-posta Adresiniz")
                gelen.Text = "";
            else if(gelen.Text == "Şifreniz")
            {
                gelen.Text = "";
                bmt_yoneticisifre.isPassword = true;
            }
        }

        #endregion

        private void btm_panelkapa_Click(object sender, EventArgs e)
        {
            pl_yonetici.Visible = false;
            lb_hak.Text = (5 - giris_hakki).ToString() + " giriş hakkınız kaldı.";
        }
        //Yönetici Girişi Panel Ayarlarını Burada Yapıyoruz.
        private void lb_yoneticigirisi_MouseClick(object sender, MouseEventArgs e)
        {
            pl_yonetici.Dock = DockStyle.Fill;
            pl_yonetici.Visible = true;
            lb_yuyari.Text = (5 - giris_hakki).ToString() + " giriş hakkınız kaldı.";
        }
        //Yönetici giriş yap butonu
        private void bfb_pgirisyap_Click(object sender, EventArgs e)
        {
            personel_girsin();
        }

        #region Eğer sadece Personel Girişi gerekiyorsa aşağıdaki tasarım fonksiyonu aktif olacak.
        private void personel_tasarimi()
        {
            pl_yonetici.Dock = DockStyle.Fill;
            pl_yonetici.Visible = true;
            bmt_panelkapa.Visible = false;
            bmt_personelkapa.Visible = true;
        }

        private void bmt_personelkapa_Click(object sender, EventArgs e)
        {
            cGenel.personel_girisi = false;
            this.Hide();
        }

        #endregion
      

        private void personel_giris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                personel_girsin();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                cGenel.personel_girisi = false;
                this.Hide();
            }

        }
        private void personel_girsin()
        {
            if (pl_yonetici.Visible == false)
            {
                if (bmt_sifre.Text != "Personel Şifreniz" && giris_hakki != 5)
                {

                    if (veritabanı.personel_giris(bmt_sifre.Text))
                    {   //masa isimli sınıfın p_id public degiskenine personelin id bilgisini yüklüyorum
                        int pno = veritabanı.personel_id(bmt_sifre.Text);
                        masa.p_id = pno;
                        masa_butonlari.p_id = pno;
                        hesap_ode.p_id = pno;
                        cGenel.personel_girisi = true;
                        this.Hide();
                    }
                    else
                    {
                        alarm.Show("Bu bilgilere uygun personel bulunamadı.", alarm.Alarmtur.dikkat);
                        giris_hakki++;
                        lb_hak.Text = (5 - giris_hakki).ToString() + " giriş hakkınız kaldı.";

                        if (giris_hakki == 5)
                        {
                            cGenel.personel_girisi = false;
                            this.Hide();
                        }
                    }
                }
            }
            #region Yönetici Giriş Yapsın
            else
            {
                if (bmt_eposta.Text == "E-posta Adresiniz" && bmt_yoneticisifre.isPassword == false && giris_hakki < 6)
                    alarm.Show("Lütfen gerekli alanları doldurunuz.", alarm.Alarmtur.dikkat);
                else
                {
                   
                        if (veritabanı.girisyap(bmt_eposta.Text, bmt_yoneticisifre.Text))
                        {
                            alarm.Show("Başarılı bir şekilde giriş yaptınız.", alarm.Alarmtur.basarili);
                            cGenel.personel_girisi = true;
                            this.Hide();
                        }
                        else
                        {
                            alarm.Show("Lütfen şifre ve e-posta adresinizi tekrar kontrol edin.", alarm.Alarmtur.hata);
                            cGenel.personel_girisi = false;
                            giris_hakki++;
                            lb_yuyari.Text = (5 - giris_hakki).ToString() + " giriş hakkınız kaldı.";

                            if (giris_hakki == 5)
                            {
                                veritabanı.eposta_gonder(cGenel.yonetici_eposta, "Hatalı Giriş Denemesi", "Merhaba \n\nLimon Otomasyonu üzerinde personel şifreniz ile 5 defa izinsiz giriş yapıldı.\nEğer bu girişi siz yaptıysanız e-postayı dikkate" +
                                 " almaya bilirsiniz fakat aksi durumda şifrenizi değiştirmeiniz şiddetle öneriririz.\n \nDiğer soru ve görüşleriniz için uygulammız üzerindne veya wwww.limoncreatif.com üzerinden iletişime geçebilirsiniz.\n \nHayırlı kazançlar.");
                                cGenel.personel_girisi = false;
                                this.Hide();
                            }
                        }
                    }
                   
                     
                }
             
            #endregion
        }


        //Gölge Efekti
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
    }

}
