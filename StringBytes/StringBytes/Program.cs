using System;
using System.Text;

class Program
{
    static void Main()
    {
        var s = "Hella World";
        Console.WriteLine(s);
        var array = Encoding.UTF8.GetBytes(s);
        foreach (var item in array) Console.Write($"{item} ");
        Console.WriteLine();
        array[4] = 111;
        foreach (var item in array) Console.Write($"{item} ");
        Console.WriteLine();
        var d = Encoding.UTF8.GetString(array);
        Console.WriteLine(d);
    }
}


