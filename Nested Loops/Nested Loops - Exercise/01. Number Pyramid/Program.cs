using System;

namespace Пирамида
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int number = 1;
            bool nReached = false;
            for (int rows = 1; rows <= num; rows++)
            {
                for (int colons = 1; colons <= rows; colons++)
                {
                    Console.Write($"{number} ");
                    number++;

                    if (number > num)
                    {
                        nReached = true;
                        break;
                    }
                }
                if (nReached)
                {
                    break;
                }
                Console.WriteLine();

            }

        }
    }
}
