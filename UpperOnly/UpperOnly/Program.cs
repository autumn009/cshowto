using System;

class Program
{
    static void Main()
    {
        var s = "Jack Knife";
        foreach (var item in s)
        {
            if (Char.IsUpper(item)) Console.Write(item);
        }
        Console.WriteLine();
    }
}
