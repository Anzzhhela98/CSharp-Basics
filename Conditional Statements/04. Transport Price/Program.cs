using System;

namespace PricePerTransport
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            if (type == "day")
            {
                double taksi = 0.70 + (0.79 * n);
                double reis = 0.09 * n;
                double vlak = 0.06 * n;
                if (n < 20)
                {
                    Console.WriteLine("{0:F2}", taksi);
                }
                else if (n < 100)
                {
                    Console.WriteLine("{0:F2}", reis);
                }
                else
                {
                    Console.WriteLine("{0:F2}", vlak);
                }
            }
            if (type == "night")
            {
                double taxi = 0.70 + (0.90 * n);
                double bus = 0.09 * n;
                double train = 0.06 * n;
                if (n < 20)
                {
                    Console.WriteLine("{0:F2}", taxi);
                }
                else if (n < 100)
                {
                    Console.WriteLine("{0:F2}", bus);
                }
                else
                {
                    Console.WriteLine("{0:F2}", train);
                }
            }

        }
    }
}
