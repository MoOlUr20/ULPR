using System;
using System.Globalization;
namespace WWG_1
{
    class Program
    {
        static void Main()
        {
            DateTime d;
            Console.Write("Введите день: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите месяц: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите год: ");
            int c = int.Parse(Console.ReadLine()); 
            string date = $"{c}, {b}, {a}";
            int daysToEnd = 0;
            GregorianCalendar cal = new GregorianCalendar();
            if (DateTime.TryParse(date, out d))
            {
                int dayOfYear = cal.GetDayOfYear(d);
                Console.WriteLine(dayOfYear);
                if (cal.IsLeapYear(c))
                {
                    daysToEnd = 366 - dayOfYear;
                }
                else
                {
                    daysToEnd = 365 - dayOfYear;
                }
                Console.WriteLine(daysToEnd);
            }
            else
            {
                Console.WriteLine("Некорректная дата");
            }
        }
    }
}