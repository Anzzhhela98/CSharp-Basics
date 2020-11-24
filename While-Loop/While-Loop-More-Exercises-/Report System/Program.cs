using System;
using System.Diagnostics.CodeAnalysis;

namespace Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int expectsSum = int.Parse(Console.ReadLine());
            double payment = 0;
            double collected = 0;
            double cashSum = 0;
            double cardSum = 0;
            double cardCounter = 0;
            double cashcounter = 0;

            
            while (expectsSum>=collected)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    break;
                }
                else
                {
                    int priceItem = int.Parse(command);
                    payment++;
                    if (payment % 2 == 0)
                    {
                        if (priceItem < 10)
                        {
                            Console.WriteLine("Error in transaction!");
                        }
                        else
                        {
                            collected += priceItem;
                            cardSum += priceItem;
                            cardCounter++;
                            Console.WriteLine("Product sold!");
                        }
                    }
                    else
                    {
                        if (priceItem > 100)
                        {
                            Console.WriteLine("Error in transaction!");
                        }
                        else
                        {
                            collected += priceItem;
                            cashSum += priceItem;
                            cashcounter++;
                            Console.WriteLine("Product sold!");
                        }
                    }
                    if (collected>=expectsSum)
                    {
                        Console.WriteLine($"Average CS: {cashSum/cashcounter:F2}");
                        Console.WriteLine($"Average CC: {cardSum/cardCounter:F2}");
                        break;
                    }
                    priceItem = int.Parse(command);

                }
            }

        }
    }
}
