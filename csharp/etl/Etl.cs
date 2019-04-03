using System;
using System.Collections.Generic;

public static class Etl
{

    static void Main(string[] args)
    {
        Dictionary<int, string[]> bla = new Dictionary<int, string[]>();
        bla.Add(1, new string[] { "a", "b" });
        bla.Add(2, new string[] { "c", "d" });
        Transform(bla);
        Console.ReadLine();
    }

    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach(int value in old.Keys)
        {
            foreach(string letter in old[value])
            {
                Console.WriteLine("letter: " + letter + ", value: " + value);
                dict.Add(letter.ToLower(), value);
            }
        }

        return dict;
    }
}