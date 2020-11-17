using System;
using System.IO;

class Program
{
    private static void fileReaderSub(TextReader reader)
    {
        for (; ; )
        {
            var s = reader.ReadLine();
            if (s == null) break;
            Console.WriteLine($"[{s}]");
        }
    }
    static void Main()
    {
        string src = "Hello!\nMy Friends!\nWelcome!";
        File.WriteAllText("sample.txt", src);
        // ファイルから読み出す
        using(var reader1 = File.OpenText("sample.txt"))
        {
            fileReaderSub(reader1);
        }
        // 文字列から読み出す
        var reader2 = new StringReader(src);
        fileReaderSub(reader2);
    }
}
