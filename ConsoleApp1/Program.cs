namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        /* Creature c = new Creature("Shrek", 17) { Name = "Donkey"};

        c.SayHi();

        Creature.Slogan();

        c = new() { Name = "Fiona", Level = 5 }; */ // Abstrakcja nie pozwala na wykonanie Obiektu tej klasy jedynie Orc oraz Elf

        /* Console.WriteLine(c.Name);
        c.Level++;
        Console.WriteLine(c.Level);
        Console.WriteLine(c.Info); */


        /*Elf legolas = new() { Name = "Legolas", Agility = 3 };
        legolas.SayHi();
        Console.WriteLine($"{legolas.Name} - agility {legolas.Agility}");
        legolas.Sing();*/

        Orc gorbag = new("Gorbag", 4, 6);
        gorbag.Hunt();

        Creature e = new Elf("Legolas");
        e.SayHi();
        Creature o = new Orc("Gorbag");
        o.SayHi();

    }
}
