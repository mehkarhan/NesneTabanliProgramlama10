using System;

namespace _22122021_Class_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.AdiSoyadi = "Ceren USTAOĞLU";
            ogrenci1.FavoriRenk = "Siyah";
            ogrenci1.Adres = "Hürriyet Mah.";
            ogrenci1.OgrNo = 20116;

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.AdiSoyadi = "Maviş KANARYA";
            ogrenci2.FavoriRenk = "Mavi";
            ogrenci2.Adres = "Kafes Mah.";

            Console.WriteLine(ogrenci1.AdiSoyadi);
            Console.WriteLine(ogrenci1.OgrNo);

            Console.WriteLine("****************"  );

            Console.WriteLine(ogrenci2.AdiSoyadi);
            Console.WriteLine(ogrenci2.OgrNo);

            Bilisim dal1 = new Bilisim();
            dal1.BilisimAlan = "Yazılım";
            dal1.Ders1 = "Nesne Tabanlı Programlama";
            dal1.Ders2 = "Robotik Kodlama";
            Bilisim dal2 = new Bilisim();
            dal2.BilisimAlan = "Ağ Sistemleri ve Siber Güvenlik";
            dal2.Ders1 = "Ağ Sistemleri ve Anahtarlama";
            dal2.Ders2 = "Robotik Kodlama";

            Console.WriteLine(dal2.Ders2);
        }
    }

    class Ogrenci
    {
        public string AdiSoyadi { get; set; }
        public string FavoriRenk { get; set; }
        public string Adres { get; set; }
        public int OgrNo { get; set; }
    }
    class Bilisim
    {
        public string BilisimAlan { get; set; }
        public string Ders1 { get; set; }
        public string Ders2 { get; set; }
        

    }
    
}
