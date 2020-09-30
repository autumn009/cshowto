using System;

class Program
{
    static void Main()
    {
        string[] ar = {
            "クラウド","セフィロス","ティファ","エアリス","バレット"
        };
        foreach (var item in ar)
        {
            if (item.StartsWith("セ") && item.EndsWith("ス")) Console.WriteLine(item);
        }
    }
}
