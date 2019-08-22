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
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("server=DESKTOP-63LOO5Q;database=AJANDA;integrated security=true");
        public Form1()
        {
            InitializeComponent();
            
            lkisiler.View = View.Details;
            lkisiler.Columns.Add("AD");
            lkisiler.Columns.Add("SOYAD");
            lkisiler.Columns.Add("İŞEBAŞLANGIC TARİHİ");

            lkisiler.FullRowSelect = true;
          
            Wievdoldur();
            
        }
        private void Wievdoldur()
        {
            try
            {
                lkisiler.Items.Clear();
                SqlCommand sorgu = baglanti.CreateCommand();
                sorgu.CommandText = "select Ad,Soyad,Isebaslangıc from KİSİLER";
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                SqlDataReader veri = sorgu.ExecuteReader();
                while (veri.Read())
                {
                    
                   string tarih= veri["Isebaslangıc"].ToString();
                 string[] kisi = { (string)veri["Ad"], (string)veri["Soyad"], tarih };
                    lkisiler.Items.Add(new ListViewItem(kisi));
                }
                veri.Close();
                baglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("VERİLER OKUNAMADI HATA=" + ex.Message);
            }
        
        }
        private bool hata(TextBox t)
        {char[] sayilar = { '0', '1', '2', '3', '4', '5', '7', '8', '9' };
            bool hatam=true;
            Boolean k = false;
            for (int i = 0; i < t.Text.Length; i++)
            {
                for (int j = 0; j < sayilar.Length; j++)
                {
                    if (t.Text[i] == sayilar[j])
                    {  k=true;
                        hatam=false;
                      break ;
                    }
                }
                if (k)
                    break;
            }
            return hatam;
        }
        private void bekle_Click(object sender, EventArgs e)
        {
            if (tad.Text.Length > 0 && tsoy.Text.Length > 0)
            {
                if (hata(tad) && hata(tsoy))
                {
                    string tarih = dateTimePicker1.Value.Year.ToString() + "/" + dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Month.ToString();
                    string[] adsoy = { tad.Text, tsoy.Text, tarih };
                    lkisiler.Items.Add(new ListViewItem(adsoy));
                    tad.Clear();
                    tsoy.Clear();
                    try
                    {
                        SqlCommand sorgu = baglanti.CreateCommand();
                        sorgu.CommandType = CommandType.StoredProcedure;
                        sorgu.CommandText = "spkisiekle";
                        sorgu.Parameters.AddWithValue("@Ad", adsoy[0]);
                        sorgu.Parameters.AddWithValue("@Soyad", adsoy[1]);
                        sorgu.Parameters.AddWithValue("@Isebaslangıc", adsoy[2]);
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        sorgu.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("VERİLER EKLENEMEDİ HATA=" + ex.Message);
                    }
                    Wievdoldur();
                }
                else
                    MessageBox.Show("İsim yada Soy isimde Rakam kullanılmaz");
            }

        }

        private void bsil_Click(object sender, EventArgs e)
        {
            int secilen = lkisiler.SelectedIndices.Count;
            if (secilen > 0)
            {
                DialogResult sonuc = MessageBox.Show("Kişi Silinsin mi?", "UYARI", MessageBoxButtons.YesNo);
                if(DialogResult.Yes==sonuc)
                try
                {   string[] adsoy={lkisiler.SelectedItems[0].SubItems[0].Text,lkisiler.SelectedItems[0].SubItems[1].Text};
                lkisiler.Items.RemoveAt(lkisiler.SelectedItems[0].Index);
                SqlCommand sorgu1 = baglanti.CreateCommand();
                sorgu1.CommandText = "select ID from KİSİLER where Ad=@Ad and Soyad=@Soyad ";
                     sorgu1.Parameters.AddWithValue("@Ad", adsoy[0]);
                    sorgu1.Parameters.AddWithValue("@Soyad", adsoy[1]);
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    SqlDataReader veri = sorgu1.ExecuteReader();
                    veri.Read();
                    int kisnum = (int)veri["ID"];
                    veri.Close();
                    sorgu1.CommandText = "delete from TBLPUANTAJ where ID=@ID";
                    sorgu1.Parameters.AddWithValue("@ID",kisnum);
                    SqlCommand sorgu2 = baglanti.CreateCommand();
                    sorgu2.CommandText = "delete from KİSİLER where Ad=@Ad and Soyad=@Soyad";
                    sorgu2.Parameters.AddWithValue("@Ad", adsoy[0]);
                    sorgu2.Parameters.AddWithValue("@Soyad", adsoy[1]);
                    sorgu1.ExecuteNonQuery();
                    sorgu2.ExecuteNonQuery();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("VERİLER SİLİNEMEDİ HATA=" + ex.Message);
                }
              
            }
        }
    
        private void bduz_Click(object sender, EventArgs e)
        {
            int secilen = lkisiler.SelectedIndices.Count;
            if (secilen > 0)
            {
                string[] adsoy = { lkisiler.SelectedItems[0].SubItems[0].Text, lkisiler.SelectedItems[0].SubItems[1].Text, lkisiler.SelectedItems[0].SubItems[2].Text};
                TextBox t1 = new TextBox();
                t1.Text = adsoy[0];
                TextBox t2 = new TextBox();
                t2.Text = adsoy[1];
                TextBox t3 = new TextBox();
                t3.Text = adsoy[2];
                TextBox[] dizi = { t1, t2, t3 };
               fduzenle frm=new fduzenle(dizi);
                frm.ShowDialog();
                
                try
                {  
                    SqlCommand sorgu = baglanti.CreateCommand();
                    sorgu.CommandText = "update KİSİLER set Ad=@Ad,Soyad=@Soyad,Isebaslangıc=@Isebaslangıc where Ad='"+adsoy[0]+"' and Soyad='"+adsoy[1]+"'";
                  
                    sorgu.Parameters.AddWithValue("@Ad", dizi[0].Text);
                    sorgu.Parameters.AddWithValue("@Soyad",dizi[1].Text);
                    sorgu.Parameters.AddWithValue("@Isebaslangıc",dizi[2].Text);
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    sorgu.ExecuteNonQuery();
                    baglanti.Close();
                    Wievdoldur();
                    MessageBox.Show("VERİLER GÜNCELLENDİ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("VERİLER GÜNCELLENMEDİ" + ex.Message);
                
                }
                Wievdoldur();
            }
        }
       
        private void bsec_Click(object sender, EventArgs e)
        {
            string tarih =  dateTimePicker1.Value.Month.ToString();
            int num = 0;
            int secilen = lkisiler.SelectedIndices.Count;
            if (secilen > 0)
            {
                string[] kisi = { lkisiler.SelectedItems[0].SubItems[0].Text, lkisiler.SelectedItems[0].SubItems[1].Text, lkisiler.SelectedItems[0].SubItems[2].Text };
                try
                {
                    SqlCommand sorgu = baglanti.CreateCommand();
                    sorgu.CommandText = "select ID from KİSİLER where Ad=@Ad and Soyad=@Soyad and Isebaslangıc=@Isebaslangıc";
                    sorgu.Parameters.AddWithValue("@Ad",kisi[0]);
                    sorgu.Parameters.AddWithValue("@Soyad",kisi[1]);
                    sorgu.Parameters.AddWithValue("@Isebaslangıc",kisi[2]);
                    if(baglanti.State==ConnectionState.Closed)
                        baglanti.Open();
                    SqlDataReader veri=sorgu.ExecuteReader();
                    if(veri.Read())
                        num=(int)veri["ID"];
                    veri.Close();
                    baglanti.Close();
                 
                }
                catch (Exception ex)
                { 
                MessageBox.Show("KİŞİ BİLGİLERİ OKUNAMADI HATA="+ex.Message);
                
                }
                Label isim = new Label();
                isim.Text = lkisiler.SelectedItems[0].SubItems[0].Text+" "+lkisiler.SelectedItems[0].SubItems[1].Text; 
                calısma frm = new calısma(num,isim,tarih);
                frm.ShowDialog();
            
            }

        }

       

    }
}
