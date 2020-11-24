using System;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 1;
            
            while (n>=k)
            {
                Console.WriteLine($"{k}");
              k= k * 2 + 1;
            }
          

        }
    }
}
