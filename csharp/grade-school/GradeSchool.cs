using System;
using System.Collections.Generic;

public class GradeSchool
{
    private SortedList<int, List<string>> grades = new SortedList<int, List<string>>();

    static void Main(string[] args)
    {
        GradeSchool gs = new GradeSchool();
        gs.Add("bla", 2);
        Console.WriteLine("grade 2: " + gs.Grade(2));
        Console.WriteLine("all grades: " + gs.Roster());
        Console.ReadLine();
    }

    public void Add(string student, int grade)
    {
        if (!grades.ContainsKey(grade))
            grades.Add(grade, new List<string>());
        grades[grade].Add(student);
        grades[grade].Sort();
    }

    public IEnumerable<string> Roster()
    {
        List<string> roster = new List<string>();
        foreach(var grade in grades)
        {
            foreach(var student in grade.Value)
            {
                roster.Add(student);
            }
        }
        //roster.Sort();
        return roster;
    }

    public IEnumerable<string> Grade(int grade)
    {
        if (!grades.ContainsKey(grade))
            return new List<string>();
        else
            return grades[grade];
    }
}