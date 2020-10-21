using System;

class Program
{
    static void Main()
    {
        var tgt = 4649;
        // 方法1・文字列法
        var s1 = tgt.ToString();
        var width1 = s1.Length;
        Console.WriteLine($"{tgt}は{width1}桁です。");
        // 方法2・数値計算法
        var width2raw = Math.Log10(tgt);
        var width2 = Math.Ceiling(width2raw);
        Console.WriteLine($"{tgt}は{width2}桁です。(切り上げ前は{width2raw}です)");
    }
}
