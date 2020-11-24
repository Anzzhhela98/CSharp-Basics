using System;

namespace Магическо_число
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int breaktNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            bool found = false;
            int combination = 0;
            for (int x1 = startNum; x1 <= breaktNum; x1++)
            {
                for (int x2 = startNum; x2 <= breaktNum; x2++)
                {
                    int sum = x1 + x2;
                    combination++;
                    if (sum == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combination} ({x1} + {x2} = {sum})");
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNum}");
            }
        }
    }
}
