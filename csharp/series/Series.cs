using System;

public static class Series
{

    static void Main(string[] args)
    {
        Slices("1234", 2);
        Console.ReadLine();
    }

    public static string[] Slices(string numbers, int sliceLength)
    {
        if(sliceLength <= 0 || sliceLength > numbers.Length || numbers.Equals(""))
        {
            throw new ArgumentException();
        }

        string[] slices = new string[numbers.Length - sliceLength + 1];

        for(int i = 0; i < numbers.Length - sliceLength + 1; i++)
        {
            string substr = numbers.Substring(i, sliceLength);
            Console.WriteLine(substr);
            slices[i] = substr;
        }

        return slices;
    }
}