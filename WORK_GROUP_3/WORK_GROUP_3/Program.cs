﻿using System;
namespace WG_3
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }
            int max = mas.Max();
            int n1 = max - (max * 10 / 100);
            int n2 = max + (max * 10 / 100);
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (n1 <= mas[i] & mas[i] <= n2)
                {
                    count++;
                }
            }
            count = count - 1;
            Console.WriteLine(count);
        }
    }
}