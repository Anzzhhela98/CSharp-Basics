using System;

namespace Ученически_лагер
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeGroup = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double price = 0;
            string sports = "";
            if (season == "Winter")
            {
                if (typeGroup == "girls")
                {
                    price = nights * 9.60 * students;
                    sports = "Gymnastics";
                }
                else if (typeGroup == "boys")
                {
                    price = nights * 9.60 * students;
                    sports = "Judo";
                }
                else if (typeGroup == "mixed")
                {
                    price = nights * 10 * students;
                    sports = "Ski";
                }
            }
            if (season == "Spring")
            {
                if (typeGroup == "girls")
                {
                    price = nights * 7.20 * students;
                    sports = "Athletics";
                }
                else if (typeGroup == "boys")
                {
                    price = nights * 7.20 * students;
                    sports = "Tennis";
                }
                else if (typeGroup == "mixed")
                {
                    price = nights * 9.50 * students;
                    sports = "Cycling";
                }
            }
            if (season == "Summer")
            {
                if (typeGroup == "girls")
                {
                    price = nights * 15 * students;
                    sports = "Volleyball";
                }
                else if (typeGroup == "boys")
                {
                    price = nights * 15 * students;
                    sports = "Football";
                }
                else if (typeGroup == "mixed")
                {
                    price = nights * 20 * students;
                    sports = "Swimming";
                }
            }
            if (students >= 50)
            {
                price = price * 0.50;
            }
            else if (students >= 20 || students > 50)
            {
                price = price * 0.85;
            }
            else if (students >= 10 || students > 20)
            {
                price = price * 0.95;
            }
            Console.WriteLine($"{sports} {price:f2} lv.");
        }
    }
}
