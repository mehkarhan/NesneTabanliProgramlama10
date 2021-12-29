using System;

namespace _22122021_Metodlar
{
    class Program //metodlar sınıflar-class içinde olmalıdır.
    {
        static void Main(string[] args)
        {
            EkranaYaz();
            Console.WriteLine(Toplaa());
            Console.WriteLine(Toplaa(13,15,17));
            Console.WriteLine(Toplaa(13,15,17,18));
            //Console.WriteLine(Topla(13,15,17,18,19));
            Console.WriteLine(Toplaa(1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11));
        }

        //main metodu dışında tanımlarız.
        static void EkranaYaz()
        {
            Console.WriteLine("Merhaba 10-A Bilişim....");
        }
        
        static int Toplaa(params int[] sayilar) //çok parametreli işlemlerde kullanımı
        {
            if (sayilar.Length==0)
            {
                Console.Write("Parametre yoktur. Sonuç: ");
                return 0;
            }
            
            int toplam = 0; 
            foreach (var item in sayilar)
            {
                toplam = toplam + item;
            }
            return toplam;
        }
    }
}
