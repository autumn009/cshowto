using System;

class Program
{
    private static void sub1(bool isEnabled, bool flag)
    {
        if( isEnabled)
        {
            if (flag) flag = false; else flag = true;
        }
        Console.WriteLine(flag);
    }

    private static void sub2(bool isEnabled, bool flag)
    {
        Console.WriteLine(isEnabled ^ flag);
    }

    static void Main()
    {
        sub1(false, true);
        sub1(true, true);
        sub2(false, true);
        sub2(true, true);
    }
}
