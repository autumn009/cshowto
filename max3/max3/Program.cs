using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static IEnumerable<T> createEnum<T>(params T[] p) => p;

    static void Main()
    {
        // 比較する値
        int a = 1234;
        int b = 999;
        int c = 4949;
        // 方法1 Math.Max利用
        int max1 = Math.Max(a, Math.Max(b, c));
        Console.WriteLine($"{a}と{b}と{c}の最大値は{max1}");
        // 方法2 LINQ利用
        int max2 = new int[] { a, b, c }.Max();
        Console.WriteLine($"{a}と{b}と{c}の最大値は{max2}");
        // 方法3 LINQ+サービスメソッド利用
        int max3 = createEnum(a, b, c).Max();
        Console.WriteLine($"{a}と{b}と{c}の最大値は{max3}");
    }
}
