using System;

namespace Бонус_Точки
{
    class Program
    {
        static void Main(string[] args)
        {
            double points = double.Parse(Console.ReadLine());
            double newPoints = 0;
            if (points <= 100)
            {
                newPoints += 5;
            }
            else if (points > 100 && points <= 1000)
            {
                newPoints = (points * 0.2);
            }
            else if (points > 1000)
            {
                newPoints = (points * 0.1);
            }
            if (points % 2 == 0)
            {
                newPoints += 1;
            }
            else if (points % 10 == 5)
            {
                newPoints += 2;
            }
            Console.WriteLine($"{newPoints}");
            Console.WriteLine($"{points + newPoints}");
        }
    }
}
