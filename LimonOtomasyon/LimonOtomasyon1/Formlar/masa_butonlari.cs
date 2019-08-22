using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using LimonOtomasyon1.Sınıflar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.Framework.UI;
using System.Windows.Forms;
using System.Collections;
using LimonOtomasyon1.Formlar.KucukFormlar;

namespace LimonOtomasyon1.Formlar
{
    public partial class masa_butonlari : Form
    {
        public static int p_id;

        Database veritabani = new Database();
        ArrayList masasayisi = new ArrayList();
        ArrayList acik_masa = new ArrayList();

        ArrayList acik_masa_isim = new ArrayList();
        ArrayList acik_masa_id = new ArrayList();
        ComboBox masa = new ComboBox();
        ComboBox tutar = new ComboBox();


        int btn_sayi = 0;
        Panel icerik = new Panel();
      


        public masa_butonlari(Panel pl_icerik)
        {
            icerik = pl_icerik;
           InitializeComponent();
           veritabani.masa_sayisi(masasayisi);
           btn_sayi = masasayisi.Count;
           veritabani.Acik_Masa(acik_masa);
           veritabani.Acik_Masa_İsim(acik_masa_isim, acik_masa_id);
        }
        BunifuFlatButton[] masa_btn;
        private void masa_olustur()
        {
            masa_btn = new BunifuFlatButton[btn_sayi];
            flp_masabuttonlar.Controls.Clear();

            for (int i = 1; i <= btn_sayi; i++) {
                masa_btn[i-1] = new BunifuFlatButton();
                masa_btn[i-1].Name = "btn_" + masasayisi[i-1];


                masa_btn[i-1].Iconimage = new Bitmap(masa_resimleri.Images[0]); 
                masa_btn[i-1].TextAlign = ContentAlignment.MiddleCenter;
                masa_btn[i - 1].Size = new System.Drawing.Size(flp_masabuttonlar.Width / 5-15 , flp_masabuttonlar.Height / 6);
                masa_btn[i - 1].Text = "Masa - " + i.ToString();
                masa_btn[i - 1].Normalcolor = Color.OrangeRed;
                masa_btn[i - 1].OnHovercolor = Color.SeaGreen;
                masa_btn[i - 1].Activecolor = Color.Crimson;
                masa_btn[i - 1].ContextMenuStrip = this.cms_butonlar;
                masa_btn[i - 1].Click += masa_btn_Click;

                flp_masabuttonlar.Controls.Add(masa_btn[i - 1]);
          
            }
            
            acik_masa_bul();
            tutar_yaz();
        }
       
        private void acik_masa_bul()
        {
            veritabani.Acik_Masa(acik_masa);
            veritabani.Acik_Masa_İsim(acik_masa_isim,acik_masa_id);

            for (int i = 0; i < acik_masa.Count; i++)
            {
                string a_masa_id = acik_masa[i].ToString();

                //string masa_adi = acik_masa_isim[i].ToString();
                for (int j = 0; j < masa_btn.Length; j++)
                {

                    string[] masa_id = masa_btn[j].Name.Split('_');
                    if (masa_id[1].Equals(a_masa_id))
                    {
                        masa_btn[j].Normalcolor = Color.DarkBlue;
                        masa_btn[j].OnHovercolor = Color.Red;
                        masa_btn[j].IconVisible = false;
                        //masa_btn[j].Iconimage = new Bitmap(masa_resimleri.Images[1]);
                        break;
                    }
                }
            }
            for (int i = 0; i < acik_masa_id.Count; i++)
            {
                for (int j = 0; j < acik_masa.Count; j++)
                {
                    if (acik_masa_id[i].Equals(acik_masa[j]))
                    {
                        masa_btn[Convert.ToInt32(acik_masa_id[i]) - 1].Text = acik_masa_isim[i].ToString();
                        break;
                    }
                }
            }
           
        }

        public void tutar_yaz() 
        {
            veritabani.masa_Tutar(masa, tutar);
            for (int i = 0; i < masa.Items.Count; i++) 
            {
               
                for (int j = 0; j < masa_btn.Length; j++)
                {
                    string mno =( j + 1)+"";
                    if (masa.Items[i].Equals(mno))
                    {
                        masa_btn[j].Text += "   " + tutar.Items[i]+" TL";
                        break;
                    }
                
                }
            
            }
        
        
        }
        private void masa_butonlari_SizeChanged(object sender, EventArgs e)
        {
            response(cGenel.genislik, cGenel.yukseklik,cGenel.menu_acikmi);
        }

        private void response(int gen_masa,int yuk_masa,bool menu)
        {
            // Standart Pencere Boyutunda
            #region 1920x1080 (Full HD) Ekranlar İçin Gerekli Ayarlamalar
            if (gen_masa == 1200 && yuk_masa == 650)
            {
                //pl_header.Padding = new Padding((pl_header.ClientSize.Width - pl_bilgiler.ClientSize.Width) , (pl_header.ClientSize.Height - pl_bilgiler.ClientSize.Height) , (pl_header.ClientSize.Width - pl_bilgiler.ClientSize.Width), 5);
                //flp_butonlar.Padding = new Padding(73, 0, 13, 0);
                masa_olustur();
                //lb_aciklama.Text = "Standart Pencere Boyutu";

            }
            else if (gen_masa == 1920 && yuk_masa == 1080)
            {
                // Son İşlemler veya Menü Açık Olduğunda (Tam Ekran)

                pl_header.Padding = new Padding((pl_header.ClientSize.Width - pl_bilgiler.ClientSize.Width), (pl_header.ClientSize.Height - pl_bilgiler.ClientSize.Height)/2 , (pl_header.ClientSize.Width - pl_bilgiler.ClientSize.Width)/2, 5);
                //flp_butonlar.Padding = new Padding(100, 5, 10, 20);
                masa_olustur();
                //lb_aciklama.Text = "Son İşlemler ve Menü Açık Olduğunda";
            }
            else
            {
                masa_olustur();
            }
            #endregion
        }

        private void yenile_Tick(object sender, EventArgs e)
        {
            response(cGenel.genislik, cGenel.yukseklik, cGenel.menu_acikmi);
            yenile.Enabled = false;
        }
        void masa_btn_Click(object sender, EventArgs e)
        {
            BunifuFlatButton gelen = (BunifuFlatButton)sender;
            string[] id = gelen.Name.Split('_');// '_' göre metni parcalar
            int secilen_id = Convert.ToInt32(id[1]);


            personel_giris giris = new personel_giris("masa_butonlari",false);
            giris.ShowDialog();

            if(cGenel.personel_girisi == true) {
            this.Hide();
            icerik.Controls.Clear();//formun içini temizliyoruz..
            masa newForm = new masa(secilen_id,icerik);
            newForm.TopLevel = false;
            icerik.Controls.Add(newForm);
            newForm.Dock = DockStyle.Fill;
            newForm.Show();
            }
            else
            {
                alarm.Show("Giriş yapamadan bu sayfayı göremezsiniz.", alarm.Alarmtur.dikkat);
            }
        }

        // Sağ tıkla Masa tası
        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] id = cms_butonlar.SourceControl.Name.Split('_');// '_' göre metni parcalar
            int secilen_id = Convert.ToInt32(id[1]);
           
            masa_tasi masa = new masa_tasi(secilen_id);
            masa.ShowDialog();
            masa_olustur();
        }
        //Sağ tıkla Masa kapat
        private void seçToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            string[] id = cms_butonlar.SourceControl.Name.Split('_');// '_' göre metni parcalar
           int secilen_id = Convert.ToInt32(id[1]);

            DateTime tarih = DateTime.Now;

            personel_giris giris = new personel_giris("personel", false);
            giris.ShowDialog();

            if (cGenel.personel_girisi == true)
            {

                double tutar = veritabani.Toplam_tutar(secilen_id);
                hesap_ode frm = new hesap_ode(tutar, secilen_id);
                frm.ShowDialog();
                veritabani.Son_islem_ekle("Masa " + secilen_id + " kapatıldı.", tarih.ToString("yyyy-MM-dd H:mm"), p_id);
                masa_olustur();
            }

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
