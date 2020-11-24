using System;

namespace Пътешествие
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string type1 = "";

            double price = 0;
            string destination1 = "";

            if (buget <= 100)
            {
                destination1 = "Bulgaria";
                if (season == "summer")
                {
                    price = buget * 0.30;
                    type1 = "Camp";
                }
                else if (season == "winter")
                {
                    price = buget * 0.70;
                    type1 = "Hotel";
                }
            }
            else if (buget <= 1000)
            {
                destination1 = "Balkans";
                if (season == "summer")
                {
                    price = buget * 0.40;
                    type1 = "Camp";
                }
                else if (season == "winter")
                {
                    price = buget * 0.80;
                    type1 = "Hotel";
                }
            }
            if (buget > 1000)
            {
                price = buget * 0.90;
                destination1 = "Europe";
                if (season == "summmer")
                {
                    type1 = "Hotel";
                }
                else
                {
                    type1 = "Hotel";
                }
            }
            Console.WriteLine($"Somewhere in {destination1}");
            Console.WriteLine($"{type1} - {price:f2}");
        }
    }
}
