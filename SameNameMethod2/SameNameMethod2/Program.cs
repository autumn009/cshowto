using System;

interface X1
{
    void Sub();
}

class A : X1
{
    public void Sub()
    {
        Console.WriteLine("I'm X1.Sub in A");
    }
}

class B : A, X1
{
    void X1.Sub()
    {
        Console.WriteLine("I'm X1.Sub in B");
    }
}

class Program
{
    static void Main()
    {
        var b = new B();
        b.Sub();
        ((X1)b).Sub();
    }
}
