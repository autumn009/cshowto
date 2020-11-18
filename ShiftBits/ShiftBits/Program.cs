using System;

class Program
{
    static void Main()
    {
        byte high = 0x12;
        byte low = 0x34;
        ushort combined = (ushort)(low | high << 8);
        Console.WriteLine($"{combined:x}");
    }
}
