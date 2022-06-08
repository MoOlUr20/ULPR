using System;
namespace WG_1
{
    class Program
    {
        static void Main()
        {
            int Ct, Kt, Ck, Kk;
            Ct = int.Parse(Console.ReadLine());
            Kt = int.Parse(Console.ReadLine());
            Ck = int.Parse(Console.ReadLine());
            Kk = int.Parse(Console.ReadLine());
            int Price = Ct * Kt + Ck * Kk;
            Console.WriteLine(Price);
        }
    }
}