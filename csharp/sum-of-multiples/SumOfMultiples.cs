using System;
using System.Collections.Generic;

public static class SumOfMultiples
{

    static void Main(string[] args)
    {
        int res = SumOfMultiples.Sum(new[] { 0 }, 1);
        Console.WriteLine("res: " + res);
        Console.ReadLine();
    }

    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int sum = 0;
        for(int i = 0; i < max; i++)
        {
            foreach(var m in multiples)
            {
                if(m != 0 && i % m == 0)
                {
                    sum += i;
                    break;
                }
            }
        }
        return sum;
    }
}