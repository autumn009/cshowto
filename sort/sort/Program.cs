using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static void sort1(List<int> list)
    {
        list.Sort();
    }

    private static void sort2(List<int> list)
    {
        list = list.OrderBy(c => c).ToList();
    }

    private static void sort3(ref List<int> list)
    {
        list = list.OrderBy(c => c).ToList();
    }


    static void Main()
    {
        var list1 = new List<int>() { 1, 4, 2, 3 };
        sort1(list1);
        foreach (var item in list1) Console.Write(item);
        Console.WriteLine();

        var list2 = new List<int>() { 1, 4, 2, 3 };
        sort2(list2);
        foreach (var item in list2) Console.Write(item);
        Console.WriteLine();

        var list3 = new List<int>() { 1, 4, 2, 3 };
        sort3(ref list3);
        foreach (var item in list3) Console.Write(item);
        Console.WriteLine();
    }
}
