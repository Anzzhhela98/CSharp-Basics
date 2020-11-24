using System;

namespace Магазин_за_плодове_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quatity = double.Parse(Console.ReadLine());
            double price = 0;
            if (day == "Monday" || day == "Tuesday" || day == "Thursday" || day == "Friday" || day == "Wednesday")
            {
                if (fruit == "banana")
                {
                    price = 2.50;
                }
                else if (fruit == "apple")
                {
                    price = 1.20;
                }
                else if (fruit == "orange")
                {
                    price = 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45;
                }
                else if (fruit == "kiwi")
                {
                    price = 2.70;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.50;
                }
                else if (fruit == "grapes")
                {
                    price = 3.85;
                }

            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    price = 2.70;
                }
                else if (fruit == "apple")
                {
                    price = 1.25;
                }
                else if (fruit == "orange")
                {
                    price = 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.60;
                }
                else if (fruit == "kiwi")
                {
                    price = 3.00;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.60;
                }
                else if (fruit == "grapes")
                {
                    price = 4.20;
                }

            }
            double totalPrice = price * quatity;
            if (totalPrice > 0)
            {
                Console.WriteLine($"{totalPrice:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }



        }
    }
}
