using System;

class Program
{
    private static void div1(decimal x, decimal y)
    {
        Console.WriteLine(x / y);
    }
    private static void div2(double x, double y)
    {
        Console.WriteLine(x / y);
    }

    static void Main()
    {
        Console.WriteLine("div1の利用");
        try
        {
            div1(0, 0);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("0で割りました。");
        }
        Console.WriteLine("div2の利用");
        try
        {
            div2(0, 0);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("0で割りました。");
        }
    }
}
