using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i < 7; i++)
        {

            Console.Write($"製品番号{i}は、");
            switch (i)
            {
                case 1:
                case 2:
                    Console.WriteLine("廃盤です。");
                    break;
                case 3:
                case 5:
                    Console.WriteLine("販売中です。");
                    break;
                case 6:
                default:
                    Console.WriteLine("お問い合わせ下さい。");
                    break;
            }
        }
    }
}
