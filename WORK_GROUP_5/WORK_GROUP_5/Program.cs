﻿using System;
namespace WG_5
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            while (n > 0)
            {
                int ost = n % 10;
                if (ost % 2 == 0)
                {
                    k++;
                }
                n = n / 10;
            }
            Console.WriteLine(k);
        }
    }
}