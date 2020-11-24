using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameBooks = Console.ReadLine();

            int countBooks = 0;
            while (true)
            {
                string searched = Console.ReadLine();
                countBooks++;
                if (searched == nameBooks)
                {
                    Console.WriteLine($"You checked {countBooks - 1} books and found it.");
                    break;
                }
                else if (searched == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {countBooks - 1} books.");
                    break;
                }
            }

        }
    }
}
