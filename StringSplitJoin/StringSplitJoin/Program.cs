using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 元データ
        string src = "あいこ/たろう/ポチ";

        // 間違った逆順
        string dst1 = new string(src.Reverse().ToArray());
        Console.WriteLine($"間違った逆順: {dst1}");

        // 正しい逆順
        // まず配列に分解する
        string[] ar = src.Split('/');
        // 配列確認
        foreach (var item in ar) Console.WriteLine($"分解された要素 {item}");
        // 配列の逆順
        var rev = ar.Reverse();
        // 逆順の確認
        foreach (var item in rev) Console.WriteLine($"逆順の要素 {item}");
        // 配列から区切り文字を入れて文字列を組み立てる
        string dst2 = string.Join('/', rev);
        Console.WriteLine($"正しい逆順: {dst2}");
    }
}
