using System;
namespace WG_4
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int X = int.Parse(Console.ReadLine());
            int x = X;
            for (int i = 2; i <= N; i++)
            {
                X = x * X;
            }
            Console.WriteLine(X);
        }
    }
}