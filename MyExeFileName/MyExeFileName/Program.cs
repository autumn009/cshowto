using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        var fileName = Assembly.GetExecutingAssembly().Location;
        Console.WriteLine(fileName);
    }
}
