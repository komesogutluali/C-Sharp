using LimonOtomasyon.Sınıflar;
using LimonOtomasyon1.Formlar.KucukFormlar;
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

namespace LimonOtomasyon1.Formlar
{
    public partial class hesapdefteri : Form
    {
        Database veritabanı = new Database();
        public hesapdefteri()
        {
            InitializeComponent();
            //Harcama Türünü seçebilmek için ekleme yapıyoruz.
            cb_harcamaturu.Items.Add("Gelir");
            cb_harcamaturu.Items.Add("Gider");
            cb_harcamaturu.Items.Add("Borç");
            //Çözünürlüğe göre tasarım ayarlarını yapmak için fonksiyonu çağırıyoruz.
            response();

            //ListView Dolduruyoruz.
            //veritabanı.kasa_getir(lv_kasa);
            kasa_toplam();

           
        }

        public void response()
        {
            lv_kasa.Columns[0].Width = (lv_kasa.Width / 6) + 10;
            lv_kasa.Columns[1].Width = (lv_kasa.Width / 6) - 1;
            lv_kasa.Columns[2].Width = (lv_kasa.Width / 6) - 1;
            lv_kasa.Columns[2].Width = (lv_kasa.Width / 6) - 1;
            lv_kasa.Columns[3].Width = (lv_kasa.Width / 6) - 1;
            lv_kasa.Columns[4].Width = (lv_kasa.Width / 6) - 1;
            lv_kasa.Columns[5].Width = 0; // ID en sonra yer aldığı için genişliğini 0 yaptık.



        }

        // Hesap Defteri form çözünürlüğü değişince yapılacak işlemleri burada belirtiyoruz.
        private void hesapdefteri_SizeChanged(object sender, EventArgs e)
        {
            response();
        }

      
        public void kasa_toplam()
        {
            lb_tutar.Text = "Hazırlanmadı.";
        }
   
        
        private void lv_kasa_Click(object sender, EventArgs e)
        {
            //durum = true;
            //if (lv_kasa.Items.Count > 0)
            //    durum = false;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lv_kasa.SelectedIndices.Count> 0)
            {
                int secilen = lv_kasa.SelectedItems[0].Index;
                int k_no = Convert.ToInt32(lv_kasa.Items[secilen].SubItems[4].Text);
                veritabanı.Kasa_Sil(k_no);
                kasa_toplam();
              
            }
        }
        #region TextBox'lar için PlaceHolder özelliğini ayarladık.
        private void tb_gelirgider_Enter(object sender, EventArgs e)
        {
            string isim = "";

            TextBox gelen = (sender as TextBox);
            isim = gelen.Name;

            if (gelen.Text == "Açıklama" || gelen.Text == "Tutar" || gelen.Text == "Kategori Adı")
            {
                gelen.Text = "";
            }
        }


        private void tb_tutar_Leave(object sender, EventArgs e)
        {
            string isim = "";

            TextBox gelen = (sender as TextBox);
            isim = gelen.Name;


            if (gelen.Text == "")
            {
                if (gelen.Name == "tb_gelirgider")
                    tb_aciklama.Text = "Açıklama";
                else if (gelen.Name == "tb_tutar")
                    tb_tutar.Text = "Tutar";
                else if (gelen.Name == "tb_kategoriekle")
                    tb_kategoriekle.Text = "Kategori Adı";
              

            }
        }

        #endregion

        private void btn_urunekle_Click(object sender, EventArgs e)
        {
            double harcama_tutar;
            bool cevir = Double.TryParse(tb_tutar.Text, out harcama_tutar);

            //DateTime tarih = dt_tarih.Value;
            string tarih = dt_tarih.Value.ToString("yyyy-MM-dd H:mm:ss");
            DateTime simdiki_tarih = DateTime.Now;

            if (cb_harcamaturu.SelectedIndex != 2)
                tarih = null;
            //Son Kısımda yer alan cb_harcamatur.SelecetedText veritabanına eklenmiyor.Sadece uyarı verebilmek adına kullanılıyor.

            


        }

        private void cb_harcamaturu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_harcamaturu.SelectedIndex == 2)
            {
                dt_tarih.Enabled = true;
                lb_aciklama.Text = "Lütfen borcunuzun ödeneceği tarihi belirtiniz.";
            }
            else { 
                dt_tarih.Enabled = false;
                lb_aciklama.Text = "Sadece borç kısmı için ödeme tarihi belirleyebilirsiniz.";
            }
        }

        private void btn_kategoriekle_Click(object sender, EventArgs e)
        {
            if(pl_kategoriekle.Visible == true)
            {
                pl_kategoriekle.Visible = false;
            }
            else
            {
                pl_kategoriekle.Visible = true;
                pl_kategoriekle.Width = pl_main.Width / 3 + 75;
            }


        }
    }
}
