using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int cakePices = lenght * hight;

           

            int slicesCount = 0;
            while (cakePices>=slicesCount)
            {
                string command = Console.ReadLine();
                if (command == "STOP")
                {
                    Console.WriteLine($"{Math.Abs(slicesCount - cakePices)} pieces are left.");
                    break;
                }

                else
                {
                    int pices = int.Parse(command);
                    slicesCount += pices;
                }
            }

            if (cakePices < slicesCount)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePices - slicesCount)} pieces more.");
               
            }

        }
    }
}
