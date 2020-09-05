using System;
using System.Linq;

class Program
{
    class MyReferType
    {
        internal int X { get; set; }
        public override string ToString() => X.ToString();
    }
    private static void dump<T>(T[] ar)
    {
        Console.WriteLine(string.Join(',', ar));
    }
    static void Main()
    {
        Console.WriteLine("オーソドックスな方法。サイズ10の配列を作ってから1つ1つ入れる");
        char[] a0 = new char[10];
        for (int i = 0; i < a0.Length; i++) a0[i] = 'A';
        dump(a0);
        Console.WriteLine("文字列\"AAAAAAAAAA\"を作ってからToCharArrayで文字の配列化する");
        char[] a1 = new string('A', 10).ToCharArray();
        dump(a1);
        Console.WriteLine("LINQが使えるならToArrayでも良い");
        char[] a1linq = new string('A', 10).ToArray();
        dump(a1linq);
        Console.WriteLine("文字列\"AAAAAAAAAA\"を直接書いてしまう");
        char[] a2 = "AAAAAAAAAA".ToArray();
        dump(a2);
        Console.WriteLine("LINQを使う");
        char[] a3 = Enumerable.Repeat('A', 10).ToArray();
        dump(a3);
        Console.WriteLine("LINQ方式だと型に関係ない");
        decimal[] a4 = Enumerable.Repeat(1.2m, 10).ToArray();
        dump(a4);
        Console.WriteLine("参照型だと意図しない結果になる可能性も");
        MyReferType[] a5 = Enumerable.Repeat(new MyReferType(), 10).ToArray();
        Console.WriteLine("この時、全ての要素は0だが");
        dump(a5);
        a5[0].X = 1;
        Console.WriteLine("全ての要素が1になってる!");
        dump(a5);
        Console.WriteLine("これが望んだ結果ではないときはこうする");
        MyReferType[] a6 = Enumerable.Repeat(0, 10).Select(c => new MyReferType()).ToArray();
        Console.WriteLine("この時、全ての要素は0だが");
        dump(a6);
        a6[0].X = 1;
        Console.WriteLine("最初の要素だけ1になってる!");
        dump(a6);
    }
}
