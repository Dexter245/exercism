using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> list;
    private List<int> top3;
    private int latest;
    private int best;

    public HighScores(List<int> list)
    {
        this.list = new List<int>(list);
        this.latest = list[list.Count-1];
        List<int> sorted = new List<int>(this.list);
        sorted.Sort();
        this.best = sorted[sorted.Count - 1];
        this.top3 = new List<int>();
        System.Console.WriteLine("a");
        for(int i = sorted.Count-1; i >= 0; i--)
        {
            System.Console.WriteLine("ba");
            this.top3.Add(sorted[i]);
        }
    }

    public static void Main(string[] args)
    {
        HighScores highScores = new HighScores(new List<int>() { 1, 2, 3 });
        for(int i = 0; i < highScores.Scores().Count; i++)
        {
            System.Console.WriteLine("score: " + highScores.Scores()[i]);
        }
        System.Console.WriteLine("best: " + highScores.PersonalBest());
        System.Console.WriteLine("scores: " + highScores.Scores().ToString());
        List<int> best3 = highScores.PersonalTopThree();
        System.Console.WriteLine("best3 count: " + best3.Count);
        for(int i = 0; i < best3.Count; i++)
        {
            System.Console.WriteLine("best3: " + best3[i]);
        }
        System.Console.ReadLine();
    }

    public List<int> Scores()
    {
        return list;
    }

    public int Latest()
    {
        return latest;
    }

    public int PersonalBest()
    {
        return best;
    }

    public List<int> PersonalTopThree()
    {
        return top3;
    }
}