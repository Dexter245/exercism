using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string str = "";
        if(number % 3 == 0 || number % 5 == 0 || number % 7 == 0)
        {
            if (number % 3 == 0)
                str += "Pling";
            if (number % 5 == 0)
                str += "Plang";
            if (number % 7 == 0)
                str += "Plong";
        }
        else
        {
            str = "" + number;
        }
        return str;
    }
}