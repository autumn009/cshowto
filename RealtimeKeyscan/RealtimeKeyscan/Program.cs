using System;

class Program
{
    static void Main()
    {
        for (int i = 0; ; i++)
        {
            Console.Write($"{i},");
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true);
                Console.WriteLine();
                Console.WriteLine($"何かのキーが押されました。押されたキーは{key.Key}です。プログラムを中断します。");
                break;
            }
        }
    }
}
