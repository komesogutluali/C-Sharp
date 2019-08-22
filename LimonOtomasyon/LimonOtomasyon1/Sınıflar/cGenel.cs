using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;


namespace LimonOtomasyon1.Sınıflar
{
    public class cGenel
    {
        public static  int genislik { get; set; }
        public static  int yukseklik { get; set; }
        public static bool menu_acikmi { get; set; }
        public static string program_adresi { get; set; }

        //Personel şifresini başarı ile girip girmediğini kontrol etmek için kullanıyoruz. (personel_giris formunda)
        public static bool personel_girisi { get; set; }
        public static string yonetici_eposta = "iletisim@hasaneksi.net";
        //Masa Kapatıldı Mı ? - Masa Kapatma sayfasının onay kısımı
        public static bool hesap_odendi { get; set; }
        //Hangi personel işlem yapıyor öğrenmek için kullanıyoruz.
        public static int personel_no { get; set; }
        //Yönetici Nosuna her yerden erişebilmek için kullanıyoruz.
        public static int yonetici_no { get; set; }
        /*Giriş yapılan ekrandan personel mi yoksa yönetici mi giriş yaptığını görmek için aşağıdaki değişkeni kullanıyoru.z*/
        public static bool kim_girisyapti { get; set; } // true = yonetici | false = personel
    
    }

}
