using System;

class Program
{
    static void Main()
    {
        // 2020年1月1日10時37分
        var time1 = new DateTime(2020, 1, 1, 10, 37, 0);
        // 2020年1月1日11時21分
        var time2 = new DateTime(2020, 1, 1, 11, 21, 0);
        // Subtractメソッド使用
        Console.WriteLine(time2.Subtract(time1));
        // マイナス演算子使用
        Console.WriteLine(time2 - time1);
    }
}
