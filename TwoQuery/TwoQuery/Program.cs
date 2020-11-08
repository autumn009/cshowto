using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = { 2, 3, 5, 7, 11, 13, 17 };
        // メソッド形式
        var q1 = array.Where(c => c < 10).Select(c => c * c);
        // クエリ式
        var q2 = from c in array where c < 10 select c * c;
        foreach (var item in q1) Console.Write(item);
        Console.WriteLine();
        foreach (var item in q2) Console.Write(item);
        Console.WriteLine();
    }
}
