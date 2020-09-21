using System;
using System.IO;

class Program
{
    static void Main()
    {
        var docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        var filename = "mySpecialDocument.txt";
        // 好ましくない方法
        var path1 = docPath + "\\" + filename;
        Console.WriteLine($"path1 = {path1}");
        // ちょっと好ましい方法
        var path2 = docPath + Path.DirectorySeparatorChar + filename;
        Console.WriteLine($"path2 = {path2}");
        // 好ましい方法
        var path3 = Path.Combine(docPath, filename);
        Console.WriteLine($"path3 = {path3}");
    }
}
