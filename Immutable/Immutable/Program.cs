using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 不変のオブジェクトの例
        var s1 = "hello!";
        // ↓書けない
        //s1[1] = 'H';
        Console.WriteLine(s1);

        // 可変のオブジェクトの例
        var list = new List<int>();
        list.Add(123);
        foreach (var item in list) Console.Write($"{item} ");
        Console.WriteLine();
        list[0] = 456;
        list.Add(789);
        foreach (var item in list) Console.Write($"{item} ");
        Console.WriteLine();

        // 一部可変のオブジェクトの例
        int[] array = { 123 };
        foreach (var item in array) Console.Write($"{item} ");
        Console.WriteLine();
        array[0] = 456;
        // ↓書けない
        //array.Add(789);
        foreach (var item in array) Console.Write($"{item} ");
        Console.WriteLine();
    }
}
