using System;

class MyException : Exception
{
    public MyException()
    {
    }

    public MyException(string message)
        : base(message)
    {
    }

    public MyException(string message, Exception inner)
        : base(message, inner)
    {
    }
}

class Program
{
    private static void sub(uint n)
    {
        if (n >= 1000) throw new MyException("sub メソッドが扱えるのは999までです。");
        Console.WriteLine($"[{n,3}]");
    }

    static void Main()
    {
        try
        {
            sub(9);
            sub(99);
            sub(999);
            sub(9999);
        }
        catch (MyException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
