using System;

namespace Loopsk
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double timePerOneMeeter = double.Parse(Console.ReadLine());

            double swimingTime = length * timePerOneMeeter;
            double stopMeeter = swimingTime + Math.Floor(length / 15) * 12.5;


            if (record > stopMeeter)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {stopMeeter:f2} seconds.");

            }
            else
            {
                Console.WriteLine($"No, he failed! He was {stopMeeter - record:f2} seconds slower.");
            }


        }
    }
}