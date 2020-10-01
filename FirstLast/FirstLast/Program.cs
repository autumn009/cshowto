using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] ar = {
            "クラウド","セフィロス","ティファ","エアリス","バレット"
        };
        foreach (var item in ar)
        {
            if (item.FirstOrDefault()== 'セ' && item.LastOrDefault()=='ス') Console.WriteLine(item);
        }
    }
}
