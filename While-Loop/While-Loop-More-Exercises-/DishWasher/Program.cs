using System;

namespace Numbers_Divided_by_3_Without_Reminder

{
    class Program
    {
        static void Main(string[] args)
        {
            int countBottle = int.Parse(Console.ReadLine());
            double counter = 0;
            double dishes = 0;
            double pots = 0;
            double quantityDetegrent = countBottle * 750;

            while (quantityDetegrent > 0)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                counter++;
                 if (counter % 3 == 0)
                {
                    int countDishes = int.Parse(command);
                    pots += countDishes;
                    quantityDetegrent -= countDishes * 15;
                }
                else
                {
                    int countDishes = int.Parse(command);
                    dishes += countDishes;
                    quantityDetegrent -= countDishes * 5;
                }
            }
            if (quantityDetegrent < 0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(quantityDetegrent)} ml. more necessary!");
            }
            else
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {quantityDetegrent} ml.");
            }

        }
    }
}
