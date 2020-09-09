using System;

class Program
{
    static void Main()
    {
        byte a = 1; // OK
        byte b = a; // OK
        //byte c = a+1; //  // エラー CS0266  型 'int' を 'byte' に暗黙的に変換できません。明示的な変換が存在します(cast が不足していないかどうかを確認してください)
        //byte d = a+(byte)1; // cast付けてもエラーになる!
        byte e = (byte)(a+1); // OK
        a = b; // OK
        a += 1; // OK
        //a = a + 1;  // エラー CS0266  型 'int' を 'byte' に暗黙的に変換できません。明示的な変換が存在します(cast が不足していないかどうかを確認してください)
        //a = a + (byte)1;    // cast付けてもエラーになる!
        a = (byte)(a + 1);
        Console.WriteLine($"a+b+e={a+b+e}");
    }
}
