using System;

namespace Ски_почивка
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string posnNeg = Console.ReadLine();
            days -= 1;
            double price = 0;
            if (type == "room for one person")
            {
                price = days * 18.00;
            }
            if (type == "apartment")
            {
                price = days * 25.00;
                if (days < 10)
                {
                    price = price * 0.70;
                }
                else if (days >= 10 && days < 15)
                {
                    price = price * 0.65;
                }
                else
                {
                    price = price * 0.50;
                }
            }
            if (type == "president apartment")
            {
                price = days * 35.00;
                if (days < 10)
                {
                    price = price * 0.90;
                }
                else if (days >= 10 && days < 15)
                {
                    price = price * 0.85;
                }
                else
                {
                    price = price * 0.80;
                }
            }
            if (posnNeg == "positive")
            {
                price = price + (price * 0.25);
            }
            else if (posnNeg == "negative")
            {
                price *= 0.9;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
