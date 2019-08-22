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
    public partial class Uyarı : Form
    {
        public Uyarı()
        {
            InitializeComponent();
        }

        private void Uyarı_Load(object sender, EventArgs e)
        {
            this.Width = 550;
            this.Height = 200;


            lb_aciklama.Text = cGenel.aciklama;
            tb_mesaj.Text = cGenel.tb_metin;
            btn_mesaj.Text = cGenel.btn_metin;
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
