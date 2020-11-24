using System;

namespace Комисионна
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double comision = double.Parse(Console.ReadLine());
            double precent = 0;
            if (town == "Sofia")
            {
                if (comision >= 0 && comision <= 500)
                {
                    precent = 0.05;
                }
                else if (comision > 500 && comision <= 1000)
                {
                    precent = 0.07;
                }
                else if (comision > 1000 && comision <= 10000)
                {
                    precent = 0.08;
                }
                else if (comision > 10000)
                {
                    precent = 0.12;
                }

            }
            if (town == "Varna")
            {
                if (comision >= 0 && comision <= 500)
                {
                    precent = 0.045;
                }
                else if (comision > 500 && comision <= 1000)
                {
                    precent = 0.075;
                }
                else if (comision > 1000 && comision <= 10000)
                {
                    precent = 0.1;
                }
                else if (comision > 10000)
                {
                    precent = 0.13;
                }

            }
            if (town == "Plovdiv")
            {
                if (comision >= 0 && comision <= 500)
                {
                    precent = 0.055;
                }
                else if (comision > 500 && comision <= 1000)
                {
                    precent = 0.08;
                }
                else if (comision > 1000 && comision <= 10000)
                {
                    precent = 0.12;
                }
                else if (comision > 10000)
                {
                    precent = 0.145;
                }


            }
            double totalMoney = (comision * precent);
            if ((comision > 0) && (town == "Sofia" || town == "Plovdiv" || town == "Varna"))
            {

                Console.WriteLine($"{totalMoney:f2}");
            }

            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
