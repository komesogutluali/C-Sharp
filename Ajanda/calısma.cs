using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ajanda
{
    public partial class calısma : Form
    {
        int num;
        string tar;
        public calısma(int _num,Label _isim,string _tarih)
        {
            InitializeComponent();
            tar = _tarih;
            tmesai.Text = "0";
            mesaipa.Text = "0 TL";
            cgunpa.Text = "0 TL";
            toppa.Text = "0 TL";
            num = _num;
            doldur();
            double toplam = topmesai();
            toplam += toplam / 2;
            label4.Text = toplam.ToString();
           label6.Text = lgun.Items.Count.ToString();
            label9.Text = _isim.Text;
           
        }
        int[] idler = new int[31];
        SqlConnection baglanti = new SqlConnection("server=DESKTOP-63LOO5Q;database=AJANDA;integrated security=true");
        private void doldur()
        {
       
            int sayac = 0;
            try{
                lmesai.Items.Clear();
                lgun.Items.Clear();
                SqlCommand sorgu = baglanti.CreateCommand();
                sorgu.CommandText = "select GUN,MESAİ,NU from TBLPUANTAJ where ID=@ID and AY='"+tar+"'";
                sorgu.Parameters.AddWithValue("@ID", num);
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlDataReader veri = sorgu.ExecuteReader();
                while (veri.Read())
                {
                    lgun.Items.Add((string)veri["GUN"]);
                    lmesai.Items.Add((double)veri["MESAİ"]);
                    idler[sayac++] = (int)veri["NU"];

                }
                veri.Close();
                baglanti.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("VERİLER YÜKLENMEDİ" + ex.Message);
            }
        }
        private double topmesai()
        {
            double toplam = 0;
            for (int i = 0; i < lgun.Items.Count; i++)
                toplam += (double)lmesai.Items[i];
                return toplam;
        }
       
        private void bekle_Click(object sender, EventArgs e)
        {   double mesai;
            string tarih = dateTimePicker1.Value.Year.ToString() + "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Month.ToString();
         
            bool k = double.TryParse(tmesai.Text.Replace('.',','), out mesai);
        
            if (k)
            {
                if (lgun.FindString(tarih) == -1) 
                {
                    try
                    {
                        lgun.Items.Add(tarih);
                        lmesai.Items.Add(mesai);
                        SqlCommand sorgu = baglanti.CreateCommand();
                        sorgu.CommandType = CommandType.StoredProcedure;
                        sorgu.CommandText = "sp_ekle";
                        sorgu.Parameters.Add("GUN", SqlDbType.NVarChar, 50).Value = tarih;
                        sorgu.Parameters.Add("MESAİ", SqlDbType.Float).Value = mesai;
                        sorgu.Parameters.Add("ID", SqlDbType.Int).Value = num;
                        sorgu.Parameters.Add("AY", SqlDbType.VarChar, 5).Value = tar;
                        if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                         sorgu.ExecuteNonQuery();
                        baglanti.Close();
                        tmesai.Text = "0";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("EKLENMEDİ HATA=" + ex.Message);
                    }
                }
                else
                {   MessageBox.Show("AYNI GÜN EKLENEMEZ");
            
                }
                }
            else
           MessageBox.Show("MESAİ SAATİNİ GİRİNİZ");
            double toplam = topmesai();
            toplam += toplam / 2;
            label4.Text = toplam.ToString();
           label6.Text = lgun.Items.Count.ToString();
        }

        private void bsil_Click(object sender, EventArgs e)
        {
            int secilen = lgun.SelectedIndex;
            if (secilen > -1)
            {  string gun=(string)lgun.Items[secilen];
                lgun.Items.RemoveAt(secilen);
                lmesai.Items.RemoveAt(secilen);
                try
                {
                    SqlCommand sorgu = baglanti.CreateCommand();
                    sorgu.CommandType = CommandType.StoredProcedure;
                    sorgu.CommandText = "sp_sil";
                    sorgu.Parameters.Add("GUN", SqlDbType.NVarChar, 50).Value = gun;
                    sorgu.Parameters.Add("ID", SqlDbType.Int).Value = num;
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    sorgu.ExecuteNonQuery();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SİLİNEMEDİ HATA=" + ex.Message);
                }
                double toplam = topmesai();
                toplam += toplam / 2;
                label4.Text = toplam.ToString();
                label6.Text = lgun.Items.Count.ToString();
            }
        }
        public static double mes;
        private void bduz_Click(object sender, EventArgs e)
        {
            int secilen = lgun.SelectedIndex;
            if (secilen > -1)
            {   TextBox gun = new TextBox();
            mes = (double)lmesai.Items[secilen];
                gun.Text = (string)lgun.Items[secilen];
               
                fçaduzenle frm = new fçaduzenle(gun,mes);
                frm.ShowDialog();
          
                    lgun.Items.RemoveAt(secilen);
                    lmesai.Items.RemoveAt(secilen);
                    lgun.Items.Insert(secilen, gun.Text);
                    lmesai.Items.Insert(secilen, mes);
                    try
                    {
                        SqlCommand sorgu = baglanti.CreateCommand();
                        sorgu.CommandType = CommandType.StoredProcedure;
                        sorgu.CommandText = "sp_guncelle";
                        sorgu.Parameters.Add("GUN", SqlDbType.NVarChar, 50).Value = gun.Text;
                        sorgu.Parameters.Add("ID", SqlDbType.Int).Value = num;
                        sorgu.Parameters.Add("MESAİ", SqlDbType.Float).Value = mes;
                        sorgu.Parameters.Add("NU", SqlDbType.Int).Value = idler[secilen];
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        sorgu.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("GÜNCELLENDİ");
                        double toplam = topmesai();
                        toplam += toplam / 2;
                        label4.Text = toplam.ToString();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("GÜNCELLENMEDİ" + ex.Message);
                    }

                }
            }
        

        private void lgun_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            int secilen=lb.SelectedIndex;
            lmesai.SelectedIndex = secilen;
            lgun.SelectedIndex = secilen;
        }

        private void bmashesapla_Click(object sender, EventArgs e)
        {  double maas;
            bool k=double.TryParse(tmaas.Text.Replace('.',','),out maas);
            if (k)
            {
                double gunpa = maas / 30;
                double saucret = gunpa / 8;
                double capara = (lgun.Items.Count * gunpa);
                cgunpa.Text=capara.ToString()+" TL";
                double mesaipara= ((topmesai() + topmesai() / 2) * saucret);
                mesaipa.Text = mesaipara.ToString() + " TL";
                toppa.Text = (capara + mesaipara).ToString() + "TL";
            
            
            }
        }

        private void brapor_Click(object sender, EventArgs e)
        {
            string tarih = dateTimePicker1.Value.Month.ToString();
            rapor frm = new rapor(tarih,num);
            frm.ShowDialog();
        }

    }
}
