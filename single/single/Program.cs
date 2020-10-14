using System;
using System.Linq;

class Program
{
    private static void CheckSingle1(int[] ar)
    {
        foreach (var item in ar) Console.Write($"{item} ");
        int c = ar.Count(c => c == 1);
        if (c == 0)
            Console.WriteLine("に1はありません。");
        else if (c == 1)
            Console.WriteLine("に1は1つだけあります。");
        else
            Console.WriteLine("に1は2個以上です。");
    }
    private static void CheckSingle2(int[] ar)
    {
        foreach (var item in ar) Console.Write($"{item} ");
        try
        {
            int r = ar.SingleOrDefault(c => c == 1);
            if (r == 0)
                Console.WriteLine("に1はありません。");
            else if (r == 1)
                Console.WriteLine("に1は1つだけあります。");
            else
                Console.WriteLine("不明です。");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("に1は2個以上です。");
        }
    }
    private static void CheckSingle3(int[] ar)
    {
        foreach (var item in ar) Console.Write($"{item} ");
        try
        {
            ar.Single(c => c == 1);
            Console.WriteLine("に1は1つだけあります。");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("に1は無いか2個以上です。");
        }
    }
    static void Main()
    {
        int[] ar1 = { 2, 2, 3 };
        int[] ar2 = { 1, 2, 3 };
        int[] ar3 = { 1, 2, 1 };
        CheckSingle1(ar1);
        CheckSingle1(ar2);
        CheckSingle1(ar3);
        CheckSingle2(ar1);
        CheckSingle2(ar2);
        CheckSingle2(ar3);
        CheckSingle3(ar1);
        CheckSingle3(ar2);
        CheckSingle3(ar3);
    }
}
