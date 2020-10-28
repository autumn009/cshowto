using System;

class Program
{
    static void Main()
    {
        // 結果が6 7 であって欲しいとき
        for (int i = 0; i < 9; i++)
        {
            if (i > 5) if (i > 7) continue; else Console.Write($"{i} ");
        }
        Console.WriteLine();
        // 結果が0 1 2 3 4 5 であって欲しいとき
        for (int i = 0; i < 9; i++)
        {
            if (i > 5) { if (i > 7) continue; } else Console.Write($"{i} ");
        }
        Console.WriteLine();
    }
}
