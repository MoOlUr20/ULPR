using System;
namespace WWG_5
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1, 100);
                Console.Write(" " + array[i]);
            }
            for (int i = 0; i < n; i++)
            {
                int newPozition = rnd.Next(i);
                int keeper = array[i];
                array[i] = array[newPozition];
                array[newPozition] = keeper;
            }
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + array[i]);
            }
        }
    }
}