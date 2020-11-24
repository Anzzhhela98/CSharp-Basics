using System;

namespace Деление__на_специални_числса
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int number = 1111; number <= 9999; number++)
            {
                int thousand = number / 1000;
                int hundread = (number / 100) % 10;
                int tens = (number / 10) % 10;
                int units = (number % 10);

                bool cheker1 = thousand != 0 && n % thousand == 0;
                bool cheker2 = hundread != 0 && n % hundread == 0;
                bool cheker3 = tens != 0 && n % tens == 0;
                bool cheker4 = units != 0 && n % units == 0;


                if (cheker1 && cheker2 && cheker3 && cheker4)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
