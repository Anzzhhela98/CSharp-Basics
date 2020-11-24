using System;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            if (type == "m" && age >= 16)
            {
                Console.WriteLine("Mr.");
            }
            else if (type == "m" && age < 16)
            {
                Console.WriteLine("Master");
            }
            else if (type == "f" && age >= 16)
            {
                Console.WriteLine("Ms.");
            }
            else
            {
                Console.WriteLine("Miss");
            }


        }
    }
}
