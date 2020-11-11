using System;

// recordの定義
public record ProductInfo(string Name, int Price);

class Program
{
    private static void dump(ProductInfo info)
    {
        Console.WriteLine($"{info.Name}: {info.Price}Yen");
    }
    static void Main()
    {
        // コーヒー120円です
        var info = new ProductInfo("Coffee", 120);
        dump(info);
        // 130円に値上げします
        var info2 = info with { Price = 130 };
        dump(info2);
    }
}
