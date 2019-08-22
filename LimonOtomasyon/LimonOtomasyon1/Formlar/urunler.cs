using Bunifu.Framework.UI;
using LimonOtomasyon1.Formlar.KucukFormlar;
using LimonOtomasyon1.Sınıflar;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace LimonOtomasyon1.Formlar
{
    public partial class urunler : Form
    {
        ComboBox bdd_kategori_id = new ComboBox();
        bool secildi_mi = false;
        Database veritabani = new Database();
        ComboBox urun_id = new ComboBox();
        ComboBox kategori_id = new ComboBox();
        public urunler()
        {
            InitializeComponent();

            veritabani.U_ComboDoldur(bdd_kategori_id, bdd_kategori);
            veritabani.U_ListDoldur(lv_urunler, urun_id);
            //Ürünler ve Kategoriler Sayaclarını Ayarlıyoruz.
            int[] sayisi = veritabani.K_Usayisibul();
            lbl_kategoriadet.Text = sayisi[0] + "";
            lbl_urunadet.Text = sayisi[1] + "";


            //lv_urunler.Items[1].Checked = true;
         


            // lv_urunler itemlerinin arkaplan renklerini ayarlıyoruz.
            foreach (ListViewItem item in lv_urunler.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.White : Color.LightGray;
            }
            foreach (ListViewItem item in lv_kategoriler.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.White : Color.WhiteSmoke;
            }

        }


        /*Ürünler Formunun Çözünürlüğü Değiştiğinde Bu Fonksiyon Çalışacak.*/
        private void urunler_SizeChanged(object sender, EventArgs e)
        {
            response(cGenel.genislik, cGenel.yukseklik, cGenel.menu_acikmi);

        }

        // Farklı Çözünürlüklere Göre Hareket Etmek İçin Bu Fonkisyonu Kullanıyoruz.
        private void response(int gen_masa, int yuk_masa, bool menu)
        {



            #region 1920x1080 (Full HD) Ekranlar İçin Gerekli Ayarlamalar
            if (gen_masa == 1200 && yuk_masa == 650)
            {
                // Standart Pencere Boyutunda

                // Ürün ve Kategori Sayısının Bulunduğu Alanın Padding Ayarını Yapıyoruz.
                pl_header.Padding = new Padding(200, 5, 200, 5);

                // Footerda Yer Alan Butonları Ekran Ortalıyoruz.
                pl_footer.Height = 99; pl_footer.Width = 862;
                // pl_footer.Padding = new Padding((pl_footer.ClientSize.Width - flp_footerbutonlar.ClientSize.Width) / 2, 5, 65, 5);

                /*Listelerin yer alacağı orta alanda ki Paneli Ortalıyoruz.*/
                pl_main.Padding = new Padding((pl_main.ClientSize.Width - pl_mainorta.ClientSize.Width) / 2, 5, (pl_main.ClientSize.Width - pl_mainorta.ClientSize.Width) / 2, 5);



                // Ürünler İçin Eklediğimiz ListView Sütünlarının Boylarını Eşitliyoruz.
                lv_urunler.Columns[0].Width = (lv_urunler.Width / 12) * 4;
                lv_urunler.Columns[1].Width = (lv_urunler.Width / 12) * 2;
                lv_urunler.Columns[2].Width = (lv_urunler.Width / 12) * 2;
                lv_urunler.Columns[3].Width = (lv_urunler.Width / 12) * 2;
                lv_urunler.Columns[4].Width = (lv_urunler.Width / 12) * 2;

                //Kategori Ekleme Butonlarının Paddin Değerlerini Ayarlıyoruz.
               // Kategori Ekleme ListView Sütünlarının Boylarını Eşitliyoruz.
                lv_kategoriler.Columns[0].Width = (lv_kategoriler.Width / 2) * 1;
                lv_kategoriler.Columns[1].Width = (lv_kategoriler.Width / 2) * 1;

                // pl_footer Boyutunu Ayarlıyoruz.
                pl_footer.Height = 99;
                //Footerda Yer Alan Buton penceresinin genişliğini ayarlıyoruz.
                tlp_butonlar.Width = 750;

            }
            else if (gen_masa == 1920 && yuk_masa == 1080)
            {
                // Son İşlemler veya Menü Açık Olduğunda (Tam Ekran)

                // Ürün ve Kategori Sayısının Bulunduğu Alanın Padding Ayarını Yapıyoruz.
                pl_header.Padding = new Padding(400, 5, 400, 5);



                // Footerda Yer Alan Butonları Ekran Ortalıyoruz.
                pl_footer.Height = 95;
                pl_footer.Padding = new Padding( 220, 0, 100, 5);

                /*Listelerin yer alacağı orta alanda ki Paneli Ortalıyoruz.*/
                pl_main.Padding = new Padding((pl_main.ClientSize.Width - pl_mainorta.ClientSize.Width) / 2, 5, (pl_main.ClientSize.Width - pl_mainorta.ClientSize.Width) / 2, 5);

                // Ürünler İçin Eklediğimiz ListView Sütünlarının Boylarını Eşitliyoruz.
                lv_urunler.Columns[0].Width = (lv_urunler.Width / 12) * 4 + 3;
                lv_urunler.Columns[1].Width = (lv_urunler.Width / 12) * 2;
                lv_urunler.Columns[2].Width = (lv_urunler.Width / 12) * 2;
                lv_urunler.Columns[3].Width = (lv_urunler.Width / 12) * 2;
                lv_urunler.Columns[4].Width = (lv_urunler.Width / 12) * 2;

                //Kategori Ekleme Butonlarının Paddin Değerlerini Ayarlıyoruz.
                // Kategori Ekleme ListView Sütünlarının Boylarını Eşitliyoruz.
                lv_kategoriler.Columns[0].Width = (lv_kategoriler.Width / 2) * 1;
                lv_kategoriler.Columns[1].Width = (lv_kategoriler.Width / 2) * 1;

                //Footerda Yer Alan Buton penceresinin genişliğini ayarlıyoruz.
                tlp_butonlar.Width = (pl_footer.Width ) - 100;


                #endregion
            }
            else
            {
                pl_header.Padding = new Padding(100, 5, 100, 5);

                //Footerda Yer Alan Buton penceresinin genişliğini ayarlıyoruz.
                tlp_butonlar.Width = (pl_footer.Width) - 100;
            }

            //Footer kısımında yer alan butonları panelde ortalıyoruz.
            tlp_butonlar.Location = new Point(
            pl_footer.ClientSize.Width / 2 - tlp_butonlar.Size.Width / 2,
            pl_footer.ClientSize.Height / 2 - tlp_butonlar.Size.Height / 2);
            tlp_butonlar.Anchor = AnchorStyles.None;
        }

        #region Ürün ekleme TextBox'ları İçin PlaceHolder ve Boyut Değiştirme özelliği oluşturduk.
        private void urunekle_tb_Leave(object sender, EventArgs e)
        {
            /* Bu Fonksiyonda Hangi CheckBox'ta hareket olursa olsun PlaceHolder için içini kontrol ediyoruz. 
               Eğer boş ise ilk haline geri getiriyoruz.*/

            string isim = "";

            BunifuMetroTextbox gelen = (sender as BunifuMetroTextbox);
            isim = gelen.Name;


            if (gelen.Text == "")
            {
                if (gelen.Name == "btb_urunadi")
                    btb_urunadi.Text = "Ürün Adı";
                else if (gelen.Name == "btb_gelisfiyati")
                    btb_gelisfiyati.Text = "Geliş Fiyatı";
                else if (gelen.Name == "bfb_kategoriadi")
                    btb_kategoriadi.Text = "Kategori Adı";
                else
                    btb_birimfiyati.Text = "Birim Fiyatı";

            }
        }

        private void urunekle_tb_Enter(object sender, EventArgs e)
        {

            string isim = "";

            BunifuMetroTextbox gelen = (sender as BunifuMetroTextbox);
            isim = gelen.Name;

            if (gelen.Text == "Ürün Adı" || gelen.Text == "Geliş Fiyatı" || gelen.Text == "Birim Fiyatı" || 
                gelen.Text == "Kategori Adı" || gelen.Text == "Adet" || gelen.Text =="Kategori Adı")
            {
                gelen.Text = "";
            }

        }

        #endregion

        private void btn_kategoriekle_Click(object sender, EventArgs e)
        {

            if (pl_kategoriekle.Visible == true) {
                pl_kategoriekle.Visible = false;
                btn_kategoriekle.Text = "Kategori Ekle";
            }
            else { 
                pl_kategoriekle.Visible = true;
                btn_kategoriekle.Text = "Kapat";
            }
            veritabani.K_ListDoldur(lv_kategoriler, kategori_id);
        }
        #region Veri Tabanına Yeni Ürün Eklemek için gerekli kodlar.
        private void bfb_urunekle_Click(object sender, EventArgs e)
        { double gfiyat = 0, bfiyat = 0;
            int k_kid = 0;
            /*Ürün Ekleme kısmında ki "," ve "." karışıklığını çözmek için
            String fonksiyonuna ait yer değiştirme -replace- özelliğini kullandık. */
            btb_gelisfiyati.Text= btb_gelisfiyati.Text.Replace('.', ',');
            btb_birimfiyati.Text = btb_birimfiyati.Text.Replace('.', ',');

            bool k1 = double.TryParse(btb_birimfiyati.Text, out bfiyat);
            bool k2 = double.TryParse(btb_gelisfiyati.Text, out gfiyat);
            int k_secilen = bdd_kategori.SelectedIndex;
            int[] a = new int[10];
           
          
            if (btb_urunadi.Text.Length > 0 &&btb_urunadi.Text!= "Ürün Adı" && k1 && k2 && k_secilen > -1&&veritabani.U_kontrol(btb_urunadi.Text.ToString()))
            {
               
                    k_kid = (int)bdd_kategori_id.Items[k_secilen];
                    veritabani.U_Ekle(btb_urunadi.Text, gfiyat, bfiyat, k_kid, null);
                    veritabani.U_ListDoldur(lv_urunler, urun_id);
                
               
                    //k_kid = (int)bdd_kategori_id.Items[k_secilen];
                    //veritabani.U_Ekle(btb_urunadi.Text, gfiyat, bfiyat, k_kid, u_adet);
                    //veritabani.U_ListDoldur(lv_urunler, urun_id);
             
                int[] sayisi = veritabani.K_Usayisibul();
                lbl_kategoriadet.Text = sayisi[0] + "";
                lbl_urunadet.Text = sayisi[1] + "";
                btb_urunadi.Text = "Ürün Adı";
                btb_gelisfiyati.Text = "Geliş Fiyatı";
                btb_birimfiyati.Text = "Birim Fiyatı";
                foreach (ListViewItem item in lv_urunler.Items)
                {
                    item.BackColor = item.Index % 2 == 0 ? Color.White : Color.WhiteSmoke;
                }
            }
            else
                MessageBox.Show("Lütfen Girdiğiniz Değerleri Kontrol ediniz veya Kategori Seçiniz.");
          
        }
        #endregion

        #region Ürün Adı Değiştir - Geliş Fiyatı Değiştir - Birim Fiyatı Değiştir - Kategori Değiştir
        private void bfb_01_Click(object sender, EventArgs e)
        {
            int buton_no;
            string isim = "";
            int secilen1 = lv_urunler.SelectedIndices.Count;
           
            BunifuFlatButton gelen = (sender as BunifuFlatButton);
            isim = gelen.Name;
            buton_no = Convert.ToInt16(isim.Substring(4, 2));


            //Ürün Adı Değiştirme butonunun Click Eventi
            if (secildi_mi)
            {
                if (buton_no == 1)
                {
                    // Ürün Adı default Metni Değiştirilmez İse Diye Koşul Koşuyoruz.
                    if (btb_urunadi.Text != "Ürün Adı" && btb_urunadi.Text.Length > 0)
                    {
                        int secilen = lv_urunler.SelectedItems[0].Index;

                        int u_id = Convert.ToInt32(urun_id.Items[secilen]);
                        veritabani.U_adgun(btb_urunadi.Text, u_id);
                        veritabani.U_ListDoldur(lv_urunler, urun_id);
                        secildi_mi = false;
                        btb_urunadi.Text = "Ürün Adı";
                    }
                    else
                        MessageBox.Show("Lütfen Ürün Adını Giriniz...");
                }
                //Geliş Fiyatı Değiştirme butonunun Click Eventi
                else if (buton_no == 2)
                {
                    if (secildi_mi)
                    {
                        // Ürün Adı default Metni Değiştirilmez İse Diye Koşul Koşuyoruz.
                        if (btb_gelisfiyati.Text != "Geliş Fiyatı" && btb_gelisfiyati.Text.Length > 0)
                        {
                            int secilen = lv_urunler.SelectedItems[0].Index;

                            int u_id = Convert.ToInt32(urun_id.Items[secilen]);
                            veritabani.U_gelisfiyat_gun(btb_gelisfiyati.Text, u_id);
                            veritabani.U_ListDoldur(lv_urunler, urun_id);

                            secildi_mi = false;
                            btb_gelisfiyati.Text = "Geliş Fiyatı";
                        }
                        else
                            MessageBox.Show("Lütfen Geliş Fiyatını Belirtiniz...");

                    }
                }
                //Birim Fiyatı Değiştirme butonunun Click Eventi
                else if (buton_no == 3)
                {
                    if (secildi_mi)
                    {
                        // Ürün Adı default Metni Değiştirilmez İse Diye Koşul Koşuyoruz.
                        if (btb_birimfiyati.Text != "Birim Fiyatı" && btb_birimfiyati.Text.Length > 0)
                        {
                            int secilen = lv_urunler.SelectedItems[0].Index;

                            int u_id = Convert.ToInt32(urun_id.Items[secilen]);
                            veritabani.U_birimfiyat_gun(btb_birimfiyati.Text, u_id);
                            veritabani.U_ListDoldur(lv_urunler, urun_id);

                            secildi_mi = false;
                            btb_gelisfiyati.Text = "Birim Fiyatı";
                        }
                        else
                            MessageBox.Show("Lütfen Geliş Fiyatını Belirtiniz...");
                    }
                }
                //Kategori Değiştirme butonunun Click Eventi
                else if (buton_no == 4)
                {
                    if (secildi_mi)
                    {
                        // Ürün Adı default Metni Değiştirilmez İse Diye Koşul Koşuyoruz.
                        int secilen_k = bdd_kategori.SelectedIndex;
                        if (secilen_k > -1 )
                        {
                            int secilen = lv_urunler.SelectedItems[0].Index;
                            int u_id = Convert.ToInt32(urun_id.Items[secilen]);
                            int ka_id = Convert.ToInt32(bdd_kategori_id.Items[secilen_k]);
                            veritabani.U_kategori_gun(ka_id, u_id);
                            veritabani.U_ListDoldur(lv_urunler, urun_id);

                            secildi_mi = false;

                        }
                        else
                            MessageBox.Show("Lütfen Geliş Fiyatını Belirtiniz...");
                    }
                }
                //Ürün Silme Butonu butonunun Click Eventi
                else if (buton_no == 5)
                {
                    if (secildi_mi)
                    {
                        int secilen = lv_urunler.SelectedItems[0].Index;
                        if (secilen > -1)
                        {
                            int u_id = Convert.ToInt32(urun_id.Items[secilen]);
                            veritabani.U_Sil(u_id);
                            veritabani.U_ListDoldur(lv_urunler, urun_id);
                            int[] sayisi = veritabani.K_Usayisibul();
                            lbl_kategoriadet.Text = sayisi[0] + "";
                            lbl_urunadet.Text = sayisi[1] + "";
                            secildi_mi = false;
                            foreach (ListViewItem item in lv_urunler.Items)
                            {
                                item.BackColor = item.Index % 2 == 0 ? Color.White : Color.WhiteSmoke;
                            }
                        }
                        else
                            MessageBox.Show("Lütfen silmek için ürün seçiniz");
                    }


                }
              
            }
            
            else
            {
                MessageBox.Show("Lütfen işlem yapmak için herhangi bir ürün seçiniz.");
            }
            #endregion



        }

        private void lv_urunler_Click(object sender, EventArgs e)
        {

            secildi_mi = true;
            //lb_aciklama.Text = lv_urunler.SelectedItems[0].SubItems[0].Text + " Seçildi";
            //lv_urunler.SelectedItems[0].BackColor = System.Drawing.Color.DarkOrange;

        }

        //Kategori ekle 
        private void bfb_kategoriekle_Click(object sender, EventArgs e)
        {
            if (!(btb_kategoriadi.Text.Equals("Kategori Adı")) &&btb_kategoriadi.Text.Length > 0&&veritabani.K_kontrol(btb_kategoriadi.Text))
            {
                veritabani.K_Ekle(btb_kategoriadi.Text);
                veritabani.K_ListDoldur(lv_kategoriler, kategori_id);
                veritabani.U_ComboDoldur(bdd_kategori_id, bdd_kategori);
                btb_kategoriadi.Text = "Kategori Adı";
                int[] sayisi = veritabani.K_Usayisibul();
                lbl_kategoriadet.Text = sayisi[0] + "";
                lbl_urunadet.Text = sayisi[1] + "";
            }
            else
                MessageBox.Show("Aynı Kategori Eklenemez Lütfen Kategori İsmini Doğru Giriniz");
        }
        //Kategori Değistir
        private void bfb_kat_isimdegistir_Click(object sender, EventArgs e)
        {

            if (secildi_mi&& btb_kategoriadi.Text.Length>0){

                int secilen = lv_kategoriler.SelectedItems[0].Index;
              
                veritabani.K_Gun(Convert.ToInt32(kategori_id.Items[secilen]),btb_kategoriadi.Text);
                veritabani.K_ListDoldur(lv_kategoriler, kategori_id);
                veritabani.U_ComboDoldur(bdd_kategori_id, bdd_kategori);
                btb_kategoriadi.Text = "Kategori Adı";
                veritabani.U_ListDoldur(lv_urunler, urun_id);
                secildi_mi = false;
            }
            else
                MessageBox.Show("Lütfen Kategori Seçiniz Ve Kategori İsim Alanını Boş Bırakmayınız");
        }
        //Kategori Sil
        private void bfb_kategorisil_Click(object sender, EventArgs e)
        {
            if (secildi_mi)
            {
                int secilen = lv_kategoriler.SelectedItems[0].Index;
                veritabani.K_Sil(Convert.ToInt32(kategori_id.Items[secilen]));
                veritabani.K_ListDoldur(lv_kategoriler, kategori_id);
                veritabani.U_ComboDoldur(bdd_kategori_id, bdd_kategori);
                veritabani.U_ListDoldur(lv_urunler, urun_id);
                int[] sayisi = veritabani.K_Usayisibul();
                lbl_kategoriadet.Text = sayisi[0] + "";
                lbl_urunadet.Text = sayisi[1] + "";
                secildi_mi = false;
                foreach (ListViewItem item in lv_kategoriler.Items)
                {
                    item.BackColor = item.Index % 2 == 0 ? Color.White : Color.WhiteSmoke;
                }
            }
            else
                MessageBox.Show("Lütfen Kategori Seçiniz");
        }

      
        private void lv_kategoriler_MouseClick(object sender, MouseEventArgs e)
        {
            secildi_mi =true;
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

        
        private void bfb_hizlisifirla_Click(object sender, EventArgs e)
        {
            veritabani.hizli_sifirla();
        }
        //Hizli menu için
        private void lv_urunler_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
               //Hizli Menu Sayisi
            if (veritabani.hizlimsayisi_bul() < 15)
            {
                int u_no = Convert.ToInt32(urun_id.Items[e.Index]);
                veritabani.hizli_m(u_no);
            }
        }
      
    }
}
