using System;
using System.Text;

class Program
{
    static void Main()
    {
        var s = "たろうくんの英語はA、国語はB";
        var bad = s.Replace('A', 'B').Replace('B', 'A');
        Console.WriteLine($"ダメなケース {bad}");
        var good1 = s.Replace('A', '\0').Replace('B', 'A').Replace('\0', 'B');
        Console.WriteLine($"良いケース1 {good1}");
        var good2 = new StringBuilder();
        foreach (var item in s) good2.Append(item switch { 'A' => 'B', 'B' => 'A', _ => item });
        Console.WriteLine($"良いケース2 {good2.ToString()}");
    }
}
