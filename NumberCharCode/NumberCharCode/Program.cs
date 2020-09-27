using System;

class Program
{
    private static bool charTest1(char ch)
    {
        return ch == '0'
            || ch == '1'
            || ch == '2'
            || ch == '3'
            || ch == '4'
            || ch == '5'
            || ch == '6'
            || ch == '7'
            || ch == '8';
    }

    private static bool charTest2(char ch)
    {
        return "012345678".Contains(ch);
    }

    private static bool charTest3(char ch)
    {
        return ch >= '0' && ch <= '8';
    }

    static void Main()
    {
        Console.WriteLine($"charTest1('A')={charTest1('A')}");
        Console.WriteLine($"charTest1('3')={charTest1('3')}");
        Console.WriteLine($"charTest2('A')={charTest2('A')}");
        Console.WriteLine($"charTest2('3')={charTest2('3')}");
        Console.WriteLine($"charTest3('A')={charTest3('A')}");
        Console.WriteLine($"charTest3('3')={charTest3('3')}");
    }
}
