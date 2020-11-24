using System;

namespace Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int coursesGame = int.Parse(Console.ReadLine());
            double counter0to9 = 0;
            double counter10to19 = 0;
            double counter20to29 = 0;
            double counter30to39 = 0;
            double counter40to50 = 0;
            double counterInvalid = 0;
            double value = 0;

            for (int i = 1; i <= coursesGame; i++)
            {
                int result = int.Parse(Console.ReadLine());
                if (result<0||result>50)
                {
                    counterInvalid++;
                    value /= 2;
                }
                if (result >= 0 && result <= 9)
                {
                    counter0to9++;
                    value += result * 0.20;
                }
                else if (result >= 10 && result <= 19)
                {
                    counter10to19++;
                    value += result * 0.30;
                }
                else if (result >= 20 && result <= 29)
                {
                    counter20to29++;
                    value += result * 0.40;
                }
                else if (result >= 30 && result <= 39)
                {
                    counter30to39++;
                    value +=50;
                }
                else if (result >= 40 && result <= 50)
                {
                    counter40to50++;
                    value +=100;
                }
            }
            double percent0to9 = (counter0to9 /coursesGame) * 100;
            double percent10to19 = (counter10to19 / coursesGame) * 100;
            double percent20to29 = (counter20to29 / coursesGame) * 100;
            double percent30to39 = (counter30to39 / coursesGame) * 100;
            double percent40to50 = (counter40to50 / coursesGame) * 100;
            double percentInvalid = (counterInvalid / coursesGame) * 100;
            Console.WriteLine($"{value:f2}");
            Console.WriteLine($"From 0 to 9: {percent0to9:f2}%");
            Console.WriteLine($"From 10 to 19: {percent10to19:f2}%");
            Console.WriteLine($"From 20 to 29: {percent20to29:f2}%");
            Console.WriteLine($"From 30 to 39: {percent30to39:f2}%");
            Console.WriteLine($"From 40 to 50: {percent40to50:f2}%");
            Console.WriteLine($"Invalid numbers: {percentInvalid:f2}%");

        }
    }
}
