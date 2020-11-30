using System;

class Sample : IDisposable
{
    public Sample()
    {
        Console.WriteLine("私、産まれました!");
    }
    ~Sample()
    {
        Console.WriteLine("私、消えます!");
    }

    public void Dispose()
    {
        Console.WriteLine("私、Disposeされました!");
    }
}

class Program
{
    static void Main()
    {
        // ファイナライザー?
        var a = new Sample();
        Console.WriteLine($"a of {a} is here!");
        a = null;
        GC.Collect();
        // IDisposable インターフェース?
        using var b = new Sample();
        Console.WriteLine($"b of {b} is here!");
    }
}
