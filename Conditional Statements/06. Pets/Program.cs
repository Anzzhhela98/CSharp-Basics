using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int leftFood = int.Parse(Console.ReadLine());
            double foodPerDog = double.Parse(Console.ReadLine());
            double foodPerCat = double.Parse(Console.ReadLine());
            double foodPeTurtle = double.Parse(Console.ReadLine());

            double needFoodDog = (foodPerDog * days);
            double needFoodCat = (foodPerCat * days);
            double needFoodTurtle = (foodPeTurtle / 1000) * days;
            double allFood = needFoodCat + needFoodDog + needFoodTurtle;
            if (leftFood >= allFood)
            {
                Console.WriteLine($"{Math.Floor(leftFood - allFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(allFood - leftFood)} more kilos of food are needed.");
            }

        }
    }
}
