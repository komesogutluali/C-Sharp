using System;
using System.Windows.Forms;
using LimonOtomasyon1.Sınıflar;


namespace LimonOtomasyon1.Formlar.KucukFormlar
{
    public partial class masa_tasi : Form
    {

        Database veritabani = new Database();

        int masa_no;
        public masa_tasi(int masano)
        {
            masa_no = masano;    
            InitializeComponent();
            lb_aciklama.Text = masa_no.ToString() + " adlı masayı taşımak istediğiniz yeri lütfen aşağıdan seçiniz.";
            veritabani.Bos_Masa_Bul(bd_bosmasa);
        }
       
     

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void btn_masatasi_Click(object sender, EventArgs e)
        {
            int secilen = bd_bosmasa.SelectedIndex;
            if (secilen > -1)
            {
                DateTime tarih = DateTime.Now;

                int tasinacak = Convert.ToInt32(bd_bosmasa.Items[secilen]+"");
                veritabani.Masa_tasi(masa_no, tasinacak);
                
                veritabani.Son_islem_ekle("Masa " + masa_no +"--"+" Masa "+tasinacak+" taşındı.", tarih.ToString("yyyy-MM-dd H:mm:ss"),masa.p_id);
                this.Close();
            }
        }
    }
}
