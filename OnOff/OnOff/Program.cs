using System;

class Program
{
    static void Main()
    {
        // 否定法
        bool switch1 = false;
        for (int i = 0; i < 20; i++)
        {
            switch1 = !switch1;
            Console.Write(switch1 ? "[OFF]" : "[ON]");
        }
        Console.WriteLine();

        // XOR法
        int switch2 = 0;
        for (int i = 0; i < 20; i++)
        {
            switch2 = switch2 ^ 1;
            Console.Write($"[{switch2}]");
        }
        Console.WriteLine();

        // 剰余法
        int switch3 = 0;
        for (int i = 0; i < 20; i++)
        {
            switch3 = (switch3 + 1) % 2;
            Console.Write($"[{switch3}]");
        }
        Console.WriteLine();
    }
}
