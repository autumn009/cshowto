using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Working...");
        Console.WriteLine("Done!");
        Console.Beep();
        Console.Beep(800,200);
        for (int i = 0; i < 5; i++)
        {
            Console.Beep(800+i*100, 200);
        }
    }
}
