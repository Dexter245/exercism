using System;

public static class Pangram
{

    static void Main(string[] args)
    {
        IsPangram("abcd ");
        Console.ReadLine();
    }

    public static bool IsPangram(string input)
    {
        char[] chars = input.ToLower().ToCharArray();
        bool[] exists = new bool[26];
        foreach(var c in chars)
        {
            int index = ((int)c) - 97;
            if (index < 0 || index >= 26)
                continue;
            Console.WriteLine("char: " + c + ", index: " + index);
            exists[index] = true;
        }

        foreach(var b in exists)
        {
            if (!b)
                return false;
        }

        return true;
    }
}
