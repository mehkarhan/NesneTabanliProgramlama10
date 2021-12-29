using System;

namespace _29122021_DizilerArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ogrenci1 = "Pelin AYDIN";
            //string ogrenci2 = "Nuriye Nur KAYAOĞLU";
            //string ogrenci3 = "CerenU";
            //string ogrenci4 = "Mehmet";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci4);
            //Console.WriteLine(ogrenci3);

            string[] ogrenci = new string[3];   // 1.tanımlama
            ogrenci[0] = "Pelin AYDIN";
            ogrenci[1] = "Mehmet K";
            ogrenci[2] = "Nuriye Nur";
            //ogrenci[3] = "KARAHAN";
            //Console.WriteLine(ogrenci[2]);

            string[] ogretmen = {"Nihat","Pınar","Mehmet","Ümit","Uğur","Nuriye" }; //2.tanımlama
            //Console.WriteLine(ogretmen[3]);

            string[] alan = new string[] {"Bilişim","Yiyecek","Grafik","Çocuk Gelişimi","Giyim","Kuaför" }; //3.tanımlama

            int[] ogrNo = {20076,20077,19045}; //int türü tanımlama

            bool[] dogrumu = { true, false};   // bool veri tipi
            double[] ondalikli = { 3.14, 5.25 }; // ondalikli sayı tipi

            foreach (var o in ogrenci) //dizi elemanlarını yazdırma
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("****Okulumuzdaki Alanlar*******");

            foreach (var item in alan)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****Bilişim Alanı Öğretmenleri*******");
            foreach (var item in ogretmen)
            {
                Console.WriteLine(item);
            }
        }
    }
}
