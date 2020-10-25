using System;

class Program
{
    private static void sub(string format)
    {
        Console.WriteLine(format,"Tom","School");
    }


    static void Main()
    {
        sub("{0} goes to {1}.");
        sub("{1} へ {0} は行きました。");
    }
}
