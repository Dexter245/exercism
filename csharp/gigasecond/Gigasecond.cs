using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        System.Console.WriteLine("Time before: " + moment.Ticks);
        moment = moment.AddSeconds(1000000000.0);
        System.Console.WriteLine("Time after: " + moment.Ticks);
        return moment;
    }

    public static void Main(string[] args)
    {
        System.Console.WriteLine("main");
        System.Console.ReadLine();
    }
}