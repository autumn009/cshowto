using System;

class A
{
    public void Sub()
    {
        Console.WriteLine("I'm class A!");
    }
}

class B
{
    public void Sub(string a = "Dummy")
    {
        Console.WriteLine("I'm class B!");
    }
}

class Program
{
    private static void commonWork(dynamic arg)
    {
        arg.Sub();
    }
    static void Main()
    {
        commonWork(new A());
        commonWork(new B());
    }
}
