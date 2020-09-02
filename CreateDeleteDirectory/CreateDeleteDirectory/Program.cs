using System;
using System.IO;

class Program
{
    static void Main()
    {
        // ドキュメントフォルダを取得するよー
        var root = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        // ディレクトリを作成するよー
        Directory.CreateDirectory(Path.Combine(root, @"$$sampleDirRoot\a\b\c\d\e"));
        // 作成したディレクトリにテキストファイルを作成するよー
        File.WriteAllText(Path.Combine(root, @"$$sampleDirRoot\a\b\c\d\e\f.txt"), "Hello! in Directory!");
        // ファイルの存在をチェックするよー
        checkFile();
        // ディレクトリを削除するよー
        Directory.Delete(Path.Combine(root, @"$$sampleDirRoot"), true);
        // ファイルの存在をまたチェックするよー
        checkFile();

        // ファイルの存在チェックだよー
        void checkFile()
        {
            // そのファイルはあるかな?
            if (File.Exists(Path.Combine(root, @"$$sampleDirRoot\a\b\c\d\e\f.txt")))
                // あったよ!　あったから中味を出力するよ!
                Console.WriteLine(File.ReadAllText(Path.Combine(root, @"$$sampleDirRoot\a\b\c\d\e\f.txt")));
            else
                // なかったよ。しょんぼり。
                Console.WriteLine("File Not Found");
        }
    }
}
