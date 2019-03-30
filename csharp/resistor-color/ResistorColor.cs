using System;

public static class ResistorColor
{
    readonly static string[] colors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    public static int ColorCode(string color)
    {
        for(int i = 0; i < colors.Length; i++)
        {
            if (colors[i].Equals(color))
            {
                return i;
            }
        }

        return -1;
    }

    public static string[] Colors()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}