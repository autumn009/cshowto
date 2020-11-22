using System;
using System.Reflection;

class MyAttribute : Attribute
{
}

class Program
{
    public int MyProperty1 { get; set; }
    [My]
    public int MyProperty2 { get; set; }


    static void Main()
    {
        foreach (var item in typeof(Program).GetProperties())
        {
            Console.WriteLine($"{item.Name}は{nameof(MyAttribute)}属性を");
            if (item.GetCustomAttribute(typeof(MyAttribute)) == null)
                Console.WriteLine("持っていません。");
            else
                Console.WriteLine("持っています。");
        }
    }
}
