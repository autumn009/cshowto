using System;
using System.Linq;

class Program
{
    private static double calc1(int[] ar)
    {
        var start = DateTimeOffset.Now;
        double sum = 0;
        for (int i = 0; i < 10000; i++) sum += ar.Average();
        Console.WriteLine(DateTimeOffset.Now - start);
        return sum;
    }

    private static double calc2(int[] ar)
    {
        var start = DateTimeOffset.Now;
        double sum = 0;
        for (int i = 0; i < 10000; i++)
        {
            int s = 0;
            foreach (var item in ar) s += item;
            sum += ((double)s / (double)ar.Length);
        }
        Console.WriteLine(DateTimeOffset.Now - start);
        return sum;
    }

    static void Main()
    {
        int[] ar = Enumerable.Range(0, 100000).ToArray();
        calc1(ar);
        calc2(ar);
    }
}
