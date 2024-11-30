namespace ConsoleApp1;

public class Orc : Creature
{
    public int Rage { get; set; } = 1;
    public void Hunt() => Console.WriteLine($"{Name} is hunting.");

    public Orc(string name, int level = 1, int rage = 1) : base(name, level)
    {
        Rage = rage;
    }
    public override void SayHi() => Console.WriteLine(
    $"Hi, I'm {Name}, my level is {Level}, my rage is {Rage}."
);
}