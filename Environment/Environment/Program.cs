using System;

class Program
{
    static void Main()
    {
        bool is64bitOS = Environment.Is64BitOperatingSystem;
        bool is64bitProcess = Environment.Is64BitProcess;
        bool is64bitPointer = IntPtr.Size == 8;
        Console.WriteLine((is64bitOS? "64":"32")+"bit OSです。");
        Console.WriteLine((is64bitProcess ? "64" : "32") + "bit プロセスです。");
        Console.WriteLine((is64bitPointer ? "64" : "32") + "bit ポインターです。");
    }
}
