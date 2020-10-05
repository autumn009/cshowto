using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        // こうは書きたくない
        var atoz1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Console.WriteLine(atoz1);
        // まわりくどい
        var sb = new StringBuilder();
        for (int i = 0; i < 26; i++)
        {
            sb.Append((char)(i + 'A'));
        }
        var atoz2 = sb.ToString();
        Console.WriteLine(atoz2);
        // LINQ使用
        var atoz3 = string.Concat(Enumerable.Range('A', 26).Select(c => (char)c));
        Console.WriteLine(atoz3);
        // NG
        var ng = string.Concat(Enumerable.Range('A', 26));
        Console.WriteLine(ng);
    }
}
