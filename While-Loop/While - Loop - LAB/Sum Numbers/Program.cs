using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nededSum = int.Parse(Console.ReadLine());
            int averageSum = 0;
            while (true)
            {
                int sum = int.Parse(Console.ReadLine());
                averageSum += sum;
                if (nededSum<=averageSum)
                {
                    break;
                }
                
            }
            Console.WriteLine($"{averageSum}");


        }
    }
}
