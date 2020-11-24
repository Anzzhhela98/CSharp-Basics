using System;

namespace Магазин_за_играчки
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            double countPuzzles = double.Parse(Console.ReadLine());
            double countDoll = double.Parse(Console.ReadLine());
            double countBears = double.Parse(Console.ReadLine());
            double countMinion = double.Parse(Console.ReadLine());
            double countTruck = double.Parse(Console.ReadLine());

            double pricePuzzles = countPuzzles * 2.60;
            double priceDolls = countDoll * 3;
            double priceBears = countBears * 4.10;
            double priceMinions = countMinion * 8.20;
            double priceTrucks = countTruck * 2;

            double allToys = countPuzzles + countMinion + countDoll + countBears + countTruck;
            double allMoney = priceBears + priceDolls + priceMinions + pricePuzzles + priceTrucks;
            if (allToys >= 50)
            {
                allMoney = allMoney * 0.75;
            }
            allMoney = allMoney * 0.9;
            if (allMoney >= excursionPrice)
            {
                Console.WriteLine($"Yes! {allMoney - excursionPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {excursionPrice - allMoney:F2} lv needed.");
            }

        }
    }
}
