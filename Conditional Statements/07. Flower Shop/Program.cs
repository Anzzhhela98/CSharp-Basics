using System;

namespace Loopsk
{
    class Program
    {
        static void Main(string[] args)
        {
            double countMAgnozlia = double.Parse(Console.ReadLine());
            double countZumbul = double.Parse(Console.ReadLine());
            double countRose = double.Parse(Console.ReadLine());
            double countKaktys = double.Parse(Console.ReadLine());
            double priceGift = double.Parse(Console.ReadLine());

            double priceMagnolia = countMAgnozlia * 3.25;
            double priceZumbul = countZumbul * 4;
            double priceRose = countRose * 3.5;
            double priceKaktys = countKaktys * 8;

            double totalPrice = (priceKaktys + priceMagnolia + priceRose + priceZumbul);
            double afterProcent = totalPrice * 0.95;
            if (afterProcent >= priceGift)
            {
                Console.WriteLine($"She is left with {Math.Floor(afterProcent - priceGift)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(priceGift - afterProcent)} leva.");
            }





        }
    }
}
