using System;

namespace Магазин_за_цветя
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulip = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string typeOfDay = Console.ReadLine();
            double price1 = 0;
            double price2 = 0;
            double price3 = 0;
            double totalCount = roses + chrysanthemums + tulip;
            if (season == "Summer" || season == "Spring")
            {
                price1 = chrysanthemums * 2;
                price2 = roses * 4.10;
                price3 = tulip * 2.50;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                price1 = chrysanthemums * 3.75;
                price2 = roses * 4.50;
                price3 = tulip * 4.15;
            }
            double price = (price1 + price2 + price3);
            if (typeOfDay == "Y")
            {
                price = (price * 0.15) + price;
            }
            if (tulip > 7 && season == "Spring")
            {
                price = price * 0.95;
            }
            else if (roses >= 10 && season == "Winter")
            {
                price = price * 0.90;
            }
            if (totalCount > 20)
            {
                price = price * 0.80;
            }
            Console.WriteLine($"{price + 2:f2}");
        }
    }
}
