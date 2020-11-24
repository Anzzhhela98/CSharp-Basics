using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            double spendDays = 0;
            int days = 0;
            while (excursionMoney > availableMoney)
            {
                string indeed = Console.ReadLine();
                double spendOrSaveMoney = double.Parse(Console.ReadLine());
                days++;
                if (indeed == "spend")
                {
                    availableMoney -= spendOrSaveMoney;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                    spendDays++;
                    if (spendDays == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{days}");
                        break;
                    }
                }
                if (indeed == "save")
                {
                    availableMoney += spendOrSaveMoney;
                }

            }
            if (excursionMoney <= availableMoney)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
