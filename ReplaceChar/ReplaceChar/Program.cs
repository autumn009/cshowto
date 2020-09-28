using System;

class Program
{
    static void Main()
    {
        var s = "斉藤家の3男";
        Console.WriteLine($"元文字列: {s}");
        Console.WriteLine($"何人目の男の子?　{s[4]}");
        s = s.Substring(0, 4) + "4" + s.Substring(5);
        Console.WriteLine($"3→4修正後: {s}");
    }
}
