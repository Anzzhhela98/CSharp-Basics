using System;

namespace РеколтаЗаВино
{
    class Program
    {
        static void Main(string[] args)
        {
            double meeterLoze = double.Parse(Console.ReadLine());
            double grapesPer1m = double.Parse(Console.ReadLine());

            double needLiterWine = double.Parse(Console.ReadLine());
            double countWorker = double.Parse(Console.ReadLine());

            double litersWine = ((meeterLoze * grapesPer1m) * 0.40) / 2.5;
            if (litersWine < needLiterWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(needLiterWine - litersWine)} liters wine needed.");
            }
            else
            {
                double left = litersWine - needLiterWine;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litersWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(left)} liters left -> {Math.Ceiling(left / countWorker)} liters per person.");
            }
        }
    }
}
