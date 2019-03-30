using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        int[] numbers;
        char[] ctext = text.ToCharArray();
        int blob = ctext[0];
        System.Console.WriteLine("ctext[0]: " + ctext[0] + ", blob: " + blob);

        return "";
    }

    public static void Main(string[] args)
    {
        Rotate("asdf", 1);
        System.Console.ReadLine();
    }
}