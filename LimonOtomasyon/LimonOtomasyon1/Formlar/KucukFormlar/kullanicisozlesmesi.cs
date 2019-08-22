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
    public partial class kullanicisozlesmesi : Form
    {
        public kullanicisozlesmesi()
        {
            InitializeComponent();
            tb_kullanicisozlemesi.Text = "Bu program Hasan Ekşi (151123035) ve Yavuz İncedal (151123062) tarafından " +
                " Görsel Destekli Veri Tabanı dersi için geliştirilmiştir. Veri Tabanı olarak SQL Lite kullanılmış olup " +
                " .net Framework 4.5.1 ve üstü ile çalışmaktadır. \n \n Program 3 farklı çözünürlükte sorunsuz çalışmaktadır bunlar ;" +
                "1920 x 1080 - 1366 x 768 ve 1536 x 864 'tür. Diğer çözünürlüklerde ise program normal akışında kullanılabilirken ufak" +
                " kaymalar olabilir.";

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
