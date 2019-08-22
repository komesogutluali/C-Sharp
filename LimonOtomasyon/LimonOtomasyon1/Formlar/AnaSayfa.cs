using Bunifu.Framework.UI;
using LimonOtomasyon.Sınıflar;
using LimonOtomasyon1.Formlar;
using LimonOtomasyon1.Formlar.KucukFormlar;
using LimonOtomasyon1.Sınıflar;
using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace LimonOtomasyon1
{

    public partial class anasayfa : Form
    {
        Database veritabani = new Database();
        BaslangicAyarlari ayarlar = new BaslangicAyarlari();
        //Açık masa sayısını öğrenmek için kullanacağız.
        ArrayList acik_masa = new ArrayList();
        
        public anasayfa()
        {
            InitializeComponent();
            //Yapılan Son İşlemleri Getiriyoruz.
            //veritabani.Sonislem_getir(lv_sonislemler);

            // Son işlemleri otomatik olarak getiriyoruz ve sonrasında satır renklerini ayarlıyoruz..
            veritabani.Sonislem_getir(lv_sonislemler);
            foreach (ListViewItem item in lv_sonislemler.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.White : Color.MistyRose;
            }
            
            //Footer kısımında yer alan bilgi metinlerini getiriyoruz.
            //Geçiçi olarak program ilk açıldığında Masa butonlarını gösteriyoruz.
            pl_icerik.Controls.Clear();//formun içini temizliyoruz..
            masa_butonlari newForm = new masa_butonlari(pl_icerik);
            newForm.TopLevel = false;
            pl_icerik.Controls.Add(newForm);
            newForm.Dock = DockStyle.Fill;
            newForm.Show();

            //Yönetici ve Personele göre ekran değişebilmesi için aşağıdaki fonksiyonu çağırıyoruz.
            kim_geldi();

            footer_metin_bilgileri();

        }
        /* Programı Kapatma Menüsü */
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*Programı Tam Ekran veya Normale Döndürme Butonu */
        private void btn_boyut_Click(object sender, EventArgs e)
        {
            // Ekranın Büyük - Küçük Ayarı
            if (this.WindowState == FormWindowState.Normal) { 
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

            veritabani.Sonislem_getir(lv_sonislemler);
            foreach (ListViewItem item in lv_sonislemler.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.White : Color.MistyRose;
            }
        }

        /* Programı Gizleme Butonu  */
        private void btn_kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /* Hamburger Menü İle İlgili Ayarlar */
        private void btn_hamburger_Click(object sender, EventArgs e)
        {
            hamburger_button();
         
        }
       
        /* Programın Farklı Çözünürlükte ki Ayarları İle İlgili Fonksiyon */
        private void responsive(int gen_form1, int yuk_form1)
        {

            flp_sonlar.Location = new Point(
            pl_footer.ClientSize.Width / 2 - flp_sonlar.Size.Width / 2,
            pl_footer.ClientSize.Height / 2 - flp_sonlar.Size.Height / 2);
            flp_sonlar.Anchor = AnchorStyles.None;
          

            #region  Full HD Çözünürlük İçin Responsive Ayarları (1920 x 1080)
            if (gen_form1 == 1920 && yuk_form1 == 1080)
            {
                 /*Her Durumda Gerçekleşecek Eylemler
                 Son İşlemler Menüsü Gözükür Hale Gelecek, Butonu Aktif Olacak 
                 Ve Standart Button Panelinin Genişliği 300 px olacak.
                 */
                fpl_standartbutton.Width = 300;
                fpl_sonislemler.Width = 300;
                btn_sonislemler.Visible = true;

                /* Çözünürlüğe göre Menu Panelinin Padding değerini arttırıyoruz. Böylece menü ortalanıyor.*/
                flp_menubutton.Padding = new Padding(0, 200, 0, 200);
                /* Çözünürlüğe göre Footer içindeki SONLAR panelinin Padding ayarlarını yapıyoruz.*/
                flp_sonlar.Padding = new Padding(8, 4, 8, 0);
                flp_sonlar.Width = pl_footer.Width - 50;
            }
            #endregion

            #region 15.7" Ekranlar İçin - 1536 x 864
            else if (gen_form1 == 1536 && yuk_form1 == 864)
            {
                /*Her Durumda Gerçekleşecek Eylemler
                    Son İşlemler Menüsü Gözükür Hale Gelecek, Butonu Aktif Olacak 
                    Ve Standart Button Panelinin Genişliği 300 px olacak.
                */
                fpl_standartbutton.Width = 300;
                fpl_sonislemler.Width = 300;
                btn_sonislemler.Visible = true;

                /* Çözünürlüğe göre Menu Panelinin Padding değerini arttırıyoruz. Böylece menü ortalanıyor.*/
                flp_menubutton.Padding = new Padding(0, 100, 0, 100);
                /* Çözünürlüğe göre Footer içindeki SONLAR panelinin Padding ayarlarını yapıyoruz.*/
                flp_sonlar.Padding = new Padding(8, 4, 8, 0);
                flp_sonlar.Width = pl_footer.Width - 50;

            }
            #endregion
            #region Böğürtlen Büfe -  Ekranlar İçin - 1536 x 864
            else if (gen_form1 == 1366 && yuk_form1 == 768)
            {
                /*Her Durumda Gerçekleşecek Eylemler
                    Son İşlemler Menüsü Gözükür Hale Gelecek, Butonu Aktif Olacak 
                    Ve Standart Button Panelinin Genişliği 300 px olacak.
                */
                fpl_standartbutton.Width = 300;
                fpl_sonislemler.Width = 300;
                btn_sonislemler.Visible = true;

                /* Çözünürlüğe göre Menu Panelinin Padding değerini arttırıyoruz. Böylece menü ortalanıyor.*/
                flp_menubutton.Padding = new Padding(0, 75, 0, 75);
                /* Çözünürlüğe göre Footer içindeki SONLAR panelinin Padding ayarlarını yapıyoruz.*/
                flp_sonlar.Padding = new Padding(0, 4, 0, 0);
                flp_sonlar.Width = pl_footer.Width - 50;
            }
            #endregion


            #region Normal Boyuttaki Pencere İçin Gerekli Ayarlar
            else if (gen_form1 == 1200 && yuk_form1 == 650)
            {

                if (pl_menu.Width == 325 || pl_menu.Width == 300)
                    pl_menu.Width = 300;

                //1. Standart Ekran Boyutunda Son İşlemler Penceresi ve Butonu Gözükmeyecek.
                fpl_sonislemler.Width = 0;
                btn_sonislemler.Visible = false;
                //2. Programın Standart Butonlar Kısımının genişliği 200 px olacak.
                fpl_standartbutton.Width = 200;
                //  MessageBox.Show("Genişlik : " + pl_content.Width + "  Yükseklik : " + pl_content.Height);

               
                /* Çözünürlüğe göre Menu Panelinin Padding değerini arttırıyoruz. Böylece menü ortalanıyor.*/
                flp_menubutton.Padding = new Padding(0, 0, 0, 0);
                flp_sonlar.Width = 657;
                flp_sonlar.Location = new Point(
                pl_footer.ClientSize.Width / 2 - flp_sonlar.Size.Width / 2,
                pl_footer.ClientSize.Height / 2 - flp_sonlar.Size.Height / 2);
                flp_sonlar.Anchor = AnchorStyles.None;
            }
            //Tüm Çözünürlüklere Uygun Kodlar
            else
            {
                flp_sonlar.Location = new Point(
                pl_footer.ClientSize.Width / 2 - flp_sonlar.Size.Width / 2,
                pl_footer.ClientSize.Height / 2 - flp_sonlar.Size.Height / 2);
                flp_sonlar.Anchor = AnchorStyles.None;
            }
            #endregion


        }
        // Program ilk defa açıldığında neler yapacağını burada belirliyoruz.
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 650;
            this.Width = 1200;
            cGenel.menu_acikmi = true;
            // Programın Adresini cGenel sınıfına yazıyoruz.
            cGenel.program_adresi = Application.StartupPath;
            //MessageBox.Show(cGenel.program_adresi);

           
        }

        private void son_islemler_button()
        {

            if (fpl_sonislemler.Visible == false)
            {
                // Son İşlemler Kısımını Açıyoruz.
               
                    sonislem_animasyon.ShowSync(fpl_sonislemler);
                    fpl_sonislemler.Visible = true;
                veritabani.Sonislem_getir(lv_sonislemler);

                foreach (ListViewItem item in lv_sonislemler.Items)
                {
                    item.BackColor = item.Index % 2 == 0 ? Color.White : Color.MistyRose;
                }

            }
            else
            {
                // Son İşlemler Kısımını Gizliyoruz.
                sonislem_animasyon.Hide(fpl_sonislemler);
                fpl_sonislemler.Visible = false;
            }


        }
        private void hamburger_button()
        {
            /*Menü Küçük İse Büyültüyoruz ve responsive olması için responsive Fonksiyonunu çağırıyoruz.*/
            if (pl_menu.Width == 65)
            {
                    pl_menu.Width = 300;
                    pl_menu.Visible = false;
                    cGenel.menu_acikmi = true;
                    MAcAni.ShowSync(pl_menu);
                    LogoAnimasyon.ShowSync(pb_buyuklogo);
                    LogoAnimasyon.HideSync(pb_kucukLogo);
            }
            else
            {
                LogoAnimasyon.Hide(pb_buyuklogo);
                LogoAnimasyon.ShowSync(pb_kucukLogo);
                pl_menu.Visible = false;
                pl_menu.Width = 65;
                cGenel.menu_acikmi = false;
                MKapAni.ShowSync(pl_menu);
            }
        }

        private void btn_sonislemler_Click(object sender, EventArgs e)
        {
            son_islemler_button();
        }

        private void menu_buton_Click(object sender, EventArgs e)
        {
            string isim = "";
            int buton_no;

            BunifuFlatButton genel = (sender as BunifuFlatButton);
            isim = genel.Name;
            buton_no = Convert.ToInt16(isim.Substring(4, 2));

            footer_metin_bilgileri();

            if (buton_no == 1)
            {
                //Sakın Silme !!
                //pl_icerik.Controls.Clear();
                //pl_icerik.Controls.Add(pl_nelervar);

                //pl_nelervar.Location = new Point(
                // pl_icerik.ClientSize.Width / 2 - pl_nelervar.Size.Width / 2,
                //pl_icerik.ClientSize.Height / 2 - pl_nelervar.Size.Height / 2);
                //pl_nelervar.Anchor = AnchorStyles.None;

                //pl_nelervar.Controls.Clear();//formun içini temizliyoruz..
                //neler_sunuyoruz newForm = new neler_sunuyoruz();
                //newForm.TopLevel = false;
                //pl_nelervar.Controls.Add(newForm);
                //newForm.Dock = DockStyle.Fill;
                //newForm.Show();

                alarm.Show("Ana sayfa çok yakında.", alarm.Alarmtur.basarili);
            }
            else if (buton_no == 2)
            {
                pl_icerik.Controls.Clear();//formun içini temizliyoruz..
                masa_butonlari newForm = new masa_butonlari(pl_icerik);
                newForm.TopLevel = false;
                pl_icerik.Controls.Add(newForm);
                newForm.Dock = DockStyle.Fill;
                newForm.Show();
            }
            else if (buton_no == 3)
            {
                personel_giris giris = new personel_giris("yonetici", false);
                giris.ShowDialog();

                if (cGenel.personel_girisi == true)
                {
                    pl_icerik.Controls.Clear();//formun içini temizliyoruz..
                    urunler newForm = new urunler();
                    newForm.TopLevel = false;
                    pl_icerik.Controls.Add(newForm);
                    newForm.Dock = DockStyle.Fill;
                    newForm.Show();
                }
                else
                    alarm.Show("Bu sayfayı görme yetkiniz yok.", alarm.Alarmtur.hata);
            }
            else if (buton_no == 4)
            {
                pl_icerik.Controls.Clear();//formun içini temizliyoruz..
                Sonislemler newForm = new Sonislemler();
                newForm.TopLevel = false;
                pl_icerik.Controls.Add(newForm);
                newForm.Show();
                newForm.Dock = DockStyle.Fill;
            }
            else if (buton_no == 5)
            {
                personel_giris giris = new personel_giris("yonetici",false);
                giris.ShowDialog();

                if (cGenel.personel_girisi == true)
                {
                    pl_icerik.Controls.Clear();//formun içini temizliyoruz..
                    personel newForm = new personel();
                    newForm.TopLevel = false;
                    pl_icerik.Controls.Add(newForm);
                    newForm.Show();
                    newForm.Dock = DockStyle.Fill;
                }
                else
                    alarm.Show("Bu sayfayı görme yetkiniz yok.", alarm.Alarmtur.hata);
            }
            //Hesap Defteri
            else if (buton_no == 6)
            {
                if (ayarlar.internet_var_mi())
                {//internet bağlantısı var ise çalışacak. (Baslangic)
                    personel_giris giris = new personel_giris("yonetici",true);
                    giris.ShowDialog();

                    if (cGenel.personel_girisi == true)
                    {
                        pl_icerik.Controls.Clear();//formun içini temizliyoruz..
                        hesapdefteri newForm = new hesapdefteri();
                        newForm.TopLevel = false;
                        pl_icerik.Controls.Add(newForm);
                        newForm.Show();
                        newForm.Dock = DockStyle.Fill;
                    }//internet bağlantısı var ise çalışacak. (Son)
                    else
                        alarm.Show("Bu sayfayı görme yetkiniz yok.", alarm.Alarmtur.hata);
                }
                else
                {//internet bağlantısı yok ise çalışacak.
                    MessageBox.Show("Lütfen internet bağlantınızı kontrol edin.");
                }
            }
       
            //Raporlar (buton_no == 7)
            else if(buton_no == 7)
            {
                if (ayarlar.internet_var_mi())
                { //İnternet bağlantısı var ise çalışacak. (Baslangic)
                personel_giris giris = new personel_giris("yonetici",true);
                giris.ShowDialog();

                if (cGenel.personel_girisi == true)
                {
                    pl_icerik.Controls.Clear();//formun içini temizliyoruz..
                   
                }
                else
                    alarm.Show("Bu sayfayı görme yetkiniz yok.", alarm.Alarmtur.hata);
                }//internet bağlantısı var ise (SON)
                else
                {//internet bağlantısı yok ise çalışacak.
                    MessageBox.Show("Lütfen internet bağlantınızı kontrol edin.");
                }
            }
            else if (buton_no == 8)
            {
                personel_giris giris = new personel_giris("yonetici",false);
                giris.ShowDialog();

                if (cGenel.personel_girisi == true)
                {
                    pl_icerik.Controls.Clear();//formun içini temizliyoruz..
                    ayarlar newForm = new ayarlar();
                    newForm.TopLevel = false;
                    pl_icerik.Controls.Add(newForm);
                    newForm.Show();
                    newForm.Dock = DockStyle.Fill;
                }
                else
                    alarm.Show("Bu sayfayı görme yetkiniz yok.", alarm.Alarmtur.hata);
            }
            //Son işlemler kısımını güncelliyoruz
            veritabani.Sonislem_getir(lv_sonislemler);
            foreach (ListViewItem item in lv_sonislemler.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.White : Color.MistyRose;
            }

        }

        private void anasayfa_SizeChanged(object sender, EventArgs e)
        {
            cGenel.yukseklik = this.Size.Height;
            cGenel.genislik = this.Size.Width;
            //MessageBox.Show("Genişlik : " + cGenel.genislik + " - Yükseklik : " + cGenel.yukseklik);
            responsive(cGenel.genislik, cGenel.yukseklik);
        }

        public void footer_metin_bilgileri()
        {


        }
   
       private void kim_geldi()
        {
            /*kim_girisyapti == false ise Personel girmiş anlamına geliyor.Bu sebep personelin
             * görmemesi gereken sayfaları kapatıyoruz.*/
            if(cGenel.kim_girisyapti == false)
            {
                bfb_03.Visible = false;
                bfb_05.Visible = false;
                bfb_06.Visible = false;
                bfb_08.Visible = false;
            }
        }

        //Gölge Efekti
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                cp.ClassStyle |= 0x20000;

                return cp;
            }
        }

        private void cikis_yap_Click(object sender, EventArgs e)
        {
            this.Hide();
            login giris = new login();
            giris.Show();
        }
    }
}
