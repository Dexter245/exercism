using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
            throw new ArgumentException("asdf");
        char[] first = firstStrand.ToCharArray();
        char[] second = secondStrand.ToCharArray();
        int dist = 0;
        for(int i = 0; i < first.Length; i++)
        {
            if (first[i] != second[i])
                dist++;
        }
        return dist;
    }
}