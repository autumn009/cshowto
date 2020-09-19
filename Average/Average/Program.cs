using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 整数の配列
        int[] ar = { 1, 2, 3, 4 };
        // 実はavgはdouble型
        var avg = ar.Average();
        Console.WriteLine($"Avarage is {avg}");
    }
}
