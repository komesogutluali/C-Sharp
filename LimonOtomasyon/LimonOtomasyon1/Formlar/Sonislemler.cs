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
    public partial class Sonislemler : Form
    {

        Database veritabani = new Database();
        public Sonislemler()
        {
            InitializeComponent();
            veritabani.Sonislem_getir(lv_sonislemler);
            //Son işlemlerin satır renklerini belirliyoruz.
            foreach (ListViewItem item in lv_sonislemler.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.White : Color.MistyRose;
            }
        }

        private void Sonislemler_SizeChanged(object sender, EventArgs e)
        {
            response();

        }
        private void response()
        {
            lv_sonislemler.Columns[0].Width = lv_sonislemler.Width / 3-5;
            lv_sonislemler.Columns[1].Width = lv_sonislemler.Width / 3-6;
            lv_sonislemler.Columns[2].Width = lv_sonislemler.Width / 3-6;
        }
        private void yenile_Tick(object sender, EventArgs e)
        {
            response();
            yenile.Enabled = false;
        }

        private void bfb_sonislemlerisil_Click(object sender, EventArgs e)
        {
            personel_giris giris = new personel_giris("yonetici", false);
            giris.ShowDialog();

            if (cGenel.personel_girisi == true)
            {
                DateTime tarih = DateTime.Now;
                veritabani.sonislemeri_sil();
                veritabani.Son_islem_ekle("Son işlemler silindi.",tarih.ToString("yyyy/MM/d H:mm"), cGenel.personel_no);
                veritabani.Sonislem_getir(lv_sonislemler);

            }
            else
                alarm.Show("Giriş başarısız, bu işleme yapmak için yetkiniz yok.", alarm.Alarmtur.hata);
        }
    }
}
