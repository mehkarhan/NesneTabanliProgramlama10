using System;

namespace _22122021_Alanlar_Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o = new Ogrenci();
            o.ogrenci1 = "Ceren Zümra UZ";
            o.ogrenci2 = "Pelin AYDIN";
            o.ogrenci3 = "Kübra YILDIRIM";
            o.ogrenci4 = "İrem KÖKNEL";
            o.ogrenci5 = "Deren Azra UZ";
            o.ogrenci6 = "Şevin YILDIRIM";
            o.ogrenci7 = "Hüsnanur BUYUK";
            o.ogrenci8 = "Nuriye Nur KAYAOĞLU";
            
            Bilisim b = new Bilisim();
            b.Alan1 = "Yazılım Alanı";
            b.Alan2 = "Ağ Sistemleri ve Siber Güvenlik Alanı";

            Console.WriteLine(b.Alan1);
            Console.WriteLine(o.ogrenci8);
            Console.WriteLine(o.ogrenci4+" isimli öğrencinin alanı:"+b.Alan1);
            
    }
    }
    class Ogrenci
    {
        public string ogrenci1;
        public string ogrenci2;
        public string ogrenci3;
        public string ogrenci4;
        public string ogrenci5;
        public string ogrenci6;
        public string ogrenci7;
        public string ogrenci8;
        
    }
    class Bilisim
    {
        public string Alan1;
        public string Alan2;
    
    }
   
}
