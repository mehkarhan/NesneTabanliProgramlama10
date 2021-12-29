using System;

namespace ConsoleApp1
{
    
    class Program
    {

        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //Console.WriteLine(rnd.Next(2000,2100));

            //Bilisim husnanurBuyuk = new Bilisim();
            Dikdortgen dikdortgen = new Dikdortgen(10, 20);
            int alan = dikdortgen.AlanHesapla();
            int cevre = dikdortgen.CevreHesapla();

            Console.WriteLine("Dikdortgenin Alanı:" + alan);
            Console.WriteLine("Dikdortgenin Cevresi:" + cevre);

            Daire daire = new Daire(20,3);
            Console.WriteLine("Dairenin Alanı:" + daire.DaireAlan());
            Console.WriteLine("Dairenin Çevresi:"+daire.DaireCevre());


            
    }
    }
    public class Dikdortgen
    {
        private int a, b;
        public Dikdortgen(int x, int y)
        {
            this.a = x;
            this.b = y;
        }
        public int AlanHesapla()
        {
            return a * b;
        }
        public int CevreHesapla()
        {
            return 2 * (a + b);

        }
    }
    class Daire
    {
        private double yariCap, pi;
        public Daire(double x, double y)
        {
            this.yariCap = x;
            this.pi = y;
        }
        public double DaireAlan()
        {
            return pi * yariCap * yariCap;
        }

        public double DaireCevre()
        {
            return 2 * pi * yariCap;
        }
    }
}
