using System;

public static class Acronym
{

    static void Main(string[] args)
    {
        Abbreviate("Something - I made up from thin air");
        Console.ReadLine();
    }

    public static string Abbreviate(string phrase)
    {
        var parts = phrase.Split(new char[]{' ', '-', '_'});
        Console.WriteLine("parts: ");
        string res = "";
        foreach (var p in parts)
        {
            Console.WriteLine(p);
            if(p.Length > 0)
                res += p.ToUpper()[0];
        }
        Console.WriteLine("res: " + res);
        return res;
    }
}