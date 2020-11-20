    using System;

    class Program
    {
        static void Main()
        {
            int a = 1234;
            int a1 = a*2;
            int a2 = a+a;
            int a3 = a << 1;
            Console.WriteLine("結果は同じ");
            Console.WriteLine($"a * 2 = {a1}");
            Console.WriteLine($"a + a = {a2}");
            Console.WriteLine($"a << 1 = {a3}");
            int b = 1234;
            int b1 = ~b;
            int b2 = b ^ -1;
            Console.WriteLine("結果は同じ");
            Console.WriteLine($"~b = {b1}");
            Console.WriteLine($"b ^ -1 = {b2}");
            int c = 1234;
            int c1 = c % 2;
            int c2 = c & 1;
            Console.WriteLine("結果は同じ");
            Console.WriteLine($"c % 2 = {c1}");
            Console.WriteLine($"c & 1 = {c2}");
            int d = 1234;
            int d1 = d;
            int d2 = 0;
            for (int i = 0; i < d; i++)
            {
                d2++;
            }
            Console.WriteLine("結果は同じ");
            Console.WriteLine($"by assign = {d1}");
            Console.WriteLine($"by loop = {d2}");

        }
    }

