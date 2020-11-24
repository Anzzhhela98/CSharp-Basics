using System;

namespace Щастливи_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            double totalSum = 0;
            for (int countDay = 1; countDay <= day; countDay++)
            {
                double sum = 0;
                for (int countHour = 1; countHour <= hour; countHour++)
                {
                    if (countDay % 2 == 0 && countHour % 2 == 1)
                    {
                        sum += 2.50;
                        totalSum += 2.50;
                    }
                    else if (countDay % 2 == 1 && countHour % 2 == 0)
                    {
                        sum += 1.25;
                        totalSum += 1.25;
                    }
                    else
                    {
                        sum += 1;
                        totalSum += 1;
                    }
                }
                Console.WriteLine($"Day: {countDay} - {sum:F2} leva");
            }
            Console.WriteLine($"Total: {totalSum:F2} leva");


        }
    }
}
