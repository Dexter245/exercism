﻿using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number <= 0)
            throw new ArgumentException();

        int steps = 0;
        while(number != 1)
        {
            if(number % 2 == 0)//even
            {
                number /= 2;
            }
            else//odd
            {
                number = 3 * number + 1;
            }
            steps++;
        }
        return steps;
    }
}