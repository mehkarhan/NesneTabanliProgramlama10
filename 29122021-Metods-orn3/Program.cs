using System;

namespace _29122021_Metods_orn3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int topla1 = Topla(25, 10, 15);
            Console.WriteLine(topla1);
            Console.WriteLine("********");
            int topla2 = Topla(sayi3:15, sayi1:25, sayi2:10); //isimlendirilmiş parametre kullanımı
            Console.WriteLine(topla2);
            

        }
        static int Topla(int sayi1,int sayi2,int sayi3) 
        {
            return sayi1 + sayi2 + sayi3;
            
        }
    }
}
