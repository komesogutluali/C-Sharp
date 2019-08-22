using Bunifu.Framework.UI;
using System;
using System.Drawing;
using System.Windows.Forms;
using LimonOtomasyon1.Sınıflar;
using LimonOtomasyon1.Formlar.KucukFormlar;
using LimonOtomasyon1.Formlar;
using System.Globalization;

namespace LimonOtomasyon1
{
    public partial class masa : Form
    {
        public static int p_id;
        Database veritabani = new Database();
        /*Kategoriler - Hesap Makinesi gibi butonları oluştururuken random renkleri kullanıyoruz.*/
        String[] renkler = { "Orange", "Teal", "DarkGreen", "LightSeaGreen", "SteelBlue", "MidnightBlue",
            "BlueViolet", "DarkViolet", "Purple", "DarkOrange", "Firebrick","Tomato","OliveDrab","RoyalBlue" };
        String[] aktif_renkler = { "Teal", "LightSeaGreen", "MidnightBlue", "DarkViolet", "DarkOrange", "DarkGreen",
            "Orange", "SteelBlue", "BlueViolet", "Purple", "LightCoral","Chocolate","SeaGreen","DeepSkyBlue" };
        int secilen_id;//secilen masa

        Panel icerik = new Panel();

        public masa(int id, Panel pl_icerik)
        {

            InitializeComponent();
            secilen_id = id;
            label_masano.Text = "Masa \n"+(secilen_id).ToString();
            //Formu kapattığımızda Masa Sayfası açılsın diye panel oluşturuyoruz.
            icerik = pl_icerik;

            string M_TakmaAd = veritabani.Masa_İsimKontrol(secilen_id);
            if (!M_TakmaAd.Equals("")) { 
                lb_islemler.Text = "Masa - " + secilen_id + " | " + M_TakmaAd + "";
            }
            veritabani.Adisyon_getir(secilen_id, lb_adisyon);
            geneltutar();

            #region Program yüklenirken Adisyon ve Ürünler tablosunun satırlarının rengini düzenliyoruz.
            foreach (ListViewItem item in lb_urunler.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.White : Color.WhiteSmoke;
            }
            foreach (ListViewItem item in lb_adisyon.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.White : Color.WhiteSmoke;
            }
            #endregion
         
        }
        private double geneltutar()
        {
            double geneltop = 0;
            for(int i=0;i< lb_adisyon.Items.Count;i++)
                geneltop+= Convert.ToDouble(lb_adisyon.Items[i].SubItems[2].Text);
            lb_toplam.Text = geneltop + " ₺";
            return geneltop;
        }
        private void masa_Load(object sender, EventArgs e)
        {
            response(cGenel.genislik, cGenel.yukseklik, cGenel.menu_acikmi);
        }
        private void response(int gen_masa, int yuk_masa, bool menu)
        {
            //MessageBox.Show("Genişlik : " + this.Size.Width + "Yükseklik : " + this.Size.Height);

            #region 1920x1080 (Full HD) Ekranlar İçin Gerekli Ayarlamalar
            if (gen_masa == 1200 && yuk_masa == 650)
            {
                // Standart Pencere Boyutunda

                /*Tasarımın en üst kısımında yer alan Hızlı İşlem Menüsünü tam ortalayabilmek için aşağıdaki kodları yazdık.*/
                tlp_hizlimenu.Width = pl_header.Width - 25;
                tlp_hizlimenu.Height = pl_header.Height - 10;

                tlp_hizlimenu.Location = new Point(
                pl_header.ClientSize.Width / 2 - tlp_hizlimenu.Size.Width / 2,
                pl_header.ClientSize.Height / 2 - tlp_hizlimenu.Size.Height / 2);
                tlp_hizlimenu.Anchor = AnchorStyles.None;
                //TableLayoutPanel'in satırlarını yüzdelik olarak böldük.
                tlp_hizlimenu.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 80);
                tlp_hizlimenu.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 20);
                //Hesap Makinesi Tuşlarının Çözünürlük Ayarlarını Yapıyoruz.
                pl_hesapmakinesi.Height = 240;


                /*Ürünlerin yer aldığı ListView'in Kolon genişliklerini ayarlıyoruz. */
                lb_urunler.Columns[0].Width = lb_urunler.Width / 2 - 2;
                lb_urunler.Columns[1].Width = lb_urunler.Width / 2 - 2;

                /*Adisyonların yer aldığı ListView'in Kolan Genişliklerini Ayarlıyoruz*/
                lb_adisyon.Columns[0].Width = lb_adisyon.Width / 4 + 73;
                lb_adisyon.Columns[1].Width = lb_adisyon.Width / 4 - 50;
                lb_adisyon.Columns[2].Width = lb_adisyon.Width / 4 - 25;
                lb_adisyon.Columns[3].Width = lb_adisyon.Width / 4 - 1;

                /*Çözünürlük değiştiğinde pl_alt ve pl_üst panellerin Padding değerlerini değiştiriyoruz.*/
                pl_adisyon.Padding = new Padding(5, 15, 5, 5);
                pl_urunler.Padding = new Padding(5, 15, 5, 5);
                tlp_buttonlar.Height = 120;
                //pl_sagalt.Height = tlp_buttonlar.Height + 90
                pl_sagalt.Height = 210;
                bfb_gerigit.Height = 50;
                bfb_hesabikapat.Height = 50;
                bfb_masatasi.Height = 50;
                bfb_oncekiadisyon.Height = 50;

                flp_hesapmakinesituslari.Height = 170;

                flp_kategori.Height = 410;
                flp_kategori.Width = flp_masaadi.Width;

                kategori_button();
                hesapmakinesi_tuslari();
                hizlimenu_tuslari();


            }
            else if (gen_masa == 1920 && yuk_masa == 1080)
            {
                // Son İşlemler ve Menü Açık Olduğunda

                /*Tasarımın en üst kısımında yer alan Hızlı İşlem Menüsünü tam ortalayabilmek için aşağıdaki kodları yazdık.*/
                tlp_hizlimenu.Width = pl_header.Width - 100;
                tlp_hizlimenu.Location = new Point(
                pl_header.ClientSize.Width / 2 - tlp_hizlimenu.Size.Width / 2,
                pl_header.ClientSize.Height / 2 - tlp_hizlimenu.Size.Height / 2);
                tlp_hizlimenu.Anchor = AnchorStyles.None;
                //TableLayoutPanel'in satırlarını yüzdelik olarak böldük.
                tlp_hizlimenu.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 85);
                tlp_hizlimenu.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 15);
                //Hesap Makinesi Tuşlarının Çözünürlük Ayarlarını Yapıyoruz.
                pl_hesapmakinesi.Height = 350;
                /*Kategori Butonlarının olduğu panelleri ayarlamak için aşağıdaki kodları yazdık*/
                flp_kategori.Height = flp_sol.Height - 50;
                flp_kategori.Width = flp_masaadi.Width;
               

                /*Ürünlerin yer aldığı ListView'in Kolon genişliklerini ayarlıyoruz. */
                lb_urunler.Columns[0].Width = lb_urunler.Width / 2 - 2;
                lb_urunler.Columns[1].Width = lb_urunler.Width / 2 - 2;

                /*Adisyonların yer aldığı ListView'in Kolan Genişliklerini Ayarlıyoruz*/
                lb_adisyon.Columns[0].Width = lb_adisyon.Width / 4 + 73;
                lb_adisyon.Columns[1].Width = lb_adisyon.Width / 4 - 50;
                lb_adisyon.Columns[2].Width = lb_adisyon.Width / 4 - 25;
                lb_adisyon.Columns[3].Width = lb_adisyon.Width / 4 - 1;

                /*Çözünürlük değiştiğinde pl_alt ve pl_üst panellerin Padding değerlerini değiştiriyoruz.*/
                pl_adisyon.Padding = new Padding(5, 15, 5, 25);
                pl_urunler.Padding = new Padding(5, 15, 5, 25);

                tlp_buttonlar.Height = 175;
                pl_sagalt.Height = 300;

                //pl_sagalt.Height = tlp_buttonlar.Height + 100;
                bfb_gerigit.Height = 70;
                bfb_hesabikapat.Height = 70;
                bfb_masatasi.Height = 70;
                bfb_oncekiadisyon.Height = 70;

                flp_hesapmakinesituslari.Height = 350;

                kategori_button();
                hesapmakinesi_tuslari();
                hizlimenu_tuslari();


            }
            else if(menu == true && (gen_masa == 1920 && yuk_masa == 1080))
            {
                // Her Şey Kapalı Olduğu Zaman

                /*Tasarımın en üst kısımında yer alan Hızlı İşlem Menüsünü tam ortalayabilmek için aşağıdaki kodları yazdık.*/
                tlp_hizlimenu.Width = pl_header.Width - 100;
                tlp_hizlimenu.Location = new Point(
                pl_header.ClientSize.Width / 2 - tlp_hizlimenu.Size.Width / 2,
                pl_header.ClientSize.Height / 2 - tlp_hizlimenu.Size.Height / 2);
                tlp_hizlimenu.Anchor = AnchorStyles.None;
                //TableLayoutPanel'in satırlarını yüzdelik olarak böldük.
                tlp_hizlimenu.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 90);
                tlp_hizlimenu.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 10);
                //Hesap Makinesi Tuşlarının Çözünürlük Ayarlarını Yapıyoruz.
                pl_hesapmakinesi.Height = 350;


                /*Ürünlerin yer aldığı ListView'in Kolon genişliklerini ayarlıyoruz. */
                lb_urunler.Columns[0].Width = lb_urunler.Width / 2 - 2;
                lb_urunler.Columns[1].Width = lb_urunler.Width / 2 - 2;

                /*Adisyonların yer aldığı ListView'in Kolan Genişliklerini Ayarlıyoruz*/
                lb_adisyon.Columns[0].Width = lb_adisyon.Width / 4 + 73;
                lb_adisyon.Columns[1].Width = lb_adisyon.Width / 4 - 50;
                lb_adisyon.Columns[2].Width = lb_adisyon.Width / 4 - 25;
                lb_adisyon.Columns[3].Width = lb_adisyon.Width / 4 - 1;

                /*Çözünürlük değiştiğinde pl_alt ve pl_üst panellerin Padding değerlerini değiştiriyoruz.*/
                pl_adisyon.Padding = new Padding(5, 15, 5, 25);
                pl_urunler.Padding = new Padding(5, 15, 5, 25);

                tlp_buttonlar.Height = 175;
                pl_sagalt.Height = 300;

                //pl_sagalt.Height = tlp_buttonlar.Height + 100;
                bfb_gerigit.Height = 70;
                bfb_hesabikapat.Height = 70;
                bfb_masatasi.Height = 70;
                bfb_oncekiadisyon.Height = 70;

                flp_hesapmakinesituslari.Height = 350;

                flp_kategori.Height = flp_sol.Height;
                flp_kategori.Width = flp_masaadi.Width;

                kategori_button();
                hesapmakinesi_tuslari();
                hizlimenu_tuslari();


            }
            else if(gen_masa == 1366 && yuk_masa == 768)
            {
                kategori_button();
                hesapmakinesi_tuslari();
                hizlimenu_tuslari();
            }
            #endregion
        }



        private void masa_SizeChanged(object sender, EventArgs e)
        {
            response(cGenel.genislik,cGenel.yukseklik,cGenel.menu_acikmi);
        
        }
        ComboBox k_ad = new ComboBox();
        ComboBox k_id = new ComboBox();
        private void kategori_button()
        {   
            flp_kategori.Controls.Clear();
            veritabani.U_ComboDoldur(k_id, k_ad);
            int btn_sayi = k_id.Items.Count;
         
        
            for (int i = 0; i < btn_sayi; i++)
            {
                
                BunifuFlatButton btn = new BunifuFlatButton();
                btn.Name = "btn_" + Convert.ToInt32(k_id.Items[i]);
                btn.IconVisible = false;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Margin = new Padding(0, 0, 0, 3);
                btn.Size = new System.Drawing.Size(flp_kategori.Width, flp_kategori.Height / (btn_sayi+2) -10);
                k_ad.SelectedIndex = i;
                btn.Text = k_ad.Items[i].ToString();

                Random rd = new Random();
                int x = rd.Next(0 , renkler.Length);
                
                btn.Normalcolor = Color.FromName(renkler[x]);
                btn.OnHovercolor = Color.FromName(aktif_renkler[x]);
                btn.Activecolor = Color.DarkBlue;

                //Click fonksiyonu oluşturuyoruz.
                btn.Click += kategori_click;
                flp_kategori.Controls.Add(btn);
            }

        }
        ComboBox u_id = new ComboBox();// Ürün idlerini tutar
        ComboBox hizli_urun = new ComboBox();// Ürün idlerini tutar
        ComboBox hizli_id = new ComboBox();// Ürün idlerini tutar
        private void kategori_click(object sender, EventArgs e)
        {
            BunifuFlatButton gelen = (BunifuFlatButton)sender;
            string[] id = gelen.Name.Split('_');// '_' göre metni parcalar
            int secilen_id = Convert.ToInt32(id[1]);
            veritabani.U_ListSec(lb_urunler, secilen_id);
            // ListView de satırların rengini değiştiriyoruz.
            foreach (ListViewItem item in lb_urunler.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.White : Color.WhiteSmoke;
            }
        }

        private void hesapmakinesi_tuslari()
        {
            flp_hesapmakinesituslari.Controls.Clear();
            flp_hesapmakinesituslari.Controls.Add(tb_adet);

            for (int k = 1; k <= 11; k++)
            {
                if (k<10)
                {
                    BunifuFlatButton btn = new BunifuFlatButton();
                    btn.Name = "hbtn_" + 0+k.ToString();
                    btn.IconVisible = false;
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Margin = new Padding(0, 0, 2, 4);
                    btn.Text = k.ToString();
                    btn.Size = new System.Drawing.Size(flp_hesapmakinesituslari.Width / 3 -5, flp_hesapmakinesituslari.Height / 5-5);
                  
                    flp_hesapmakinesituslari.Controls.Add(btn);
                    btn.Click += hesapmakinesi_btn_Click;
                }
                if (k == 10)
                {
                    BunifuFlatButton btn = new BunifuFlatButton();
                    btn.Name = "hbtn_" + k.ToString();
                    btn.IconVisible = false;
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Margin = new Padding(0, 0, 2, 4);
                    btn.Text = "SİL";
                    btn.Size = new System.Drawing.Size((flp_hesapmakinesituslari.Width / 3) * 2 -7, flp_hesapmakinesituslari.Height / 5-5);

                    flp_hesapmakinesituslari.Controls.Add(btn);
                    btn.Click += hesapmakinesi_btn_Click;

                }
                if (k == 11)
                {
                    BunifuFlatButton btn = new BunifuFlatButton();
                    btn.Name = "hbtn_" + k.ToString();
                    btn.IconVisible = false;
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Margin = new Padding(0, 0, 2, 4);
                    btn.Text = "0";
                    btn.Size = new System.Drawing.Size((flp_hesapmakinesituslari.Width / 3)-5, flp_hesapmakinesituslari.Height / 5-5);

                    flp_hesapmakinesituslari.Controls.Add(btn);
                    btn.Click += hesapmakinesi_btn_Click;
                }
            }
        }

    

        private void hizlimenu_tuslari()
        {
            flp_hizlimenu.Controls.Clear();
            int btn_sayi = veritabani.hizlimsayisi_bul();
            if (flp_hizlimenu.Width < 750) { 
                btn_sayi = veritabani.hizlimsayisi_bul();
                if (btn_sayi > 9)
                    btn_sayi = 9;
            }
            veritabani.hizli_menu_getir(hizli_urun, hizli_id);
            if (btn_sayi > 0) { 
            for (int i = 0; i < btn_sayi; i++)
            {
                BunifuFlatButton btn = new BunifuFlatButton();
                btn.Name = "btn_" + Convert.ToInt32(hizli_id.Items[i]);
                btn.IconVisible = false;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Margin = new Padding(0, 0, 3, 15);
                btn.Size = new System.Drawing.Size(flp_hizlimenu.Width / (btn_sayi+1), flp_hizlimenu.Height - 10);
                btn.Text = "" + hizli_urun.Items[i];

                Random rd = new Random();

                int x = rd.Next(0, renkler.Length);

                btn.Normalcolor = Color.FromName(renkler[x]);
                btn.OnHovercolor = Color.FromName(aktif_renkler[x]);
                btn.Activecolor = Color.DarkBlue;
                flp_hizlimenu.Controls.Add(btn);
                btn.Click += hizlimenu_btn_Click;

                }
            }
            else
            {
                MessageBox.Show("Hızlı Menüde hiçbir ürün yok hemen eklemek ister misiniz ?");
            }
           
        }
        private void hizlimenu_btn_Click(object sender, EventArgs e)
        {
            BunifuFlatButton gelen = (BunifuFlatButton)sender;
            string[] id = gelen.Name.Split('_');// '_' göre metni parcalar
            int urun_id = Convert.ToInt32(id[1]);
            string urun = gelen.Text;

            int miktar;
            bool ceviri1;
            if (tb_adet.Text == "Ürün Adeti Yazınız")
            {
                miktar = 1;
                ceviri1 = true;
            }
            else 
              ceviri1   = Int32.TryParse(tb_adet.Text, out miktar);
            
            if (ceviri1)
            {
                DateTime tarih = DateTime.Now;
                veritabani.Adisyon_Ekle(secilen_id, urun_id, miktar,tarih.ToString("yyyy/MM/dd H:mm:ss"));
                veritabani.Adisyon_getir(secilen_id, lb_adisyon);
                geneltutar();
            }
            else
                alarm.Show("Lütfen adet kısmında sadece rakamları kullanın.", alarm.Alarmtur.hata);

        }
        private void hesapmakinesi_btn_Click(object sender,EventArgs e)
        {
            BunifuFlatButton btn = (sender as BunifuFlatButton);
            string btn_no = btn.Name.Substring(5,2);
            Convert.ToInt32(btn_no);

            if (Convert.ToInt32(btn_no) < 10)
            {
                if (tb_adet.Text == "Ürün Adeti Yazınız")
                    tb_adet.Text = Convert.ToInt32(btn_no).ToString();
                else
                    tb_adet.Text += Convert.ToInt32(btn_no).ToString();

            }
            else if (Convert.ToInt32(btn_no) == 10)
            {
                //Bu kısımda SİL butonunu yaptık.
                if (tb_adet.Text != "" && tb_adet.Text != "Ürün Adeti Yazınız")
                {
                    btn_no = tb_adet.Text.Remove(tb_adet.Text.Length - 1, 1);
                    tb_adet.Text = btn_no.ToString();
                    if (tb_adet.Text == "")
                    {
                        tb_adet.Text = "Ürün Adeti Yazınız";
                    }
                }
            }
            else
            {
                tb_adet.Text += 0;
            }
        }

        private void yenile_Tick(object sender, EventArgs e)
        {
            response(cGenel.genislik, cGenel.yukseklik, cGenel.menu_acikmi);
            yenile.Enabled = false;
        }

      
        //Masa ismini degistirme Butonu
        private void btb_degistir_Click(object sender, EventArgs e)
        {
            if (bmt_masaad.Text.Length > 0)
            {
                veritabani.Masa_İsimDegistir(secilen_id, bmt_masaad.Text);
                alarm.Show("Masa - " + secilen_id + " ismi " +bmt_masaad.Text + " olarak değiştirildi.",alarm.Alarmtur.basarili);
                lb_islemler.Text = "Masa - " + secilen_id + " | " + bmt_masaad.Text + "";
            }
            MessageBox.Show(flp_hizlimenu.Width.ToString());
        }

        private void lb_urunler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        

                //String[] ekle = { lb_urunler.SelectedItems[0].SubItems[0].Text,tb_adet.Text, };
            int Miktar = 0;
            bool k = false ;
            int u_id = 0;

            bool k1 = Int32.TryParse(lb_urunler.SelectedItems[0].SubItems[2].Text, out u_id);

            if (tb_adet.Text == "Ürün Adeti Yazınız")
            {
                Miktar = 1;
                k = true;
            }
            else
                k = Int32.TryParse(tb_adet.Text, out Miktar);

            if (k1)
            {
                if (k)
                {
                    DateTime tarih = DateTime.Now;
                    veritabani.Adisyon_Ekle(secilen_id, u_id, Miktar, tarih.ToString("yyyy/MM/dd H:mm:ss"));
                    veritabani.Adisyon_getir(secilen_id, lb_adisyon);
                    geneltutar();
                    veritabani.Son_islem_ekle("Masa " + secilen_id + " " + lb_urunler.SelectedItems[0].SubItems[0].Text + "  Eklendi", tarih.ToString("yyyy/MM/dd H:mm"), p_id);
                    tb_adet.Text = "1";

                    foreach (ListViewItem item in lb_adisyon.Items)
                    {
                        item.BackColor = item.Index % 2 == 0 ? Color.White : Color.WhiteSmoke;
                    }
                }
                else
                    alarm.Show("Adet kısımı sadece rakamlardan oluşmalı.", alarm.Alarmtur.hata);
            }
        }

        private void lb_adisyon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int adisyon_no = 0;
            bool k1 = Int32.TryParse(lb_adisyon.SelectedItems[0].SubItems[4].Text, out adisyon_no );
            if (k1)
            {

                DateTime tarih = DateTime.Now;
               
                veritabani.Son_islem_ekle("Masa " + secilen_id + " " + lb_adisyon.SelectedItems[0].SubItems[0].Text + "  Silindi",tarih.ToString("yyyy/MM/dd H:mm"), p_id);

                veritabani.Adisyon_Sil(adisyon_no);
                veritabani.Adisyon_getir(secilen_id, lb_adisyon);
                //Satarı arası renkleri değiştiriyoruz.
                foreach (ListViewItem item in lb_adisyon.Items)
                {
                    item.BackColor = item.Index % 2 == 0 ? Color.White : Color.WhiteSmoke;
                }

                geneltutar();
                
            }
            }

        private void bfb_hesabikapat_Click(object sender, EventArgs e)
        {


            hesap_ode hesap = new hesap_ode(geneltutar(),secilen_id);
            hesap.ShowDialog();

            if (lb_toplam.Text != "0 ₺" )
            { 
                if(cGenel.hesap_odendi == true)
                {
                    DateTime tarih = DateTime.Now;
                   
                    veritabani.Son_islem_ekle("Masa " + secilen_id + " kapatıldı", tarih.ToString("yyyy/MM/dd H:mm"), p_id);
                    // Hesap ödendiği için MasaButonlari sayfasına geri dönüyoruz.
                    icerik.Controls.Clear();//formun içini temizliyoruz..
                    masa_butonlari masalar = new masa_butonlari(icerik);
                    masalar.TopLevel = false;
                    icerik.Controls.Add(masalar);
                    masalar.Dock = DockStyle.Fill;
                    masalar.Show();

                }
                else
                {
                    alarm.Show("Masa - " +secilen_id+"  kapatma işlemi iptal edildi.", alarm.Alarmtur.hata);
                }
            }
            else
                alarm.Show("Masada herhangi bir ürün yok.", alarm.Alarmtur.hata);


        }

        bool durum = true;
        private void bfb_oncekiadisyon_Click(object sender, EventArgs e)
        {
            if (durum)//Önceki adisyon
            {
                durum = false;
                veritabani.E_adisyon_getir(secilen_id, lb_adisyon);
                geneltutar();
            }
            else//Şimdiki adsiyon
            {
                durum = true;
                veritabani.Adisyon_getir(secilen_id, lb_adisyon);
                geneltutar();
            }
           
        }

        private void bfb_masatasi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pl_sagalt.Height.ToString());


            if (lb_toplam.Text != "0 ₺") { 
            masa_tasi masa = new masa_tasi(secilen_id);
            masa.ShowDialog();
            }
            else
                alarm.Show("Masada herhangi bir ürün yok.", alarm.Alarmtur.hata);

        }

        private void bfb_gerigit_Click(object sender, EventArgs e)
        {
          
            icerik.Controls.Clear();//formun içini temizliyoruz..
            masa_butonlari masalar = new masa_butonlari(icerik);
            masalar.TopLevel = false;
            icerik.Controls.Add(masalar);
            masalar.Dock = DockStyle.Fill;
            masalar.Show();

        }


        private void mad_adet_leave(object sender, EventArgs e)
        {

            string isim = "";

            BunifuMetroTextbox gelen = (sender as BunifuMetroTextbox);
            isim = gelen.Name;


            if (gelen.Text == "")
            {
                if (gelen.Name == "Masa İsmi")
                    btb_degistir.Text = "Ürün Adı";
            }
        }
        #region Masa İsmi ve Adet Kısmı PlaceHolder özelliği
        private void mad_adet_enter(object sender, EventArgs e)
        {
            string isim = "";

            BunifuMetroTextbox gelen = (sender as BunifuMetroTextbox);
            isim = gelen.Name;

            if (gelen.Text == "Masa İsmi")
            {
                gelen.Text = "";
            }
        }

        private void tb_adet_Leave(object sender, EventArgs e)
        {
            string isim = "";

            BunifuMaterialTextbox gelen = (sender as BunifuMaterialTextbox);
            isim = gelen.Name;


            if (gelen.Text == "")
            {
                if (gelen.Name == "Masa İsmi")
                    btb_degistir.Text = "Ürün Adı";
            }
        }

        private void tb_adet_Enter(object sender, EventArgs e)
        {
            string isim = "";

            BunifuMaterialTextbox gelen = (sender as BunifuMaterialTextbox);
            isim = gelen.Name;

            if (gelen.Text == "Masa İsmi" || gelen.Text == "Ürün Adeti Yazınız")
            {
                gelen.Text = "";
            }
        }





        #endregion

     
    }

}
  

