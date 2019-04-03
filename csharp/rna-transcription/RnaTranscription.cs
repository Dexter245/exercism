using System;
using System.Collections.Generic;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        Dictionary<char, char> dict = new Dictionary<char, char>();
        dict.Add('G', 'C');
        dict.Add('C', 'G');
        dict.Add('T', 'A');
        dict.Add('A', 'U');
        char[] input = nucleotide.ToCharArray();
        char[] output = new char[input.Length];
        for(int i = 0; i < input.Length; i++)
        {
            output[i] = dict[input[i]];
        }
        return new string(output);
    }
}