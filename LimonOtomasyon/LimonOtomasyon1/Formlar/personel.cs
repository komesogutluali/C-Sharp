using Bunifu.Framework.UI;
using LimonOtomasyon1.Formlar.KucukFormlar;
using LimonOtomasyon1.Sınıflar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimonOtomasyon1.Formlar
{
    public partial class personel : Form
    {
        Database veritabanı = new Database();
        ArrayList p_id = new ArrayList();
        ArrayList p_ad = new ArrayList();
        String[] renkler = { "Orange", "Teal", "DarkGreen", "LightSeaGreen", "SteelBlue", "MidnightBlue",
            "BlueViolet", "DarkViolet", "Purple", "DarkOrange", "Firebrick","Tomato","OliveDrab","RoyalBlue" };
        String[] aktif_renkler = { "Teal", "LightSeaGreen", "MidnightBlue", "DarkViolet", "DarkOrange", "DarkGreen",
            "Orange", "SteelBlue", "BlueViolet", "Purple", "LightCoral","Chocolate","SeaGreen","DeepSkyBlue" };
        public personel()
        {
            InitializeComponent();
            veritabanı.personel_getir(p_ad, p_id);
            Personel_btn_olustur();
            lbl_pno.Text = veritabanı.personel_sayisi() + "";
        }
        #region Tasarım İle İlgili Kodlar
        private void personel_SizeChanged(object sender, EventArgs e)
        {
            //Form Boyutu Değişince Çağırılan Fonksiyon
            response(cGenel.genislik, cGenel.yukseklik);
        }
        private void response(int genislik, int yukseklik)
        {
            //Standart Pencere Boyutu
            if (genislik == 1200 && yukseklik == 650)
            {
                tlp_butonmain.Width = pl_main2.Width;
                tlp_butonmain.Height = pl_main2.Height ;

                tlp_butonmain.Location = new Point(
                pl_main2.ClientSize.Width / 2 - tlp_butonmain.Size.Width / 2,
                pl_main2.ClientSize.Height / 2 - tlp_butonmain.Size.Height / 2);
                tlp_butonmain.Anchor = AnchorStyles.None;

                //Çözünürlüğe göre butonların gerekli şekli alması için bunu yapıyoruz.
                BunifuMetroTextbox[] bmt_textbox = { bmt_adi, bmt_telefon, bmt_tckimlik, bmt_adres, bmt_eposta, bmt_sifre1,bmt_sifre2 };
                BunifuFlatButton[] bfb_button = { btn_personelekle, btn_personelsil };
                for (int i = 0; i < bmt_textbox.Length; i++)
                {
                    if(i < 2)
                        bfb_button[i].Margin = new Padding(0, 15, 10, 15);

                bmt_textbox[i].Margin = new Padding(0, 15, 10, 15);
                bdp_dogumtarihi.Margin = new Padding(0, 15, 10, 15);
                }
            }
            // Full HD Çözünürlük İçin Responsive Ayarları (1920 x 1080)
            else if (genislik == 1920 && yukseklik == 1080)
            {
                tlp_butonmain.Width = pl_main2.Width - 50;
                tlp_butonmain.Height = pl_main2.Height - 50;

                tlp_butonmain.Location = new Point(
                pl_main2.ClientSize.Width / 2 - tlp_butonmain.Size.Width / 2,
                pl_main2.ClientSize.Height / 2 - tlp_butonmain.Size.Height / 2);
                tlp_butonmain.Anchor = AnchorStyles.None;

                BunifuMetroTextbox[] bmt_textbox = { bmt_adi, bmt_telefon, bmt_tckimlik, bmt_adres, bmt_eposta, bmt_sifre1, bmt_sifre2 };
                BunifuFlatButton[] bfb_button = { btn_personelekle, btn_personelsil };
                for (int i = 0; i < bmt_textbox.Length; i++)
                {
                    if (i < 2)
                        bfb_button[i].Margin = new Padding(0, 45, 10, 45);

                    bmt_textbox[i].Margin = new Padding(0, 45, 10, 45);
                    bdp_dogumtarihi.Margin = new Padding(0, 45, 10, 45);
                }
            }
            else if (genislik == 1366 && yukseklik == 768)
            {
                tlp_butonmain.Width = pl_main2.Width - 25;
                tlp_butonmain.Height = pl_main2.Height - 25;

                tlp_butonmain.Location = new Point(
                pl_main2.ClientSize.Width / 2 - tlp_butonmain.Size.Width / 2,
                pl_main2.ClientSize.Height / 2 - tlp_butonmain.Size.Height / 2);
                tlp_butonmain.Anchor = AnchorStyles.None;

                BunifuMetroTextbox[] bmt_textbox = { bmt_adi, bmt_telefon, bmt_tckimlik, bmt_adres, bmt_eposta, bmt_sifre1, bmt_sifre2 };
                BunifuFlatButton[] bfb_button = { btn_personelekle, btn_personelsil };
                for (int i = 0; i < bmt_textbox.Length; i++)
                {
                    if (i < 2)
                        bfb_button[i].Margin = new Padding(0, 35, 10, 35);

                    bmt_textbox[i].Margin = new Padding(0, 35, 10, 35);
                    bdp_dogumtarihi.Margin = new Padding(0, 35, 10, 35);

                }

            }
            else
            {
                tlp_butonmain.Width = pl_main2.Width - 25;
                tlp_butonmain.Height = pl_main2.Height - 25;

                tlp_butonmain.Location = new Point(
                pl_main2.ClientSize.Width / 2 - tlp_butonmain.Size.Width / 2,
                pl_main2.ClientSize.Height / 2 - tlp_butonmain.Size.Height / 2);
                tlp_butonmain.Anchor = AnchorStyles.None;

                BunifuMetroTextbox[] bmt_textbox = { bmt_adi, bmt_telefon, bmt_tckimlik, bmt_adres, bmt_eposta, bmt_sifre1, bmt_sifre2 };
                BunifuFlatButton[] bfb_button = { btn_personelekle, btn_personelsil };
                for (int i = 0; i < bmt_textbox.Length; i++)
                {
                    if (i < 2)
                        bfb_button[i].Margin = new Padding(0, 15, 10, 15);
                    bmt_textbox[i].Margin = new Padding(0, 15, 10, 15);
                    bdp_dogumtarihi.Margin = new Padding(0, 15, 10, 15);
                }
            }

        }
 #endregion
        //Personel Ekle Butonu İle Neler Olacağını Belirliyoruz.
        private void btn_personelekle_Click(object sender, EventArgs e)
        {

            //TextBoxların Enabled özelliklerine göre işlem yapıyoruz. Bu sebeple Personel Ekle buton Textine bakıyoruz.
            if (btn_personelekle.Text == "Personel Ekle")
            {
                if (bmt_adi.Text != "Personel Adı" && bmt_telefon.Text != "Telefon Numarası" && bmt_tckimlik.Text != "TC Kimnlik Numarası" && bmt_adres.Text != "Ev Adresi" && bmt_eposta.Text != "E-posta")
                {
                    //Eğer bmt_sifre1 ve bmt_sifre2 aynı değilse diye kontrolü burada yapıyoruz.
                    if ((bmt_sifre1.Text == bmt_sifre2.Text) || (bmt_sifre1.Text != "Şifre" && bmt_sifre2.Text != "Şifre Tekrarı"))
                    {
                        // Tüm şartlar sağlanırsa veritabanı.Personel_ekle fonksiyonunu çağırıyoruz
                      
                        if (veritabanı.P_sifre_Aynimi(bmt_sifre1.Text)&&veritabanı.Personel_ekle(bmt_adi.Text, bmt_telefon.Text, bmt_tckimlik.Text, bmt_eposta.Text, bmt_adres.Text, bdp_dogumtarihi.Value.ToString("yyyy-MM-dd"), bmt_sifre1.Text,cGenel.yonetici_no))
                        {
                            alarm.Show("Personel ekleme işlemi başarı ile tamamlandı.", alarm.Alarmtur.basarili);
                            veritabanı.personel_getir(p_ad, p_id);
                            Personel_btn_olustur();
                            lbl_pno.Text = veritabanı.personel_sayisi() + "";
                            lb_aciklama.Text = bmt_adi.Text + " personel olarak eklendi.";
                        }
                        else
                        {
                            alarm.Show("Personel ekleme işlemi başarısız.", alarm.Alarmtur.hata);
                        }
                    }
                    else
                        alarm.Show("Şifreler birbiri ile aynı değil.", alarm.Alarmtur.dikkat);


                }
                else
                {
                    alarm.Show("Lütfen tüm alanları eksiksiz doldurun.", alarm.Alarmtur.hata);
                }


            }
            else if (btn_personelekle.Text == "Kilidi Kaldır")
            {
                BunifuMetroTextbox p_tarih = new BunifuMetroTextbox();
                BunifuMetroTextbox[] text = { bmt_adi, bmt_telefon, bmt_tckimlik, bmt_adres, bmt_eposta, p_tarih };
                String[] ic_metinler = { "Personel Adı", "Telefon Numarası", "TC Kimlik Numarası", "Ev Adresi", "E-posta" };
                for (int i = 0; i < text.Length - 1; i++) {
                    text[i].Enabled = true;
                    text[i].Text = ic_metinler[i];
                }
                btn_personelekle.Text = "Personel Ekle";

            }


        }
        #region PlaceHolder Özelliğini Tüm TextBoxlara Uyguluyoruz.
        private void bmt_adi_Enter(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMetroTextbox gelen = (sender as Bunifu.Framework.UI.BunifuMetroTextbox);
            string isim = gelen.Name;

            if (gelen.Text == "Personel Adı" || gelen.Text == "Telefon Numarası" ||
                gelen.Text == "TC Kimlik Numarası" || gelen.Text == "Ev Adresi" || gelen.Text == "E-posta")
                gelen.Text = "";
            else if (gelen.Text == "Şifre")
            {
                gelen.Text = "";
                bmt_sifre1.isPassword = true;
            }

            else if (gelen.Text == "Şifre Tekrarı")
            {
                gelen.Text = "";
                bmt_sifre2.isPassword = true;

            }
        }

        private void bmt_adi_Leave(object sender, EventArgs e)
        {
            string isim = "";

            Bunifu.Framework.UI.BunifuMetroTextbox gelen = (sender as Bunifu.Framework.UI.BunifuMetroTextbox);
            isim = gelen.Name;

            if (gelen.Text == "")
            {
                if (gelen.Name == "bmt_adi")
                    bmt_adi.Text = "Personel Adı";

                else if (gelen.Name == "bmt_telefon")
                    bmt_telefon.Text = "Telefon Numarası";

                else if (gelen.Name == "bmt_tckimlik")
                    bmt_tckimlik.Text = "TC Kimlik Numarası";

                else if (gelen.Name == "bmt_adres")
                    bmt_adres.Text = "Ev Adresi";

                else if (gelen.Name == "bmt_eposta")
                    bmt_eposta.Text = "E-posta";

                else if (gelen.Name == "bmt_sifre1")
                {
                    bmt_sifre1.Text = "Şifre";
                    bmt_sifre1.isPassword = false;
                }

                else if (gelen.Name == "bmt_sifre2")
                {
                    bmt_sifre2.Text = "Şifre Tekrarı";
                    bmt_sifre2.isPassword = false;
                }

            }
        }
        #endregion

        private void bfb_personelsil_Click(object sender, EventArgs e)
        {
            textbox_form tb_form = new textbox_form();
            tb_form.ShowDialog();

        }

        private void bfb_personelsil_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
                MessageBox.Show("Sağ Tıklandı");
        }
        private void Personel_btn_olustur()
        {
            flp_personeller.Controls.Clear();
            int psayisi = veritabanı.personel_sayisi();

            for (int i = 0; i < psayisi; i++)
            {
                BunifuFlatButton btn = new BunifuFlatButton();
                btn.Name = "btn_" + Convert.ToInt32(p_id[i]);
                btn.IconVisible = false;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Margin = new Padding(0, 0, 3, 15);
                btn.Size = new System.Drawing.Size(flp_personeller.Width / (psayisi + 1), flp_personeller.Height / 2 - 10);
                btn.Text = "" + p_ad[i];

                Random rd = new Random();

                int x = rd.Next(0, renkler.Length);

                btn.Normalcolor = Color.FromName(renkler[x]);
                btn.OnHovercolor = Color.FromName(aktif_renkler[x]);
                btn.Activecolor = Color.DarkBlue;
                flp_personeller.Controls.Add(btn);
                btn.Click += personel_Click;

            }
        }

        private void personel_Click(object sender, EventArgs e)
        {
            BunifuMetroTextbox p_tarih = new BunifuMetroTextbox();
            BunifuMetroTextbox[] text = { bmt_adi, bmt_adres, bmt_eposta, bmt_tckimlik, bmt_telefon, p_tarih };
            BunifuFlatButton gelen = (BunifuFlatButton)sender;
            string[] id = gelen.Name.Split('_');// '_' göre metni parcalar
            int p_id = Convert.ToInt32(id[1]);
            veritabanı.id_personel_getir(text, p_id);
            for (int i = 0; i < text.Length - 1; i++)
                text[i].Enabled = false;
            btn_personelekle.Text = "Kilidi Kaldır";
            TimeSpan gun = new TimeSpan(2010, 10, 10);

            bdp_dogumtarihi.Value = DateTime.Parse(p_tarih.Text);
            lb_aciklama.Text = "Tekrar personel ekleyebilmek için lütfen 'Kilidi Kaldır' butonuna tıklayınız.";



        }

        private void yenile_Tick(object sender, EventArgs e)
        {
            response(cGenel.genislik, cGenel.yukseklik);
            yenile.Enabled = false;
        }
    }
        

}
