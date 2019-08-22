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
    public partial class hesap_ode : Form
    {
        public static int p_id;
        Database veritabani = new Database();
        double tutar;
        int masa_no;
        String odeme_turu = "Nakit";
        public hesap_ode(Double tutarim,int masa)
        {
            InitializeComponent();
            tutar = tutarim;
            masa_no = masa;
        }

        private void hesap_ode_Load(object sender, EventArgs e)
        {
            lb_tutar.Text = "Toplam tutar: " + tutar.ToString() +" ₺";
            lb_tumtoplam.Text = lb_tutar.Text;
            lb_ucretustu.Text = "Masa Numarası : " + masa_no.ToString();

            pl_toplamgoster.Height = 5;
            pl_toplamgoster.Visible = false;

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void para_click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuFlatButton gelen = (Bunifu.Framework.UI.BunifuFlatButton)sender;
            string para_no = gelen.Name.Substring(5, 1);
            int id = Convert.ToInt32(para_no);

            switch (id)
            {
                case 1: cikar(10);
                    break;
                case 2:
                    cikar(20);
                    break;
                case 3:
                    cikar(50);
                    break;
                case 4:
                    cikar(100);
                    break;
                case 5:
                    cikar(200);
                    break;
                
            }

        }
        private void cikar(int para)
        {
            if (para - tutar > 0)
            {
                lb_ucretustu.Text ="Ödenmesi gereken ücret : " + (para - tutar).ToString() + " ₺";
            }
            else
            {
                lb_ucretustu.Text = (para - tutar).ToString() + " ₺ daha ücret alman gerekiyor.";
            }
        }

   
        private void bfb_hesabikapat_Click(object sender, EventArgs e)
        {
            hesap_kapat(odeme_turu);
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


        private void odem_turuile_hesap_kapat_Click(object sender, EventArgs e)
        {
            string isim = "";
            int buton_no;

            Bunifu.Framework.UI.BunifuFlatButton genel = (sender as Bunifu.Framework.UI.BunifuFlatButton);
            isim = genel.Name;
            buton_no = Convert.ToInt16(isim.Substring(9, 2));
            if (buton_no == 1)
            {
                odeme_turu = "Nakit";
                lb_odeme_tur_aciklama.Text = "Ödeme türü olarak NAKİT seçildi.";
            }
            else if(buton_no == 2)
            {
                odeme_turu = "Kredi Kartı";
                lb_odeme_tur_aciklama.Text = "Ödeme türü olarak KREDİ KARTI seçildi.";
            }
            else if(buton_no == 3)
            {
                odeme_turu = "Diğerleri";
                lb_odeme_tur_aciklama.Text = "Ödeme türü olarak DİĞERLERİ seçildi.";
            }
            else if(buton_no == 4) { //Hesap Kapat Butonu
            hesap_kapat(odeme_turu);
            }
            else
            {//Toplam Ürünleri Göster
                veritabani.adisyon_urun_birlestir(lv_adisyon,masa_no);

                lv_adisyon.Columns[0].Width = lv_adisyon.Width / 4 - 1;
                lv_adisyon.Columns[1].Width = lv_adisyon.Width / 4 - 1;
                lv_adisyon.Columns[2].Width = lv_adisyon.Width / 4 - 1;
                lv_adisyon.Columns[3].Width = lv_adisyon.Width / 4 - 1;

                foreach (ListViewItem item in lv_adisyon.Items)
                {
                    item.BackColor = item.Index % 2 == 0 ? Color.White : Color.LightBlue;
                }

                pl_toplamgoster.Visible = true;
                pl_toplamgoster.Height = this.Height;
            }

        }

        private void hesap_kapat(string odeme_turunuz)
        {
            veritabani.EskiA_Sil(masa_no);
            veritabani.EskiA_Ekle(masa_no);
            veritabani.Adisyon_Temizle(masa_no);
            cGenel.hesap_odendi = true;
            this.Close();
        }


        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Toplam Ürünler Panelini Gizlemek İçin Kullanıyoruz.
        private void bfb_toplamurun_kapat_Click(object sender, EventArgs e)
        {
            pl_toplamgoster.Visible = false;
            pl_toplamgoster.Height = 0;
        }
    }
}
