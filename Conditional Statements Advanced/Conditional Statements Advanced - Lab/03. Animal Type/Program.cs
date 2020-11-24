using System;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "dog")
            {
                Console.WriteLine("mammal");
            }
            else if (type == "crocodile" || type == "tortoise" || type == "snake")
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }


        }
    }
}
