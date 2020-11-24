using System;

namespace РезервоарЗаГориво
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int liter = int.Parse(Console.ReadLine());
            if (type == "diesel" || type == "gasoline" || type == "gas")
            {
                if (liter >= 25)
                {
                    Console.WriteLine($"You have enough {type}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {type}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }


        }
    }
}
