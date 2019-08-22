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
    public partial class ayarlar : Form
    {
        Database veritabanı = new Database();

        public ayarlar()
        {
            InitializeComponent();

        }

        private void bfb_kaydet_Click(object sender, EventArgs e)
        {
            if(bmt_masasayisi.Text != "Masa Sayısı" )
            {
                int masa_sayisi = 0;
                bool k1 = Int32.TryParse(bmt_masasayisi.Text, out masa_sayisi);
                if (k1) { 
                    if (veritabanı.masa_tablo_olustur() && veritabanı.masa_olustur(masa_sayisi))
                        alarm.Show(masa_sayisi.ToString() + " tane masa oluşturuldu.", alarm.Alarmtur.basarili);    
                    else
                        alarm.Show("Masalar oluşturulamadı.", alarm.Alarmtur.hata);

                }
                else
                    alarm.Show("Masa sayısı rakamlardan oluşmalıdır.",alarm.Alarmtur.dikkat);
            }



        }

        private void bmt_masasayisi_Leave(object sender, EventArgs e)
        {
            string isim = "";

            Bunifu.Framework.UI.BunifuMetroTextbox gelen = (sender as Bunifu.Framework.UI.BunifuMetroTextbox);
            isim = gelen.Name;

            if (gelen.Text == "")
            {
                if (gelen.Name == "bmt_sifre")
                {
                    bmt_masasayisi.Text = "Masa Sayısı";
                }
            }
        }

        private void bmt_masasayisi_Enter(object sender, EventArgs e)
        {

            Bunifu.Framework.UI.BunifuMetroTextbox gelen = (sender as Bunifu.Framework.UI.BunifuMetroTextbox);
            string isim = gelen.Name;

            if (gelen.Text == "Masa Sayısı")
            {
                gelen.Text = "";
            }
        }
       

    }
}
