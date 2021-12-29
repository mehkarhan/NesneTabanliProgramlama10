using System;

namespace ClassİlkDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen(2, 5);
        }
    }
    class Ucgen
    {
        private int a, b;
        public Ucgen(int taban,int yukseklik)
        {
            this.a = taban;
            this.b = yukseklik;
        }
    }


}
