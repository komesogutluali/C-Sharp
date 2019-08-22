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
    public partial class UyarıForm : Form  
    {
        public UyarıForm()
        {
            InitializeComponent();
            lb_metin.Text = cGenel.aciklama;
            bfb_kapat.Text = cGenel.btn_metin;


        }


        #region Forma Gölge Efekti Vermek İçin Kullanıyoruz.
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
        #endregion

        private void bfb_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
