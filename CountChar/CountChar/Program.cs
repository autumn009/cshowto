using System;
using System.Linq;

class Program
{
    private static void CountIt(string s)
    {
        // 方法1・LINQを使う
        var n1 = s.Count(c => c == 'A');
        // 方法2・IndexOfを繰り返す
        var idx = 0;
        var n2 = 0;
        for (; ; )
        {
            idx = s.IndexOf('A', idx + 1);
            if (idx <= 0) break;
            n2++;
        }
        // 方法3・単純ループ
        var n3 = 0;
        foreach (var item in s) if (item == 'A') n3++;
        // 方法4・Where+Count
        var n4 = s.Where(c => c == 'A').Count();

        Console.WriteLine($"{s}にAは{n1}個含まれています。");
        Console.WriteLine($"{s}にAは{n2}個含まれています。");
        Console.WriteLine($"{s}にAは{n3}個含まれています。");
        Console.WriteLine($"{s}にAは{n4}個含まれています。");
    }

    static void Main()
    {
        CountIt("KAWAMATA");
        CountIt("MEITANTEI CONAN");
        CountIt("KAMADO TANJIRO");
    }
}
