using System;

class Program
{
    static void Main()
    {
        var s1 = "\\{1 + 2}";
        var s2 = @"\\{1 + 2}";
        var s3 = $"\\{1 + 2}";
        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
    }
}
