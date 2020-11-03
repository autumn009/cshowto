using System;
using System.Linq;

class Program
{
    private static void sub(int[] array)
    {
        string result = $"{string.Join('+', array)}={array.Sum()}";
        Console.WriteLine(result);
    }
    static void Main()
    {
        int[] array1 = { 1, 2, 3 };
        sub(array1);
        int[] array2 = { 5, 8, 2, 11 };
        sub(array2);
    }
}
