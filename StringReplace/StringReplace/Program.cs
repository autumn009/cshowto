using System;
using System.Text;

class Program
{
    static void Main()
    {
        var src = "Fußball";
        var targetChar = 'ß';
        Console.WriteLine("文字置換を試す　(できない)");
        var dst1 = src.Replace(targetChar, '?');
        Console.WriteLine(dst1);
        Console.WriteLine("1文字単位で処理してみる");
        var dst2 = new StringBuilder();
        foreach (var item in src) dst2.Append(item == targetChar ? "ss" : item);
        Console.WriteLine(dst2);
        Console.WriteLine("1文字だけど文字列置換に切り換える");
        var dst3 = src.Replace(targetChar.ToString(), "ss");
        Console.WriteLine(dst3);
    }
}
