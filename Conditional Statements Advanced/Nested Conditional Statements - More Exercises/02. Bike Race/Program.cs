using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {


            int numJunior = int.Parse(Console.ReadLine());
            int numSenior = int.Parse(Console.ReadLine());
            int allEntrant = numSenior + numJunior;
            string tracks = Console.ReadLine();
            double sumJ = 0.0;
            double sumS = 0.0;
            double allSum = 0.0;

            switch (tracks)
            {

                case "trail":
                    sumJ = numJunior * 5.5;
                    sumS = numSenior * 7;
                    allSum = sumS + sumJ;
                    break;
                case "cross-country":
                    sumJ = numJunior * 8;
                    sumS = numSenior * 9.50;
                    if (allEntrant >= 50)
                    {
                        allSum = (sumS + sumJ) * 0.75;
                    }
                    else
                    {
                        allSum = sumS + sumJ;
                    }
                    break;
                case "downhill":
                    sumJ = numJunior * 12.25;
                    sumS = numSenior * 13.75;
                    allSum = sumS + sumJ;
                    break;
                case "road":
                    sumJ = numJunior * 20;
                    sumS = numSenior * 21.50;
                    allSum = sumS + sumJ;
                    break;
            }

            double finalSum = allSum * 0.95;
            Console.WriteLine($"{finalSum:F2}");

        }
    }
}