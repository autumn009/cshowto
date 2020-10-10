using System;

class Program
{
    static void Main()
    {
        // double型
        double paiD = Math.PI;
        Console.WriteLine(paiD);
        // float型
        float paiF = MathF.PI;
        Console.WriteLine(paiF);
        // double型
        decimal paiE = 3.1415926535897932384626433833M; // 参考: 必要な桁数を考えて適切な桁数書こう
        Console.WriteLine(paiE);
    }
}
