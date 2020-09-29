using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        char[] ar = { 'A', '\u200B', 'B' };
        string s = new string(ar);
        Console.WriteLine(s);
        Debug.WriteLine(s);
    }
}
