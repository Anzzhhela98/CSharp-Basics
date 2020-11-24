using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 1; i <= n; i++)
            {
                leftSum += int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= n; i++)
            {
                rightSum+= int.Parse(Console.ReadLine());
            }
            if (leftSum==rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                int diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {diff}");
            }       


        }
    }
}
