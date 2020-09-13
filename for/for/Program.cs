using System;

class Program
{
    static void Main()
    {
        // 無限ループしない
        for (int i = 0; i <= 255; i++) Console.Write($"{i} ");
        // byte型で無限ループしない別解
        for(byte i = 0; ;i++ )
        {
            Console.Write($"{i} ");
            if ( i == 255) break;
        }
        // 無限ループする
        for (byte i = 0; i <= 255; i++) Console.Write($"{i} ");
    }
}
