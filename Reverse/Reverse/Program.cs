using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static void recursion(IEnumerable<int> e)
    {
        if (e.Count() > 0)
        {
            recursion(e.Skip(1));
            Console.Write(e.First());
        }
    }

    static void Main()
    {
        int[] ar = { 1, 2, 3 };
        // 方法1　ストレートfor
        for (int i = 0; i < ar.Length; i++)
        {
            Console.Write(ar[ar.Length-i-1]);
        }
        Console.WriteLine();
        // 方法2 リバースfor
        for (int i = ar.Length - 1; i >= 0; i--)
        {
            Console.Write(ar[i]);
        }
        Console.WriteLine();
        // 方法3 LINQ
        foreach (var item in ar.Reverse())
        {
            Console.Write(item);
        }
        Console.WriteLine();
        // 方法4 LINQ2
        for (int i = 0; i < ar.Length; i++)
        {
            Console.Write(ar.Skip(ar.Length-i-1).First());
        }
        Console.WriteLine();
        // 方法5 LINQ3
        IEnumerable<int> a = ar.ToArray();
        for (; ; ) 
        {
            if (a.Count() == 0) break;
            Console.Write(a.Last());
            a = a.Take(a.Count()-1);
        }
        Console.WriteLine();
        // 方法6 再帰
        recursion(ar);
        Console.WriteLine();
    }
}
