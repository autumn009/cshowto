using System;

class Program
{
    private static T[] sub<T>(string label)
    {
        long start = GC.GetTotalMemory(true);
        T[] array = new T[1000000];
        Console.WriteLine($"{label} {GC.GetTotalMemory(true) - start}");
        return array;
    }

    static void Main()
    {
        sub<byte?>("byte?");
        sub<short>("short");
        sub<short?>("short?");
        sub<int>("int");
        sub<int?>("int?");
        sub<long>("long");
    }
}
