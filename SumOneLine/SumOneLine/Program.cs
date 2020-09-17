using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 作戦1　限定法
        Console.WriteLine(Enumerable.Range(1,100).Where(c => (c % 2) == 0).Sum());
        // 作戦1　加工法
        Console.WriteLine(Enumerable.Range(1, 50).Sum(c=>c*2));
    }
}
