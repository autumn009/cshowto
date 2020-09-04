using System;

class Program
{
    static void Main()
    {
        // 対象の文字列
        var src = "{[山田太郎(一年)柔道部]}";

        // 正攻法でガシガシやった場合
        int from = 0;
        int to = src.Length - 1;
        for (; ; ) if (!"([{".Contains(src[from++])) break;
        for (; ; ) if (!")]}".Contains(src[to--])) break;
        var dst0 = src.Substring(from - 1, to - from + 3);
        Console.WriteLine(dst0);

        // 先頭と末尾を区別する場合
        var dst1 = src.TrimStart('(', '[', '{').TrimEnd(')', ']', '}');
        Console.WriteLine(dst1);

        // 先頭と末尾を区別しなくても良い場合
        var dst2 = src.Trim('(', '[', '{', ')', ']', '}');
        Console.WriteLine(dst2);
    }
}
