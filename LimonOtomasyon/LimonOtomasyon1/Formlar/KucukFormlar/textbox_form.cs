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
    public partial class textbox_form : Form
    {
        Database veritabanı = new Database();

        public textbox_form()
        {
            InitializeComponent();
        }

        private void bfb_personelsil_Click(object sender, EventArgs e)
        {
            if (bmt_personelad.Text != "Personel Adı") {
                if (veritabanı.Personel_sil(bmt_personelad.Text))
                {
                    alarm.Show("Personel başarıyla silindi.", alarm.Alarmtur.basarili);
                    this.Hide();
                }
                else
                {
                    alarm.Show("Personel bulunamadı veya silinemedi.", alarm.Alarmtur.hata);
                }

            }
            else
                alarm.Show("Personel silinemedi.", alarm.Alarmtur.hata);
        }

        private void bmt_personelad_Leave(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMetroTextbox gelen = (sender as Bunifu.Framework.UI.BunifuMetroTextbox);
            string isim = gelen.Name;

            if (gelen.Text == "")
            {
                if (gelen.Name == "bmt_adi")
                    bmt_personelad.Text = "Personel Adı";
            }

        }

        private void bmt_personelad_Enter(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMetroTextbox gelen = (sender as Bunifu.Framework.UI.BunifuMetroTextbox);
            string isim = gelen.Name;

            if (gelen.Name == "Personel Adı")
                gelen.Name = "";
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
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
