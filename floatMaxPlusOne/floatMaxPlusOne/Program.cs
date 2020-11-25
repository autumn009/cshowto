using System;

class Program
{
    static void Main()
    {
        checked
        {
            try
            {
                int a = int.MaxValue;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(a);
                    a++;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                float a = float.MaxValue;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(a);
                    a++;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
