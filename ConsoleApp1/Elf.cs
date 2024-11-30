namespace ConsoleApp1;

public class Elf : Creature
{
    public int Agility { get; set; } = 1;
    public void Sing() => Console.WriteLine($"{Name} is singing.");

    public Elf(string name, int level = 1, int agility = 1) : base(name, level)
    {
        Agility = agility;
    }

    public override void SayHi() => Console.WriteLine(
    $"Hi, I'm {Name}, my level is {Level}, my agility is {Agility}."
);
}
