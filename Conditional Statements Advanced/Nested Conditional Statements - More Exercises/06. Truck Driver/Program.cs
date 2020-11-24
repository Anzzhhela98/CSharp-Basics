using System;

namespace Шофиор_на_тир
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());
            double kmPrice = 0;
            if (season == "Spring" || season == "Autumn")
            {
                if (km <= 5000)
                {
                    kmPrice = km * 0.75;
                }
                else if (km > 5000 && km <= 10000)
                {
                    kmPrice = km * 0.95;
                }
                else if (km > 10000 && km <= 20000)
                {
                    kmPrice = km * 1.45;
                }
            }
            if (season == "Summer")
            {
                if (km <= 5000)
                {
                    kmPrice = km * 0.90;
                }
                else if (km > 5000 && km <= 10000)
                {
                    kmPrice = km * 1.10;
                }
                else if (km > 10000 && km <= 20000)
                {
                    kmPrice = km * 1.45;
                }
            }
            if (season == "Winter")
            {
                if (km <= 5000)
                {
                    kmPrice = km * 1.05;
                }
                else if (km > 5000 && km <= 10000)
                {
                    kmPrice = km * 1.25;
                }
                else if (km > 10000 && km <= 20000)
                {
                    kmPrice = km * 1.45;
                }
            }

            double finalKmPrice = (kmPrice * 0.90) * 4;
            Console.WriteLine($"{finalKmPrice:f2}");
        }
    }
}
