using System;
using System.Xml.Schema;

namespace Конвентиране_на_мерни_единици
{
    class Program
    {
        static void Main(string[] args)
        {
            double numToChange = double.Parse(Console.ReadLine());
            string mernaEdinica = Console.ReadLine();
            string exitMernaEdinica = Console.ReadLine();

            double total = 0;
            if (mernaEdinica == "mm")
            {
                if (exitMernaEdinica == "m")
                {
                    numToChange /= 1000;
                }

                else if (exitMernaEdinica == "cm")
                {
                    numToChange /= 10;
                }
            }
            if (mernaEdinica == "cm")
            {
                if (exitMernaEdinica == "m")
                {
                    numToChange /= 100;
                }

                else if (exitMernaEdinica == "mm")
                {
                    numToChange *= 10;
                }
            }
            if (mernaEdinica == "m")
            {
                if (exitMernaEdinica == "cm")
                {
                    numToChange *= 100;
                }

                else if (exitMernaEdinica == "mm")
                {
                    numToChange *= 1000;
                }
            }
            Console.WriteLine($"{numToChange:F3}");

        }
    }
}
