namespace ConsoleApp1;

public abstract class Creature
{
    public string Name  { get; init; } = "NoName";

    private int level = 1;
    public int Level
    {
        get => level;
        set => level = value > 0 ? value : 1;
    }
    public string Info => $"{Name} [{Level}]";
    public Creature(string name, int level)
    {
        Name = name;
        Level = level;
    }
    public Creature() { }


    public abstract void SayHi();

    public static void Slogan() => Console.WriteLine("Creatures are great!");

}

