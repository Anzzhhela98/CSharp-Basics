using System;

namespace Басейн
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());

            double firsHours = (days - (days * 0.1)) * 8;
            double second = (employees * 2) * days;
            double total = firsHours + second;
            if (total >= hoursNeeded)
            {
                Console.WriteLine($"Yes!{Math.Floor(total - hoursNeeded)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Ceiling(hoursNeeded - total)} hours needed.");
            }



        }
    }
}