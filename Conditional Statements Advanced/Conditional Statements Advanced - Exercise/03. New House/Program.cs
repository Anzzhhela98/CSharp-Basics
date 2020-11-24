using System;

namespace Нов_дом
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double buget = double.Parse(Console.ReadLine());
            double price = 0;
            if (type == "Roses")
            {
                price = count * 5;
                if (count > 80)
                {
                    price = price * 0.9;
                }
            }
            else if (type == "Dahlias")
            {
                price = count * 3.8;
                if (count > 90)
                {
                    price = price * 0.85;
                }
            }
            else if (type == "Tulips")
            {
                price = count * 2.8;
                if (count > 80)
                {
                    price = price * 0.85;
                }
            }
            else if (type == "Narcissus")
            {
                price = count * 3;
                if (count < 120)
                {
                    price = price + (price * 0.15);
                }
            }
            else if (type == "Gladiolus")
            {
                price = count * 2.5;
                if (count < 80)
                {
                    price = price + (price * 0.20);
                }

            }
            if (buget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {type} and {buget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - buget:f2} leva more.");
            }
        }
    }
}
