using System;

namespace Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int heMustBeLive = int.Parse(Console.ReadLine());
            double moneyToSpend = 0;
            int realAge = 18;
            for (int age = 1800; age <= heMustBeLive; age++)
            {
                
                if (age % 2 == 0)
                {
                    moneyToSpend += 12000;
                }
                else
                {
                    moneyToSpend += 12000 + (50 *realAge );
                }
                realAge++;
            }
            if (inheritedMoney >= moneyToSpend)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney-moneyToSpend:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {moneyToSpend-inheritedMoney:F2} dollars to survive.");
            }


        }
    }
}
