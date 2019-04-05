using System;

public class PhoneNumber
{

    static void Main(string[] args)
    {
        string str = "(023) 456-7890";
        string str2 = Clean(str);
        Console.WriteLine("before: " + str);
        Console.WriteLine("after: " + str2);
        Console.ReadLine();
    }

    public static string Clean(string phoneNumber)
    {
        for(int i = 0; i < phoneNumber.Length; i++)
        {
            if (!Char.IsNumber(phoneNumber[i]))
            {
                phoneNumber = phoneNumber.Remove(i, 1);
                i--;
            }
        }
        if (phoneNumber.Length < 10 || phoneNumber.Length > 11)
            throw new ArgumentException();
        if(phoneNumber.Length == 11)
        {
            if(phoneNumber[0] != '1')
                throw new ArgumentException();
            else
            {
                phoneNumber = phoneNumber.Remove(0, 1);
            }
        }
        Console.WriteLine("first digit: " + phoneNumber[0]);
        if(int.Parse(phoneNumber.Substring(0, 1)) < 2 || int.Parse(phoneNumber.Substring(3, 1)) < 2)
        {
            Console.WriteLine("bla");
            throw new ArgumentException();
        }

        return phoneNumber;
    }
}