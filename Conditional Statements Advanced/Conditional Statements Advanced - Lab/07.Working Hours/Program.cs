using System;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)

        {
            double h = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (h >= 10 && h <= 18)

            {
                if (day == "Monday" || day == "Tuesday" || day == "Thursday" || day == "Wednesday"
                 || day == "Friday" || day == "Saturday")
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }

            }
            else
            {
                Console.WriteLine("closed");
            }

        }
    }
}
