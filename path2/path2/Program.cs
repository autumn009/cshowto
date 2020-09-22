using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] ar = { "a", "b", "c" };
        // 正攻法
        var path1 = Path.Combine(ar[0], ar[1], ar[2]);
        Console.WriteLine($"path1={path1}");
        // これでもいける
        var path2 = Path.Combine(ar);
        Console.WriteLine($"path2={path2}");
    }
}
