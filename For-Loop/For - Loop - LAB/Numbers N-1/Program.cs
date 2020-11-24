using System;

namespace Numbers_N_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = num ; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
