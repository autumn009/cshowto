using System;

class Program
{
    private static void parseAndNegative(string s)
    {
        int.TryParse(s, out int v);
        Console.Write(v);
        Console.Write(">>>>");
        v = -v;
        Console.WriteLine(v);
    }

    private static void parseAndNegativeChecked(string s)
    {
        try
        {
            int.TryParse(s, out int v);
            Console.Write(v);
            Console.Write(">>>>");
            checked
            {
                v = -v;
            }
            Console.WriteLine(v);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow");
        }
    }


    static void Main()
    {
        parseAndNegative("-1234567890");
        parseAndNegative("-2147483648");
        parseAndNegativeChecked("-2147483648");
    }
}
