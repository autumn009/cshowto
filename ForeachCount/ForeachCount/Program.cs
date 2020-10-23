using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] names = { "熱海", "斑鳩", "宇野" };

        foreach (var item in names.Select((name, number) => new { name, number }))
        {
            Console.WriteLine($"{item.number + 1} {item.name}");
        }
    }
}
