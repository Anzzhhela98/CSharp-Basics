using System;
using System.Diagnostics.CodeAnalysis;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int countCargo = int.Parse(Console.ReadLine());
            double train = 0;
            double bus = 0;
            double truck = 0;

           
            double countBus = 0;
            double countTrain = 0;
            double countTruck = 0;

            for (int i = 1; i <= countCargo; i++)
            {
                int countTone = int.Parse(Console.ReadLine());
               
                if (countTone <= 3)
                {
                    bus += countTone * 200;
                    countBus += countTone;
                }
                else if (countTone >= 4 && countTone <= 11)
                {
                    truck += countTone * 175;
                    countTruck += countTone;
                }
                else
                {
                    train += countTone * 120;
                    countTrain += countTone;
                }


            }
            double allTone = countTrain+countBus+countTruck;
            double averageTons = (train + truck + bus) / allTone;

            Console.WriteLine($"{averageTons:f2}");
            Console.WriteLine($"{(countBus / allTone) * 100:f2}%");
            Console.WriteLine($"{(countTruck / allTone) * 100:f2}%");
            Console.WriteLine($"{(countTrain / allTone )* 100:f2}%");

        }
    }
}
