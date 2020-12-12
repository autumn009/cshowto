    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var list = new List<byte[]>();
            for (int i = 0; i < 100000; i++)
            {
                list.Add(new byte[100000000]);
            }
        }
    }
