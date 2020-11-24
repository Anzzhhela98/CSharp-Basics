using System;

namespace _02._Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
using System;
using System.Security.Cryptography;

namespace Комбинация_от_букви
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());
            double count = 0;
            for (char i = letter1; i <= letter2; i++)
            {
                for (char j = letter1; j <= letter2; j++)
                {
                    for (char k = letter1; k <= letter2; k++)
                    {

                        if (i != letter3 && j != letter3 && k != letter3)
                        {
                            count++;
                            Console.Write($"{i}{j}{k} ");
                        }

                    }
                }

            }
            Console.WriteLine($"{count}");
        }
    }
}
