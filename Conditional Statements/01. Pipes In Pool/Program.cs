using System;

namespace Басейн
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double litersP1 = (p1 * hours);
            double litersP2 = (p2 * hours);
            double V1 = (litersP2 + litersP1);

            double allPercent = (V1 / V) * 100;
            double percentP1 = (litersP1 / V1) * 100;
            double percentP2 = (litersP2 / V1) * 100;

            if (V1 <= V)
            {

                Console.WriteLine($"The pool is {allPercent}% full. Pipe 1: {percentP1:f2}%. Pipe 2: {percentP2:f2}%.");
            }
            else
            {

                Console.WriteLine($"For {hours:f2} hours the pool overflows with {V1 - V:f2} liters.");
            }

        }
    }
}