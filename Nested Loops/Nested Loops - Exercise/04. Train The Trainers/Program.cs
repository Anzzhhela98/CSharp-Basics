using System;

namespace Ветеринарен_Паркинг
{
    class Program
    {
        static void Main(string[] args)
        {
            int joury = int.Parse(Console.ReadLine());

            string text = Console.ReadLine();
            int countGarde = 0;
            double totalSum = 0;
            while (text != "Finish")
            {
                double sum = 0;
                for (int i = 1; i <= joury; i++)
                {
                    double grade1 = double.Parse(Console.ReadLine());
                    sum += grade1;
                    countGarde++;
                    totalSum += grade1;


                }
                double average = sum / joury;
                Console.WriteLine($"{text} - {average:F2}.");
                text = Console.ReadLine();
            }
            double totalAverage = totalSum / countGarde;
            Console.WriteLine($"Student's final assessment is {totalAverage:f2}.");
        }
    }
}
