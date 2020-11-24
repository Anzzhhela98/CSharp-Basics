using System;

namespace Кино
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double price = 0;
            if (type == "Premiere")
            {
                price = (r * c) * 12.00;
            }
            else if (type == "Normal")
            {
                price = (r * c) * 7.50;
            }
            else if (type == "Discount")
            {
                price = (r * c) * 5.00;
            }

            Console.WriteLine($"{price:f2} leva");
        }
    }
}
