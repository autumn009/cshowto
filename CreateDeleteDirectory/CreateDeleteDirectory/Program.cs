using System;
using System.IO;

class Program
{
    static void Main()
    {
        var root = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        Directory.CreateDirectory(Path.Combine(root, @"$$sampleDirRoot\a\b\c\d\e"));
        File.WriteAllText(Path.Combine(root, @"$$sampleDirRoot\a\b\c\d\e\f.txt"), "Hello! in Directory!");
        checkFile();
        Directory.Delete(Path.Combine(root, @"$$sampleDirRoot"), true);
        checkFile();

        void checkFile()
        {
            if (File.Exists(Path.Combine(root, @"$$sampleDirRoot\a\b\c\d\e\f.txt")))
                Console.WriteLine(File.ReadAllText(Path.Combine(root, @"$$sampleDirRoot\a\b\c\d\e\f.txt")));
            else
                Console.WriteLine("File Not Found");
        }
    }
}
