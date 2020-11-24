using System;

namespace Волейбол___Влади
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine();
            double holiday = double.Parse(Console.ReadLine());
            double weekends = double.Parse(Console.ReadLine());

            double allweekends = 48 - weekends;
            double saturdayPlay = (allweekends * 3) / 4;
            double holidayPlay = (holiday * 2) / 3;
            double finalPlay = saturdayPlay + holidayPlay + weekends;
            if (typeYear == "leap")
            {
                finalPlay = finalPlay + (finalPlay * 0.15);
            }
            Console.WriteLine($"{Math.Floor(finalPlay)}");


        }
    }
}
