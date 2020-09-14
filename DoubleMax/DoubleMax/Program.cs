using System;

class Program
{
    static void Main()
    {
        float lastOne = 0.0f;
        DateTimeOffset start = DateTimeOffset.Now;
        for (float i = 1.0f; i < float.MaxValue;)
        {
            if (i > 16777200) Console.WriteLine(i);
            if (lastOne == i)
            {
                Console.WriteLine($"カウントアップしていません! {i} {DateTimeOffset.Now - start}");
                break;
            }
            lastOne = i;
            i++;
        }

        DateTimeOffset startD = DateTimeOffset.Now;
        for (double i = 1.0; i < double.MaxValue;i*=2)
        {
            double next = i + 1;
            if (i == next)
            {
                Console.WriteLine($"カウントアップしていません! {i} {DateTimeOffset.Now - startD}");
                return;
            }
        }
    }
}
