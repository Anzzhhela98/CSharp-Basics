using System;

namespace Информация_за_скоростта
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = double.Parse(Console.ReadLine());
            if (score <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (score > 10 && score <= 50)
            {
                Console.WriteLine("average");
            }
            else if (score > 50 && score <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (score > 150 && score <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else if (score > 1000)
            {
                Console.WriteLine("extremely fast");
            }


        }
    }
}
