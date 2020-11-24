using System;

namespace Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
         double count = 0;
         double averageSum = 0;
            double sum =0;
            for (int i = 1; i <=n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                count++;
                averageSum += num;
                sum = averageSum / count;
            }
            Console.WriteLine($"{sum:F2}");
        } 
    }
}
