using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] ar =
        {
            "test.doc",
            "test.docx",
            "test.txt",
            "test.",
            "test"
        };
        foreach (var item in ar)
        {
            var newname = Path.ChangeExtension(item, "bak");
            Console.WriteLine($"{item} => {newname}");
        }
    }
}
