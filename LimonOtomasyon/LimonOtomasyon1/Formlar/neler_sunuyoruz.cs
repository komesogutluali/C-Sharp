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
    public partial class neler_sunuyoruz : Form
    {
        public neler_sunuyoruz()
        {
            InitializeComponent();
            guncelle();
        }
        private void guncelle()
        {
            lb_baslik.Text = "Her Şey Daha Düzenli";
            lb_metin.Text = "\n\nLimon Otomasyon programı işletmelerini ihtiyaçlarını göz önünde bulundurarak yeniden tasarlandı. " +
                "Dokunmatik desteği ve her ekranda kusursuz görüntüsü ile her şey daha düzenli ve daha kullanışlı.";
        }

    
    }
}
