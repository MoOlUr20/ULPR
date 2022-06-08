using System;
namespace WWG_4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int answer = rnd.Next(1, n);
            int k = int.Parse(Console.ReadLine());
            for (int i = 1; i <= k; i++)
            {
                Console.Write("Ввод: ");
                int input = int.Parse(Console.ReadLine());
                if (i == k)
                {
                    Console.WriteLine($"Попытки закончились, ответ {answer} ");
                    return;
                }
                if (input == answer)
                {
                    Console.WriteLine("Правильный ответ! ");
                    return;
                }
                if (input < answer)
                {
                    Console.WriteLine("Число больше ");
                }
                if (input > answer)
                {
                    Console.WriteLine("Число меньше ");
                }
            }
        }
    }
}
