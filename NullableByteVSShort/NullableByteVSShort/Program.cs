using System;

class Program
{
    private static T[] sub<T>(string label, bool output)
    {
        long start = Environment.WorkingSet;
        T[] array = new T[100000];
        if (output) Console.WriteLine($"{label} {Environment.WorkingSet - start}");
        return array;
    }


    static void Main()
    {
        // 安定するまで待つ
        sub<byte?>("byte?", false);
        sub<short>("short", false);
        // テスト実行
        sub<byte?>("byte?", true);
        sub<short>("short", true);
    }
}
