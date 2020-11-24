using System;

namespace Ваканция
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string stay = "";
            string place = "";

            if (buget <= 1000)
            {
                stay = "Camp";
                if (season == "Summer")
                {
                    place = "Alaska";
                    buget = buget * 0.65;
                }
                else
                {
                    place = "Morocco";
                    buget = buget * 0.45;
                }
            }
            if (buget > 1000 && buget <= 3000)
            {
                stay = "Hut";
                if (season == "Summer")
                {
                    place = "Alaska";
                    buget = buget * 0.80;
                }
                else
                {
                    place = "Morocco";
                    buget = buget * 0.60;
                }
            }
            if (buget > 3000)
            {
                stay = "Hotel";
                if (season == "Summer")
                {
                    place = "Alaska";
                    buget = buget * 0.90;
                }
                else
                {
                    place = "Morocco";
                    buget = buget * 0.90;
                }
            }
            Console.WriteLine($"{place} - {stay} - {buget:f2}");
        }
    }
}
