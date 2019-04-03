using System;
using System.Collections.Generic;

public static class ScrabbleScore
{

//Letter                           Value
//A, E, I, O, U, L, N, R, S, T       1
//D, G                               2
//B, C, M, P                         3
//F, H, V, W, Y                      4
//K                                  5
//J, X                               8
//Q, Z                               10

    public static int Score(string input)
    {
        input = input.ToLower();
        Dictionary<string, int> points = new Dictionary<string, int>();
        points.Add("aeioulnrst", 1);
        points.Add("dg", 2);
        points.Add("bcmp", 3);
        points.Add("fhvwy", 4);
        points.Add("k", 5);
        points.Add("jx", 8);
        points.Add("qz", 10);
        int score = 0;
        foreach(var c in input)
        {
            foreach(var s in points.Keys)
            {
                if (s.Contains(c))
                {
                    score += points[s];
                }
            }
        }
        return score;
    }
}