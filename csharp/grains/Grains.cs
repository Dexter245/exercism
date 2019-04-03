using System;

public static class Grains
{

    static void Main(string[] args)
    {
        Console.WriteLine("total: " + Total());
        Console.ReadLine();
    }

    public static ulong Square(int n)
    {
        if (n <= 0 || n > 64)
            throw new ArgumentOutOfRangeException();
        return (ulong) Math.Pow(2, n-1);
    }

    public static ulong Total()
    {
        ulong sum = 0L;
        for (int i = 1; i <= 64; i++)
        {
            sum += Square(i);
        }
        return sum;
    }
}