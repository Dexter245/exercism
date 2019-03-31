using System;

public static class RotationalCipher
{

    public static void Main(string[] args)
    {
        Console.WriteLine("in: " + "asdf" + ", out1: " + Rotate("asdf", 1));
        System.Console.ReadLine();
    }

    public static string Rotate(string text, int shiftKey)
    {
        char[] chars = text.ToCharArray();
        string shifted = "";
        foreach(char c in chars)
        {
            int d = (int)c;
            if(Char.IsLetter(c))
            {
                if (Char.IsUpper(c))
                {
                    d = (((d - 65) + shiftKey) % 26) + 65;
                }
                else
                {
                    d = (((d - 97) + shiftKey) % 26) + 97;
                }
            }
            shifted = shifted + (char)d;
        }
        return shifted;
    }

}