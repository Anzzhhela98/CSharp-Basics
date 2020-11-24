using System;

namespace Кола_под_наем
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string clas = "";
            string typeCar = "";
            if (buget <= 100)
            {
                clas = "Economy class";
                if (season == "Summer")
                {
                    typeCar = "Cabrio";
                    buget = buget * 0.35;
                }
                else if (season == "Winter")
                {
                    typeCar = "Jeep";
                    buget = buget * 0.65;
                }
            }
            if (buget > 100 && buget <= 500)
            {
                clas = "Compact class";
                if (season == "Summer")
                {
                    typeCar = "Cabrio";
                    buget = buget * 0.45;
                }
                else if (season == "Winter")
                {
                    typeCar = "Jeep";
                    buget = buget * 0.80;
                }
            }
            if (buget > 500)
            {
                clas = "Luxury class";
                typeCar = "Jeep";
                buget = buget * 0.90;
            }
            Console.WriteLine($"{clas}");
            Console.WriteLine($"{typeCar} - {buget:f2}");
        }
    }
}
