using System;
namespace WWG_3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите год: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Даты последних четвергов года {a} ");
            for (int i = 1; i < 12 + 1; i++)
            {
                DateTime d = new DateTime(a, i, DateTime.DaysInMonth(a, i));
                Console.WriteLine(d.Day - (7 + (int)d.DayOfWeek - 4) % 7);
            }
        }
    }
}