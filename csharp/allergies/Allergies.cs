using System;

[Flags]
public enum Allergen : int
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private static int EveryAllergy = 255;
    private readonly int mask;

    static void Main(string[] args)
    {
        Allergies a1 = new Allergies(1);
        a1.IsAllergicTo(Allergen.Eggs);
        Console.ReadLine();
    }

    public Allergies(int mask)
    {
        this.mask = mask & EveryAllergy;
        Console.WriteLine("eggs: " + (int) Allergen.Eggs);
        Console.WriteLine("shellfish: " + (int) Allergen.Shellfish);
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        Console.WriteLine("mask: " + mask);
        Console.WriteLine("allergen: " + (int) allergen);
        Console.WriteLine("&: " + (mask & (int) allergen));
        return (mask & (int)allergen) > 0;
    }

    public Allergen[] List()
    {
        Allergen[] list = new Allergen[8];
        Enum.Parse(mask);
        for(int i = 0; i < 8; i++)
        {
            //if (((int)Math.Pow(2, i) & mask) > 0)
        }

        return list;
    }
}