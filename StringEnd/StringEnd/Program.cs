using System;
using System.Linq;

class Program
{
    static void Main()
    {
        const string src = "吉良瞳子";
        // 最後の1文字が指定の文字か判定する
        if (src.EndsWith("子")) Console.WriteLine("文字列の最後の1文字は【子】です。");
        // LINQを使わない方法で最後の1文字を取得する
        char ch1 = src[src.Length - 1];
        Console.WriteLine($"文字列の最後の1文字は【{ch1}】です。");
        // LINQを使う方法で最後の1文字を取得する
        char ch2 = src.Last();
        Console.WriteLine($"文字列の最後の1文字は【{ch2}】です。");

        // 最後の2文字が指定の文字か判定する
        if (src.EndsWith("瞳子")) Console.WriteLine("文字列の最後の1文字は【瞳子】です。");
        // LINQを使わない方法で最後の2文字を取得する
        string s1 = src.Substring(src.Length - 2);
        Console.WriteLine($"文字列の最後の2文字は【{s1}】です。");
        // LINQを使う方法で最後の1文字を取得する
        string s2 = new string(src.TakeLast(2).ToArray());
        Console.WriteLine($"文字列の最後の2文字は【{s2}】です。");
    }
}
