using System;

class Program
{
    class C
    {
        public const int N1 = 123;
        public readonly int N2;
        public int N3 { get => N1 + N2; }
        public C()
        {
            N2 = 456;
        }
    }

    static void Main()
    {
        var obj = new C();
        Console.WriteLine($"N1={C.N1}");
        Console.WriteLine($"N2={obj.N2}");
        Console.WriteLine($"N3={obj.N3}");
    }
}
