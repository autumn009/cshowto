using System;

class Program
{
    static void Main()
    {
        for (; ; )
        {
            var target = DateTimeOffset.Now.AddSeconds(1.0);
            for (; ; )
            {
                if (DateTimeOffset.Now == target) break;
                // ↓正しいコード
                //if (DateTimeOffset.Now > target) break;
            }
            Console.WriteLine(DateTimeOffset.Now);
        }
    }
}
