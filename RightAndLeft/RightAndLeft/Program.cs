using System;

class Program
{
    static void Main()
    {
        int x = 12324;
        Console.WriteLine("6文字幅で右に揃えろ");
        Console.WriteLine($"[{x,6}]");
        Console.WriteLine("6文字幅で左に揃えろ");
        Console.WriteLine($"[{x,-6}]");
    }
}

