using System;

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

