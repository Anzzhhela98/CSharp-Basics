using System;

namespace Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;
            int max = 0;
            int min = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num>maxNum)
                {
                    maxNum = num;
                }
                 if (num<minNum)
                {
                    minNum = num;
                }
            }
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
