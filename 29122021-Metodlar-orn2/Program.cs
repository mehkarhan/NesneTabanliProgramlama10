using System;

namespace _29122021_Metodlar_orn2
{
    class Program
    {   //Parametresinde verilen sayının değeri tek ise true,
        //çift ise false döndüren metodu yazınız.
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int sayi = 26;
            Console.WriteLine(TekCift(sayi));
            //Console.WriteLine(TekCift()); 
            Console.WriteLine(TekCift(11));
            Console.WriteLine(TekCift());
            

        }
        static bool TekCift(int a=19)  //Varsayılan Parametre ile Kullanımı
        {
            if (a%2==1)
            {
                return true;
            }
            else
            {
                return false;   
            }

           
        }

    }
    
}
