using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = 0;
        for(int i = 0; i <= max; i++)
        {
            sum += i;
        }
        sum *= sum;
        return sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sum = 0;
        for(int i = 0; i <= max; i++)
        {
            sum += i * i;
        }
        return sum;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return Math.Abs(CalculateSquareOfSum(max) - CalculateSumOfSquares(max));
    }
}