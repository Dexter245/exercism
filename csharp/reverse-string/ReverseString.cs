using System;

public static class ReverseString
{

    static void Main(string[] args)
    {
        string str1 = "asdf";
        string str2 = Reverse(str1);
        Console.WriteLine(str1 + ": " + str2);
        Console.ReadLine();
    }

    public static string Reverse(string input)
    {
        char[] text = input.ToCharArray();
        char[] reversed = new char[text.Length];
        for(int i = 0; i < text.Length; i++)
        {
            reversed[i] = text[text.Length - i - 1];
        }
        return new string(reversed);
    }
}