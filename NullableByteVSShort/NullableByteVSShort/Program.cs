using System;

class Program
{
    private static T[] sub<T>(string label)
    {
        long start = Environment.WorkingSet;
        T[] array = new T[100000];
        Console.WriteLine($"{label} {Environment.WorkingSet - start}");
        return array;
    }


    static void Main()
    {
        sub<byte?>("byte?");
        sub<short>("short");
    }
}
