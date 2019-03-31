using System;

public class Clock
{
    private int minutes = 0;

    static void Main(string[] args)
    {
        Clock c1 = new Clock(-2, 40);
        Console.WriteLine("c1: " + c1);
        Console.ReadLine();
    }

    public Clock(int hours, int minutes)
    {
        this.minutes = hours * 60 + minutes;
        this.minutes = (this.minutes%1440 + 1440)% 1440;
        Console.WriteLine("minutes: " + minutes);
    }

    public int Hours
    {
        get
        {
            Console.WriteLine("minutes/60: " + minutes/60);
            return minutes / 60;
        }
    }

    public int Minutes
    {
        get
        {
            return minutes % 60;
        }
    }

    public Clock Add(int minutesToAdd)
    {
        Clock c = new Clock(0, minutes + minutesToAdd);
        return c;
        minutes += minutesToAdd;
        minutes = minutes % 1440;
        return this;
    }

    public Clock Subtract(int minutesToSubtract)
    {
        Clock c = new Clock(0, minutes - minutesToSubtract);
        return c;
        minutes -= minutesToSubtract;
        minutes = minutes % 1440;
        return this;
    }

    public override string ToString()
    {
        string s = "";
        s += String.Format("{0,2:D2}:{1,2:D2}", Hours, Minutes);
        return s;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        return GetHashCode().Equals(obj.GetHashCode());
    }

    public override int GetHashCode()
    {
        return minutes;
    }
}