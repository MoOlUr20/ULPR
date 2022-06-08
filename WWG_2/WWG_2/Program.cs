using System;
namespace WWG_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите день: ");
            int a = int.Parse(Console.ReadLine()); 
            Console.Write("Введите месяц: ");
            int b = int.Parse(Console.ReadLine()); 
            Console.Write("Введите год: ");
            int c = int.Parse(Console.ReadLine()); 
            var julian = new DateTime(c, b, a);
            Console.WriteLine($"По юлианскому календарю: {julian}");
            var grigorian = julian.AddDays( (c / 100) - ( (c / 100) / 4) - 2);
            Console.WriteLine($"По григорианскому календарю: {grigorian}");
        }
    }
}