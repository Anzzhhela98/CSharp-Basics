using System;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;
            for (int i = 1; i <= n; i++)
            {

                if (i % 2 == 0)
                {
                    even += int.Parse(Console.ReadLine());
                }
                else
                {
                    odd += int.Parse(Console.ReadLine());
                }
            }
            if (even == odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(even - odd)}");
            }
        }
    }
}
