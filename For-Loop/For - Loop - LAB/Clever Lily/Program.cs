using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            double priceWashMachine = double.Parse(Console.ReadLine());
            double priceToys = double.Parse(Console.ReadLine());
            double moneyFromBdays = 0;
            double moneyGift = 10;

            double toys = 0;
            for (int i = 1; i <= ages; i++)
            {
                if (i % 2 == 0)
                {
                    moneyFromBdays += moneyGift;
                    moneyGift += 10;
                    moneyFromBdays--;
                }
                else
                {
                    toys += 1;
                }
            }
            double moneyFromToys = priceToys * toys;
            moneyFromBdays += moneyFromToys;
            if (moneyFromBdays >= priceWashMachine)
            {
                Console.WriteLine($"Yes! {moneyFromBdays - priceWashMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWashMachine-moneyFromBdays:f2}");
            }
        }
    }
}
