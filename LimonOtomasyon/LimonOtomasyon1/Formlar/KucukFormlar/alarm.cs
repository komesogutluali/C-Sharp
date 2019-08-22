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
    public partial class alarm : Form
    {
        string adres =  Application.StartupPath;


        public alarm(string mesaj,Alarmtur tur)
        {
            InitializeComponent();

            //Açılış Sesi İçin
            System.Media.SoundPlayer oynat = new System.Media.SoundPlayer();


            lb_metin.Text = mesaj;
            switch (tur){
                case Alarmtur.basarili:
                    this.BackColor = Color.OliveDrab;
                    icon.Image = icon_list.Images[0];
                    string path = adres + "\\basarili.wav";
                    oynat.SoundLocation = path;
                    oynat.Play();
                    break;
                case Alarmtur.hata:
                    this.BackColor = Color.Firebrick;
                    icon.Image = icon_list.Images[1];
                    path = adres + "\\hata.wav";
                    oynat.SoundLocation = path;
                    oynat.Play();
                    break;
                case Alarmtur.dikkat:
                    this.BackColor = Color.Crimson;
                    icon.Image = icon_list.Images[2];
                    path = adres +"\\uyari.wav";
                    oynat.SoundLocation = path;
                    oynat.Play();
                    break;
                case Alarmtur.eposta:
                    this.BackColor = Color.RoyalBlue;
                    icon.Image = icon_list.Images[3];
                    path = adres +"\\eposta.wav";
                    oynat.SoundLocation = path;
                    oynat.Play();
                    break;

            }

        }
        /// <summary>
        /// Alarm uyarı mesajları
        /// </summary>
        /// <param name="mesaj"></param>
        /// <param name="tur"></param>

        public static void Show(string mesaj, Alarmtur tur)
        {
            new alarm(mesaj, tur).Show();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            frm_cikis.Start();
        }

        public enum Alarmtur
        {
            basarili,hata,dikkat,eposta
        }
        private void alarm_Load(object sender, EventArgs e)
        {
            //Pencere Yüklenirken Sol Üst Köşede Başlaması İçin Aşağıdaki Kodları Yazıyoruz.
            this.Top = 15;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 15;
        }
        // 5 Saniye Sonra Form Kapanması İçin Timer Kullanıyoruz.
        private void frm_kapat_Tick(object sender, EventArgs e)
        {
            frm_cikis.Start();
        }

        int mesafe = 0;

        private void frm_ac_Tick(object sender, EventArgs e)
        {
            if(this.Top < 15)
            {
                this.Top += mesafe;
                mesafe += 1;
            }
            else
            {
                frm_ac.Stop();
            }


        }

        private void frm_cikis_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity-=0.3;
            }
            else
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
