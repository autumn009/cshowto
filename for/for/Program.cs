using System;

class Program
{
    static void Main()
    {
        // 無限ループしない
        for (int i = 0; i <= 255; i++) Console.Write($"{i} ");
        // 無限ループする
        for (byte i = 0; i <= 255; i++) Console.Write($"{i} ");
    }
}
