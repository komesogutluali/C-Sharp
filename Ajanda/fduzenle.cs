using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ajanda
{
    public partial class fduzenle : Form
    {
        TextBox[] dizi = new TextBox[3]; 
        public fduzenle(TextBox[] _dizi)
        {
            InitializeComponent();
            btrhkaydet.Visible = false;
            dateTimePicker1.Visible = false;
            dizi = _dizi;
            tad.Text = dizi[0].Text;
            tsoy.Text = dizi[1].Text;
            label4.Text = dizi[2].Text;
            
        }
        private bool hata(TextBox t)
        {
            char[] sayilar = { '0', '1', '2', '3', '4', '5', '7', '8', '9' };
            bool hatam = true;
            Boolean k = false;
            for (int i = 0; i < t.Text.Length; i++)
            {
                for (int j = 0; j < sayilar.Length; j++)
                {
                    if (t.Text[i] == sayilar[j])
                    {
                        k = true;
                        hatam = false;
                        break;
                    }
                }
                if (k)
                    break;
            }
            return hatam;
        }
        private void bekle_Click(object sender, EventArgs e)
        {
            if (tad.Text.Length > 0&&tsoy.Text.Length>0&&hata(tad)&&hata(tsoy))
            {  
                dizi[0] = tad;
                dizi[1] = tsoy;
                this.Close();
            }
            else
                MessageBox.Show("İsim yada Soy isimde Rakam kullanılmaz");

        }

        private void btarih_Click(object sender, EventArgs e)
        {
            
            btrhkaydet.Visible=true;
            dateTimePicker1.Visible = true;
        }

        private void btrhkaydet_Click(object sender, EventArgs e)
        {
            TextBox t = new TextBox();
            t.Text = dateTimePicker1.Value.Year.ToString() + "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Month.ToString();
            dizi[2] = t;
        }

       
    }
}
