using System;

class Program
{
    private static void sub(string label, Func<int, int, int> calc)
    {
        Console.WriteLine($"123と45の{label}の結果は{calc(123, 45)}です。");
    }

    static void Main()
    {
        sub("足し算", (x, y) => x + y);
        sub("引き算", (x, y) => x - y);
        sub("特殊条件計算", (x, y) =>
        {
            for (int i = 0; i < y; i++)
            {
                x += (int)(Math.Sin((double)i / (double)y) * 100);
            }
            return x;
        });
    }
}
