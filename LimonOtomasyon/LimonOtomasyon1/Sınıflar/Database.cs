using Bunifu.Framework.UI;
using System;

using System.Data.SQLite;
using System.Windows.Forms;
using System.Net.Mail;
using System.Collections;
using LimonOtomasyon1.Formlar.KucukFormlar;

namespace LimonOtomasyon1.Sınıflar
{

    public class Database
    {
        public int prs_id = -1;
        SQLiteConnection baglanti;

        string adres = "Data Source =" + Application.StartupPath + "\\limon_veri.db";
        public void baglan()
        {

            try
            {
                baglanti = new SQLiteConnection();
                baglanti.ConnectionString = (adres);
                baglanti.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA (baglan) !" + ex.Message);
            }
        }
    
      
        public void kapat()
        {
            baglanti.Close();
        }

//Bu fonksiyonu hiçbir yerde çağırmadım.
        public bool veritabani_olustur()
        {
       
            //FileStream fs = File.Create(adres);

            string tum_komutlar = "CREATE TABLE `Adisyon` (`A_No`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,`M_No`INTEGER NOT NULL,`U_No`INTEGER NOT NULL,`Miktar`INTEGER NOT NULL,`A_Tarih`TEXT NOT NULL);";
            tum_komutlar += "CREATE TABLE `EskiAdisyon` (`A_No`INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,`M_No`INTEGER NOT NULL,`U_No`INTEGER NOT NULL,`Miktar`INTEGER NOT NULL,`A_Tarih`TEXT NOT NULL);";
            tum_komutlar += "CREATE TABLE `Kasa` (`K_No`INTEGER NOT NULL,`K_Aciklama`TEXT,`K_Tutar`	REAL NOT NULL,`K_Tur`TEXT NOT NULL,`K_Tarih`TEXT NOT NULL,PRIMARY KEY(`K_No`));";
            tum_komutlar += "CREATE TABLE `Kategori` (`K_id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,`K_ad`TEXT NOT NULL);";
            tum_komutlar += "CREATE TABLE `Masa` (`M_No`INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,`M_TakmaAd`TEXT);";
            tum_komutlar += "CREATE TABLE `Personel` (`P_No`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,`P_Ad`TEXT NOT NULL,`P_Tel`TEXT NOT NULL,`P_Tckimlik`TEXT NOT NULL,`P_Eposta`TEXT NOT NULL,`P_Adres`TEXT NOT NULL,`P_Dtarih`TEXT NOT NULL,`P_Pin`	TEXT NOT NULL,`K_No`	INTEGER,FOREIGN KEY(`K_No`) REFERENCES `Yonetici`(`K_No`));";
            tum_komutlar += "CREATE TABLE `Sonislem` (`S_id`	INTEGER PRIMARY KEY AUTOINCREMENT,`S_İslem`TEXT NOT NULL,`S_İslemTarihi`TEXT NOT NULL,`S_Pid`INTEGER NOT NULL);";
            tum_komutlar += "CREATE TABLE `Urun` (`U_No`INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,`U_Ad`TEXT NOT NULL,`U_Adet`INTEGER,`U_gFiyat`REAL NOT NULL,`U_bFiyat`REAL NOT NULL,`K_id`INTEGER,`HizliMenu`NUMERIC,FOREIGN KEY(`K_id`) REFERENCES `Kategori`(`K_id`));";
            tum_komutlar += "CREATE TABLE `Yonetici` (`K_No`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,`K_Eposta`TEXT NOT NULL,`K_DTarih`TEXT NOT NULL,`K_KullaniciAdi`TEXT NOT NULL,`K_Sifre`TEXT NOT NULL,`K_telno`INTEGER NOT NULL);";

            try
            {

                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();


                komut.CommandText = tum_komutlar;
                komut.ExecuteNonQuery();
                kapat();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (masa_olustur) =" + ex.Message);
                return false;
            }


        }


        public int[] K_Usayisibul()
        {
            int[] sayisi = new int[2];
            try
            {
                SQLiteCommand komut = null;
                baglan();

                komut = baglanti.CreateCommand();
                komut.CommandText = "select count(K_id) from Kategori";
                sayisi[0] = Convert.ToInt32(komut.ExecuteScalar());

                komut = baglanti.CreateCommand();
                komut.CommandText = "select count(U_No) from Urun";
                sayisi[1] = Convert.ToInt32(komut.ExecuteScalar());
                kapat();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (K_Usayisibul) : " + ex);
            }
            return sayisi;
        }
        public void masa_sayisi(System.Collections.ArrayList masa)
        {
            try
            {

                baglan();

                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select M_No from Masa";
                SQLiteDataReader veri = komut.ExecuteReader();
                masa.Clear();

                while (veri.Read())
                {
                    masa.Add(Convert.ToInt32(veri[0]));
                }

                kapat();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (masa_sayisi) : " + ex);
            }
        }
        public void Acik_Masa(System.Collections.ArrayList a_masa)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select distinct M_No from Adisyon";

                SQLiteDataReader veri = komut.ExecuteReader();
                a_masa.Clear();
                while (veri.Read())
                {
                    a_masa.Add(veri[0]);
                }
                veri.Close();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (Acik_Masa) =" + ex);
            }

        }
        public void Acik_Masa_İsim(System.Collections.ArrayList a_masa_ad, System.Collections.ArrayList a_masa_id)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select M_TakmaAd,M_No from Masa where M_TakmaAd != 'null';";

                SQLiteDataReader veri = komut.ExecuteReader();
                a_masa_ad.Clear();
                a_masa_id.Clear();
                while (veri.Read())
                {
                    a_masa_ad.Add(veri[0]);
                    a_masa_id.Add(veri[1]);
                }
                veri.Close();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (Acik_Masa) =" + ex);
            }

        }
        public void U_Ekle(string u_ad, double u_gfiyat, double u_bfiyat, int u_kid, int? u_adet)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "insert into Urun(U_Ad, U_Adet, U_gFiyat, U_bFiyat, K_id) values(@U_Ad, @U_Adet, @U_gFiyat, @U_bFiyat, @K_id)";
                komut.Parameters.AddWithValue("@U_Ad", u_ad);
                komut.Parameters.AddWithValue("@U_Adet", u_adet);
                komut.Parameters.AddWithValue("@U_gFiyat", u_gfiyat);
                komut.Parameters.AddWithValue("@U_bFiyat", u_bfiyat);
                komut.Parameters.AddWithValue("@K_id", u_kid);
                komut.ExecuteNonQuery();
                kapat();
            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA=" + ex.Message);
            }
        }
        public void U_ComboDoldur(ComboBox K_kid, ComboBox K_Ad)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select * from Kategori";
                SQLiteDataReader veri = komut.ExecuteReader();
                K_kid.Items.Clear();
                K_Ad.Items.Clear();


                while (veri.Read())
                {
                    K_kid.Items.Add(Convert.ToInt32(veri[0]));
                    K_Ad.Items.Add(veri[1] + "");

                }
                veri.Close();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA=" + ex.Message);
            }

        }
        public void U_ListDoldur(ListView Urun, ComboBox urun_id)
        {
            try
            {

                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select u.U_Ad ,u.U_gFiyat,u.U_bFiyat,k.K_ad,u.U_No  from Urun u inner join Kategori k on  k.k_id=u.K_id";

                SQLiteDataReader veri = komut.ExecuteReader();
                Urun.Items.Clear();
                urun_id.Items.Clear();
                while (veri.Read())
                {
                    Double kar_orani = ((Convert.ToDouble(veri[2]) - Convert.ToDouble(veri[1]))  / Convert.ToDouble(veri[1]) * 100);

                    int k1 = (int)kar_orani * 100;
                    kar_orani = k1 / 100.0;
                    string[] elemanlar = { veri[0].ToString(), veri[1].ToString(), veri[2].ToString(), veri[3].ToString(), " % " + kar_orani };

                    ListViewItem veriler = new ListViewItem(elemanlar);

                    Urun.Items.Add(veriler);
                    urun_id.Items.Add(veri[4]);

                }

                veri.Close();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (ListeDoldur) =" + ex);
            }

        }
        //Masa sayfasında ki Kategori butonlarına göre ürünleri getir
        public void U_ListSec(ListView Urun, int secilen)
        {
            try
            {

                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select U_Ad ,U_bFiyat,U_No from Urun where K_id=@kid";
                komut.Parameters.AddWithValue("@kid", secilen);
                SQLiteDataReader veri = komut.ExecuteReader();
                Urun.Items.Clear();
                while (veri.Read())
                {
                    string[] elemanlar = { veri[0].ToString(), veri[1].ToString(), veri[2].ToString() };

                    ListViewItem veriler = new ListViewItem(elemanlar);

                    Urun.Items.Add(veriler);
                }
                veri.Close();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (ListeDoldur) =" + ex);
            }

        }
        public void U_adgun(string u_ad, int u_id)
        {

            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "update Urun set U_Ad=@U_Ad where U_No=@U_No";
                komut.Parameters.AddWithValue("@U_Ad", u_ad);
                komut.Parameters.AddWithValue("@U_No", u_id);
                komut.ExecuteNonQuery();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (U_adgun) =" + ex);
            }
        }

        public void U_gelisfiyat_gun(string u_gFiyat, int u_id)
        {

            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "update Urun set U_gFiyat=@U_gFiyat where U_No=@U_No";
                komut.Parameters.AddWithValue("@U_gFiyat", u_gFiyat);
                komut.Parameters.AddWithValue("@U_No", u_id);
                komut.ExecuteNonQuery();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (U_adgun) =" + ex);
            }
        }

        public void U_birimfiyat_gun(string u_bFiyat, int u_id)
        {

            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "update Urun set U_bFiyat=@U_bFiyat where U_No=@U_No";
                komut.Parameters.AddWithValue("@U_bFiyat", u_bFiyat);
                komut.Parameters.AddWithValue("@U_No", u_id);
                komut.ExecuteNonQuery();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (U_adgun) =" + ex);
            }
        }

        public void U_kategori_gun(int K_kategori, int u_id)
        {

            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "update Urun set K_id=@K_kategori where U_No=@U_No";
                komut.Parameters.AddWithValue("@K_kategori", K_kategori);
                komut.Parameters.AddWithValue("@U_No", u_id);
                komut.ExecuteNonQuery();
                kapat();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (U_Kategori_gun) =" + ex);
            }
        }
        public void U_Sil(int u_id)
        {

            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "delete from Urun where U_No=@U_No";
                komut.Parameters.AddWithValue("@U_No", u_id);
                komut.ExecuteNonQuery();
                kapat();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (U_Sil_gun) =" + ex);
            }
        }
        public void U_Adet_gun(int u_adet, int u_id)
        {

            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "update Urun set U_Adet=@U_Adet where U_No=@U_No";
                komut.Parameters.AddWithValue("@U_Adet", u_adet);
                komut.Parameters.AddWithValue("@U_No", u_id);
                komut.ExecuteNonQuery();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (U_Adet_gun) =" + ex);
            }
        }

        public void K_ListDoldur(ListView Urun, ComboBox k_id)
        {
            try
            {
                SQLiteDataReader veri = null;
                SQLiteCommand komut = null;
                baglan();
                komut = baglanti.CreateCommand();
                komut.CommandText = "select k.K_ad,count(u.U_Ad),k.K_id from Kategori k inner join Urun u on u.K_id=k.K_id group by(k.K_ad)";

                veri = komut.ExecuteReader();
                Urun.Items.Clear();
                k_id.Items.Clear();
                while (veri.Read())
                {
                    string[] elemanlar = { veri[0].ToString(), veri[1].ToString() };

                    ListViewItem veriler = new ListViewItem(elemanlar);
                    k_id.Items.Add(veri[2]);
                    Urun.Items.Add(veriler);
                }

                veri.Close();
                komut = baglanti.CreateCommand();
                komut.CommandText = "select K_ad ,0,K_id from Kategori where not K_id in (select K_id from Urun group by K_id)";

                veri = komut.ExecuteReader();
                while (veri.Read())
                {
                    string[] elemanlar = { veri[0].ToString(), veri[1].ToString() };

                    ListViewItem veriler = new ListViewItem(elemanlar);
                    k_id.Items.Add(veri[2]);
                    Urun.Items.Add(veriler);
                }
                veri.Close();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (K_ListeDoldur) =" + ex);
            }

        }
        public void K_Ekle(string k_ad)
        {

            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "insert into Kategori(K_ad) values(@K_ad)";
                komut.Parameters.AddWithValue("@K_ad", k_ad);
                komut.ExecuteNonQuery();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (K_Ekle) =" + ex);
            }
        }
        public void K_Gun(int k_id, string k_ad)
        {

            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "update Kategori set K_ad=@K_ad where K_id=@K_id"; ;
                komut.Parameters.AddWithValue("@K_id", k_id);
                komut.Parameters.AddWithValue("@K_ad", k_ad);
                komut.ExecuteNonQuery();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (K_Gun) =" + ex);
            }
        }
        public void K_Sil(int k_id)
        {
            SQLiteCommand komut = null;
            try
            {
                baglan();
                komut = baglanti.CreateCommand();
                komut.CommandText = "delete from Urun where K_id=@K_id"; ;
                komut.Parameters.AddWithValue("@K_id", k_id);
                komut.ExecuteNonQuery();
                komut = baglanti.CreateCommand();
                komut.CommandText = "delete from Kategori where K_id=@K_id"; ;
                komut.Parameters.AddWithValue("@K_id", k_id);
                komut.ExecuteNonQuery();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (K_Sil) =" + ex);
            }
        }
        public bool U_kontrol(string deger)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select U_Ad from Urun where U_Ad like @qq";
                komut.Parameters.AddWithValue("@qq", deger);
                SQLiteDataReader veri = komut.ExecuteReader();

                if (veri.Read())
                {
                    veri.Close();
                    kapat();
                    return false;
                }
                veri.Close();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (U_Kontrol) =" + ex);
            }
            return true;
        }
        public bool K_kontrol(string deger)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select K_ad from Kategori where  K_ad like @qq";
                komut.Parameters.AddWithValue("@qq", deger);
                SQLiteDataReader veri = komut.ExecuteReader();

                if (veri.Read())
                {
                    veri.Close();
                    kapat();
                    return false;
                }
                veri.Close();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (K_Kontrol) =" + ex);
            }
            return true;
        }

     


        public bool girisyap(string eposta, string sifre)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select K_No from Yonetici where K_Eposta=@eposta AND K_Sifre=@sifre";
               komut.Parameters.AddWithValue("@eposta", eposta);
                komut.Parameters.AddWithValue("@sifre", sifre);
                SQLiteDataReader veri = komut.ExecuteReader();
                if (veri.Read())
                {
                    cGenel.yonetici_no = Convert.ToInt32(veri[0]);
                    veri.Close();
                    kapat();
                    alarm.Show("Başarı ile giriş yaptınız.", alarm.Alarmtur.basarili);
                    return true;
                }
                alarm.Show("Lütfen şifre ve e-posta adresinizi tekrar kontrol edin.", alarm.Alarmtur.hata);
                veri.Close();
                kapat();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (girisyap) : " + ex.Message);
                return false;
            }
            return false;
        }
        
        public void Masa_İsimDegistir(int m_id, string m_ad)
        {

            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "update Masa set M_TakmaAd=@mtakma where M_No=@M_No";
                komut.Parameters.AddWithValue("@M_No", m_id);
                komut.Parameters.AddWithValue("@mtakma", m_ad);
                komut.ExecuteNonQuery();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (Masa_isimdegistir) =" + ex);
            }

        }
        public string Masa_İsimKontrol(int m_id)
        {
            string m_isim = "";
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select M_TakmaAd from Masa where M_No=@M_No";
                komut.Parameters.AddWithValue("@M_No", m_id);
                m_isim = komut.ExecuteScalar().ToString();
                kapat();
                return m_isim;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (Masa_İsimKontrol) =" + ex);
                return m_isim;
            }

        }
        public void Adisyon_Ekle(int m_no, int u_no, int miktar,string tarih)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "insert into Adisyon(M_No,U_No,Miktar,A_Tarih) values(@M_No,@U_No,@Miktar,@A_Tarih)";
                komut.Parameters.AddWithValue("@M_No", m_no);
                komut.Parameters.AddWithValue("@U_No", u_no);
                komut.Parameters.AddWithValue("@Miktar", miktar);
                komut.Parameters.AddWithValue("@A_Tarih", tarih);
                komut.ExecuteNonQuery();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (Adisyon_Ekle) =" + ex.Message);
            }
        }
        public void Adisyon_getir(int m_no, ListView adisyon)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select u.U_Ad,a.Miktar,(U.U_bFiyat*a.Miktar),a.A_Tarih,a.A_No  from Adisyon a  inner join Urun u on u.U_No=a.U_No   where a.M_No=@mno";
                komut.Parameters.AddWithValue("@mno", m_no);
                SQLiteDataReader veri = komut.ExecuteReader();
                adisyon.Items.Clear();
                while (veri.Read())
                {
                    string zaman = veri[3].ToString().Substring(12, 1);
                    if (zaman == ":")
                        zaman = veri[3].ToString().Substring(10, 5);
                    else
                        zaman = veri[3].ToString().Substring(10, 6);


                    string[] elemanlar = { veri[0].ToString(), veri[1].ToString(), veri[2].ToString(), "  "+zaman, veri[4].ToString()  };

                    ListViewItem veriler = new ListViewItem(elemanlar);
                    adisyon.Items.Add(veriler);
                }
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (Adisyon_getir) =" + ex);
            }
        }
        public void Adisyon_Sil(int adisyon_no)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "delete from Adisyon where A_No=@A_No";
                komut.Parameters.AddWithValue("@A_No", adisyon_no);
                komut.ExecuteNonQuery();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (Adisyon_Sil) =" + ex.Message);
            }
        }
        public double Toplam_tutar(int m_no)
        {
            double toplam = 0;
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select sum((U.U_bFiyat*a.Miktar)) as 'Tutar'  from Adisyon a  inner join Urun u on u.U_No=a.U_No   where a.M_No=@mno";
                komut.Parameters.AddWithValue("@mno", m_no);
                toplam = Convert.ToDouble(komut.ExecuteScalar());
                kapat();
                return toplam;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (Toplam_tutar) =" + ex.Message);
                return toplam;
            }

        }
        public void EskiA_Sil(int m_no)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "delete from EskiAdisyon where M_No=@M_No";
                komut.Parameters.AddWithValue("@M_No", m_no);
                komut.ExecuteNonQuery();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (EskiA_Sil) =" + ex.Message);
            }
        }
        public void EskiA_Ekle(int mno)
        {
            try
            {
                baglan();
                SQLiteCommand komut1 = baglanti.CreateCommand();
                komut1.CommandText = "select M_No,U_No,Miktar,A_Tarih from Adisyon where M_No=@M_No";
                komut1.Parameters.AddWithValue("@M_No", mno);
                SQLiteDataReader veri = komut1.ExecuteReader();
                while (veri.Read())
                {

                    SQLiteCommand komut = baglanti.CreateCommand();
                    komut.CommandText = "insert into EskiAdisyon(M_No,U_No,Miktar,A_Tarih) values(@M_No,@U_No,@Miktar,@A_Tarih)";
                    komut.Parameters.AddWithValue("@M_No", Convert.ToInt32(veri[0]));
                    komut.Parameters.AddWithValue("@U_No", Convert.ToInt32(veri[1]));
                    komut.Parameters.AddWithValue("@Miktar", Convert.ToInt32(veri[2]));
                    komut.Parameters.AddWithValue("@A_Tarih", veri[3].ToString());
                    komut.ExecuteNonQuery();

                }
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (EskiA_Ekle) =" + ex.Message);
            }
        }
        public void Adisyon_Temizle(int mno)
        {
            try
            {
                SQLiteCommand komut1 = null;
                baglan();
                komut1 = baglanti.CreateCommand();
                komut1.CommandText = "delete from Adisyon where M_No=@M_No";
                komut1.Parameters.AddWithValue("@M_No", mno);
                komut1.ExecuteNonQuery();

                komut1 = baglanti.CreateCommand();
                komut1.CommandText = "update Masa set M_TakmaAd=null where M_No=@M_No ";
                komut1.Parameters.AddWithValue("@M_No", mno);
                komut1.ExecuteNonQuery();
                kapat();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (Adisyon_Temizle) =" + ex.Message);
            }
        }
        public bool Personel_ekle(String isim, String telefon, String tckimlik, String eposta, String adres, String tarih, String pin,int yno)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "insert into Personel(P_Ad,P_Tel,P_Tckimlik,P_Eposta,P_Adres,P_Dtarih,P_Pin,K_No) values(@isim, @telefon, @tckimlik,@eposta, @adres, @tarih,@sifre,@K_No)";
                komut.Parameters.AddWithValue("@isim", isim);
                komut.Parameters.AddWithValue("@telefon", telefon);
                komut.Parameters.AddWithValue("@tckimlik", tckimlik);
                komut.Parameters.AddWithValue("@eposta", eposta);
                komut.Parameters.AddWithValue("@adres", adres);
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.Parameters.AddWithValue("@sifre", pin);
                komut.Parameters.AddWithValue("@K_No", yno);
                komut.ExecuteNonQuery();
                kapat();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA : (Personel_ekle)" + ex.Message);
                return false;
            }
        }
        public bool Personel_sil(string isim)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "delete from Personel where P_Ad=@P_isim";
                komut.Parameters.AddWithValue("@P_isim", isim);
                SQLiteDataReader veri = komut.ExecuteReader();
                if (veri.Read())
                {
                    veri.Close();
                    kapat();
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (Personel_sil) =" + ex.Message);
                return false;
            }
            return false;

        }
        public bool personel_giris(string sifre)
        {
            try
            {
                
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select P_No,K_No from Personel where P_Pin=@pin";
                komut.Parameters.AddWithValue("@pin", sifre);
                SQLiteDataReader veri = komut.ExecuteReader();
                if (veri.Read())
                {
                   
                    prs_id = Convert.ToInt32(veri[0]);
                    cGenel.yonetici_no = Convert.ToInt32(veri[1]);
                    veri.Close();
                    kapat();
                    return true;
                }
                veri.Close();
                kapat();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (personel_giris) : " + ex.Message);
            }
            return false;
        }

        public int personel_id(string p_sifre)
        {

            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select P_No from Personel where P_pin=@pin";
                komut.Parameters.AddWithValue("@pin", p_sifre);
                cGenel.personel_no = Convert.ToInt32(komut.ExecuteScalar());
                kapat();
                return cGenel.personel_no;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (personel_id) : " + ex.Message);
                return -1;
            }
        }
        public bool P_sifre_Aynimi(string p_sifre) 
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select P_No from Personel where P_pin like @pin";
                komut.Parameters.AddWithValue("@pin", p_sifre);
                SQLiteDataReader veri = komut.ExecuteReader();
                if (veri.Read())
                {
                    kapat();
                    return false;
                }
                kapat();
                return true;
            }
            catch (Exception ex)
            {
                kapat();
                MessageBox.Show("Hata (personel_id) : " + ex.Message);
                return false;
            }
        }
        #region Hesap-Defteri işlemleri
        public bool kasa_ekle(String K_aciklama, double K_tutar, string K_tur, string K_tarih)
        {

            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "insert into Kasa(K_Aciklama,K_Tutar,K_Tur,K_Tarih) values(@K_aciklama,@K_tutar,@K_tur,@K_tarih)";
                komut.Parameters.AddWithValue("@K_aciklama", K_aciklama);
                komut.Parameters.AddWithValue("@K_tutar", K_tutar);
                komut.Parameters.AddWithValue("@K_tur", K_tur);
                komut.Parameters.AddWithValue("@K_tarih", K_tarih);



                komut.ExecuteNonQuery();
                kapat();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (kasa_ekle) =" + ex.Message);
                return false;
            }
        }
        public void kasa_getir(ListView kasa)
        {
            try
            {

                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select K_Aciklama ,K_Tutar,K_Tur,K_Tarih,K_No  from Kasa";

                SQLiteDataReader veri = komut.ExecuteReader();
                kasa.Items.Clear();
                while (veri.Read())
                {
                    string[] elemanlar = { veri[0].ToString(), veri[1].ToString(), veri[2].ToString(), veri[3].ToString(), veri[4].ToString() };

                    ListViewItem veriler = new ListViewItem(elemanlar);

                    kasa.Items.Add(veriler);

                }

                veri.Close();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (kasa_getir) =" + ex);
            }

        }
        public void Kasa_Sil(int kno)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "delete from Kasa where K_No=@K_No";
                komut.Parameters.AddWithValue("@K_No", kno);

                komut.ExecuteNonQuery();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata ( Kasa_Sil) =" + ex.Message);
            }

        }
        public double Kasa_Gelirgider()
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select sum(K_tutar) from kasa";
                double toplam = Convert.ToDouble(komut.ExecuteScalar());
                komut.ExecuteNonQuery();
                kapat();
                return toplam;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (kasa_gelirgider) : " + ex.Message);
                return 0;
            }

        }
        #endregion //Hesap Defteri Bitiş

        #region E-posta Gönderme İşlemlerini Burada Yapıyoruz
        public bool eposta_gonder(string eposta_adresi, string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();

            //E-posta Gönderebilmek Adına Gerekli Ayarlamaları Yapıyoruz.
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("hasaneksi.mdbf15@iste.edu.tr", "hasan_14785236987i");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;


            // E-posta İçeriğini Oluşturuyoruz.

            // E-posta'nın Kimden Gönderileceğini Belirtiyoruz.
            ePosta.From = new MailAddress("hasaneksi.mdbf15@iste.edu.tr");
            //KİME gönderileceğini belirtiyoruz.
            ePosta.To.Add(eposta_adresi);
            //Konusunu Belirtiyoruz.
            ePosta.Subject = konu;
            //Metni Belirtiyoruz.
            ePosta.Body = icerik;

            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Hata (eposta) : " + ex.Message);
                return false;
            }

        }
        #endregion
        public void hizli_m(int u_id)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "update Urun set HizliMenu=1 where U_No=@U_No";
                komut.Parameters.AddWithValue("@U_No", u_id);
                komut.ExecuteNonQuery();
                kapat();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (hizli_m) : " + ex.Message);
            }

        }
        public void hizli_sifirla()
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "update Urun set HizliMenu=0 ";
                komut.ExecuteNonQuery();
                kapat();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (hizli_sifirla) : " + ex.Message);
            }
        }
        public int hizlimsayisi_bul()
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select count(U_No) from Urun where HizliMenu=1";
                int sayi = Convert.ToInt32(komut.ExecuteScalar());
                kapat();
                return sayi;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (hizli_m) : " + ex.Message);
                return -1;

            }
        }
        public void hizli_menu_getir(ComboBox u_ad, ComboBox u_id)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select U_No,U_Ad from Urun where HizliMenu=1";
                SQLiteDataReader veri = komut.ExecuteReader();
                u_ad.Items.Clear();
                u_id.Items.Clear();
                while (veri.Read())
                {
                    u_id.Items.Add(veri[0]);
                    u_ad.Items.Add(veri[1]);
                }
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (hizli_menu_getir) =" + ex);
            }

        }
        public void E_adisyon_getir(int m_no, ListView adisyon)
        {

            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select u.U_Ad,a.Miktar,(U.U_bFiyat*a.Miktar),a.A_Tarih,a.A_No  from EskiAdisyon a  inner join Urun u on u.U_No=a.U_No   where a.M_No=@mno";
                komut.Parameters.AddWithValue("@mno", m_no);
                SQLiteDataReader veri = komut.ExecuteReader();
                adisyon.Items.Clear();
                while (veri.Read())
                {
                    string[] elemanlar = { veri[0].ToString(), veri[1].ToString(), veri[2].ToString(), veri[3].ToString(), veri[4].ToString() };

                    ListViewItem veriler = new ListViewItem(elemanlar);
                    adisyon.Items.Add(veriler);
                }
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata ( E_adisyon_getir) =" + ex);
            }

        }
      

        public void Bos_Masa_Bul(ComboBox b_masa)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select M_No from masa where M_No not in(select distinct M_No from Adisyon)";
                SQLiteDataReader veri = komut.ExecuteReader();
                b_masa.Items.Clear();
                while (veri.Read())
                {
                    b_masa.Items.Add((Convert.ToInt32(veri[0])));
                }
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (Bos_Masa_Bul) =" + ex);
            }
        }
        public void masa_Tutar(ComboBox masa, ComboBox tutar) 
        {
            try
            {
                 baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select a.M_No,sum(a.Miktar*u.U_bFiyat) from Adisyon a inner join Urun u on u.U_No=a.U_No  group by a.M_No";
                SQLiteDataReader veri = komut.ExecuteReader();
                masa.Items.Clear();
                tutar.Items.Clear();
                while (veri.Read())
                {
                    masa.Items.Add(veri[0].ToString());
                    tutar.Items.Add(veri[1].ToString());
                  //  MessageBox.Show(veri[1].ToString());
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Hata (masa_Tutar) =" + ex);
            }
        
        }
        public void Masa_tasi(int simdikimasa, int tasinacakmasa)
        {
            try
            {
                SQLiteCommand komut = null;
                baglan();
                komut = baglanti.CreateCommand();
                komut.CommandText = "update Adisyon set M_No=@tasinacak where M_No=@simdiki";
                komut.Parameters.AddWithValue("@simdiki", simdikimasa);
                komut.Parameters.AddWithValue("@tasinacak", tasinacakmasa);
                komut.ExecuteNonQuery();
                komut = baglanti.CreateCommand();
                komut.CommandText = "update Masa set M_TakmaAd=(select  M_TakmaAd from Masa where M_No=@simdi) where M_No=@tasi";
                komut.Parameters.AddWithValue("@simdi", simdikimasa);
                komut.Parameters.AddWithValue("@tasi", tasinacakmasa);
                komut.ExecuteNonQuery();
                komut = baglanti.CreateCommand();
                komut.CommandText = "update Masa set M_TakmaAd=null where M_No=@mno";
                komut.Parameters.AddWithValue("@mno", simdikimasa);

                komut.ExecuteNonQuery();
                kapat();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (Masa_tasi) =" + ex);
            }
        }
        public void Son_islem_ekle(string s_islem, string islem_tarih, int p_id)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "insert into Sonislem(S_İslem,S_İslemTarihi,S_Pid) values(@S_İslem,@S_İslemTarihi,@S_Pid)";
                komut.Parameters.AddWithValue("@S_İslem", s_islem);
                komut.Parameters.AddWithValue("@S_İslemTarihi", islem_tarih);
                komut.Parameters.AddWithValue("@S_Pid", p_id);
                komut.ExecuteNonQuery();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (Son_islem_ekle) =" + ex.Message);
            }

        }
        public void Sonislem_getir(ListView son_islem)
        {
            try
            {

                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select s.S_İslem,s.S_İslemTarihi,p.P_Ad from Sonislem s inner join personel p on p.P_No=s.S_Pid order by s.S_id desc";

                SQLiteDataReader veri = komut.ExecuteReader();
                son_islem.Items.Clear();
                while (veri.Read())
                {
                    string[] elemanlar = { veri[0].ToString(), veri[1].ToString(), veri[2].ToString()};

                    ListViewItem veriler = new ListViewItem(elemanlar);

                    son_islem.Items.Add(veriler);
                }

                veri.Close();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (Sonislem_getir) =" + ex);
            }

        }

        public bool masa_tablo_olustur()
        {
            SQLiteCommand komut = null;
            try
            {
                baglan();
                komut = baglanti.CreateCommand();
                komut.CommandText = "DROP TABLE Masa";
                komut.ExecuteNonQuery();
                komut.CommandText = "CREATE TABLE `Masa` (	`M_No`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,	`M_TakmaAd`	TEXT); ";
                komut.ExecuteNonQuery();
                kapat();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (masa_tablo_olustur) =" + ex.Message);
                return false;
            }
        }
        public bool masa_olustur(int button_sayi)
        {
            SQLiteCommand komut = null;
            try
            {
                baglan();
                for(int i = 0; i < button_sayi; i++) {
                komut = baglanti.CreateCommand();
                komut.CommandText = "insert into Masa (M_TakmaAd) values (null) ";
                komut.ExecuteNonQuery();
                }
                kapat();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (masa_olustur) =" + ex.Message);
                return false;
            }
        }
        public int personel_sayisi()
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select count(P_No) from Personel";
                int sayisi = Convert.ToInt32(komut.ExecuteScalar());
                kapat();
                return sayisi;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (personel_sayisi) : " + ex);
                return -1;
            }
        }
        public void personel_getir(ArrayList ad, ArrayList id)
        {
            try
            {

                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select P_No,P_Ad from Personel";
                SQLiteDataReader veri = komut.ExecuteReader();
                ad.Clear();
                id.Clear();
                while (veri.Read())
                {
                    id.Add(veri[0]);
                    ad.Add(veri[1]);
                }

                veri.Close();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (personel_getir) =" + ex);
            }

        }
        public void id_personel_getir(BunifuMetroTextbox[] text, int p_id)
        {
            try
            {
               
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "select P_Ad,P_Adres,P_Eposta,P_Tckimlik,P_Tel,P_Dtarih from Personel where P_No=@pno";
                komut.Parameters.AddWithValue("@pno", p_id);
                SQLiteDataReader veri = komut.ExecuteReader();
                for (int i = 0; i < text.Length; i++)
                    text[i].Text = "";
                while (veri.Read())
                {
                    text[0].Text = veri[0].ToString();
                    text[1].Text = veri[1].ToString();
                    text[2].Text = veri[2].ToString();
                    text[3].Text = veri[3].ToString();
                    text[4].Text = veri[4].ToString();
                    text[5].Text = veri[5].ToString();

                }

                veri.Close();
                kapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (id_personel_getir) =" + ex);
            }

        }

# region Program Başlangıç Ayarları


        public bool program_basla()
        {
            int sayi;
            try
            {
                SQLiteCommand komut = null;
                baglan();

                komut = baglanti.CreateCommand();
                komut.CommandText = "select count(Program) from Ayarlar";
                sayi = Convert.ToInt32(komut.ExecuteScalar());
                if (sayi == 1)
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (K_Usayisibul) : " + ex);
                return false;
            }
        }
        /* Eğer program ilk defa açılıyorsa bir daha ki açılışta bunu hatırlayabilmek adına Ayarlar
        Sayfasını güncelleyeceğiz. */
        public bool program_acildi()
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "insert into Ayarlar(Program) values(@Program)";
                komut.Parameters.AddWithValue("@Program", 1);
                komut.ExecuteNonQuery();
                kapat();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA : (program_acildi)" + ex.Message);
                return false;
            }
        }
        public bool yonetici_ekle(string isim,string eposta,string sifre,string tel,string isletme_adi,string adres)
        {
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "insert into Yonetici(K_Ad,K_Eposta,K_Sifre,K_Telno,Isletme_Adi,Isletme_Adres) values(@K_Ad,@eposta,@sifre,@telno,@isletmeadi,@isletmeadres)";
                komut.Parameters.AddWithValue("@K_Ad", isim);
                komut.Parameters.AddWithValue("@eposta", eposta);
                komut.Parameters.AddWithValue("@sifre", sifre);
                komut.Parameters.AddWithValue("@telno", tel);
                komut.Parameters.AddWithValue("@isletmeadi", isletme_adi);
                komut.Parameters.AddWithValue("@isletmeadres", adres);



                komut.ExecuteNonQuery();
                kapat();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA : (program_acildi)" + ex.Message);
                return false;
            }

        }
        public void sonislemeri_sil()
        {
           
            try
            {
                baglan();
                SQLiteCommand komut = baglanti.CreateCommand();
                komut.CommandText = "update sqlite_sequence set seq=0 where name='Sonislem'";
                komut.ExecuteNonQuery();
                kapat();

                baglan();
                SQLiteCommand komut2 = baglanti.CreateCommand();
                komut2.CommandText = "delete from Sonislem";
                komut2.ExecuteNonQuery();
                kapat();

                alarm.Show("Son işlemler başarı ile silindi.", alarm.Alarmtur.basarili);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata (sonislemleri_sil)" + ex.Message);
            }

        }
        public void adisyon_urun_birlestir(ListView adisyon,int masa_no)
        {
            baglan();
            SQLiteCommand komut = baglanti.CreateCommand();
            komut.CommandText = "select u.U_Ad,sum(a.Miktar),(U.U_bFiyat*sum(a.Miktar)) as 'Tutar',k.K_ad from Adisyon a  inner join Urun u on u.U_No=a.U_No inner join Kategori k on k.K_id=u.K_id  where a.M_No=@M_No group by a.U_No";
            komut.Parameters.AddWithValue("@M_No", masa_no);
            SQLiteDataReader veri = komut.ExecuteReader();
            adisyon.Items.Clear();
        
            while (veri.Read())
            {
                string[] elemanlar = { veri[0].ToString(), veri[3].ToString(), veri[1].ToString(), veri[2].ToString()+" ₺"};

                ListViewItem veriler = new ListViewItem(elemanlar);

                adisyon.Items.Add(veriler);
            }


        }
        #endregion   //Program Başlangıç Ayarlarının Bitişi


    }

}