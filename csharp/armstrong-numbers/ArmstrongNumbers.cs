using System;

public static class ArmstrongNumbers
{

    static void Main(string[] args)
    {
        int number = 54687;
        Console.WriteLine("number: " + number);
        IsArmstrongNumber(number);
        Console.ReadLine();
    }

    public static bool IsArmstrongNumber(int number)
    {
        int len = (int) Math.Log10(number) + 1;
        Console.WriteLine("len: " + len);
        int[] digits = new int[len];
        int num = number;
        for(int i = 0; i < digits.Length; i++)
        {
            digits[i] = num % 10;
            num /= 10;
        }
        Console.WriteLine("digits: ");
        foreach(var v in digits)
        {
            Console.WriteLine(v);
        }
        int sum = 0;
        foreach(var v in digits)
        {
            sum += (int) Math.Pow(v, len);
        }

        return sum == number;
    }
}