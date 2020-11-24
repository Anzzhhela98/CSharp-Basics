using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int expectedSteps = 0;
     
            while (expectedSteps < 10000)
            {   
                   
                string command = Console.ReadLine();
                if (command == "Going home")
                {
                    int steps = int.Parse(Console.ReadLine());
                    expectedSteps += steps;
                    break;
                }
                else
                {
                    int araivalSteps = int.Parse(command);
                    expectedSteps += araivalSteps;
                }
             
            }
            if (expectedSteps < 10000)
            {
                Console.WriteLine($"{10000 - expectedSteps} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{expectedSteps - 10000} steps over the goal!");
            }

        }
    }
}
