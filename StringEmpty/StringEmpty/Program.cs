using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine(Enumerable.Empty<string>().Count());
        Console.WriteLine(string.Empty.Count());
    }
}
