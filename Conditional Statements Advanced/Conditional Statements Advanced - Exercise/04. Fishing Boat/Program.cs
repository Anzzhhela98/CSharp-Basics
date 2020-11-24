using System;

namespace Лодка_за_Риболов
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double price = 0;
            if (season == "Spring")
            {
                price = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200;
            }
            else if (season == "Winter")
            {
                price = 2600;
            }
            if (count <= 6)
            {
                price = price * 0.90;
            }
            else if (count >= 7 && count <= 11)
            {
                price = price * 0.85;
            }
            else if (count > 12)
            {
                price = price * 0.75;
            }
            if ((season == "Summer" || season == "Winter" || season == "Spring") &&
                count % 2 == 0)
            {
                price = price * 0.95;
            }
            if (buget >= price)
            {
                Console.WriteLine($"Yes! You have {buget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - buget:f2} leva.");
            }
        }
    }
}
