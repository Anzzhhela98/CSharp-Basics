using System;

namespace хотелска_стая
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double priceS = 0;
            double priceA = 0;
            if (season == "May" || season == "October")
            {
                priceS = (50 * count);
                priceA = (65 * count);

                if (count > 7 && count <= 14)
                {
                    priceS = (50 * count) * 0.95;

                }
                else if (count > 14)
                {
                    priceS = (50 * count) * 0.70;
                }
            }
            if (season == "June" || season == "September")
            {
                priceS = (75.20 * count);
                priceA = (68.70 * count);

                if (count > 14)
                {
                    priceS = priceS * 0.80;

                }
            }
            if (season == "July" || season == "August")
            {
                priceS = (76 * count);
                priceA = (77 * count);
            }
            if (count > 14)
            {
                priceA *= 0.90;
            }
            Console.WriteLine($"Apartment: {priceA:f2} lv.");
            Console.WriteLine($"Studio: {priceS:f2} lv.");
        }
    }
}
