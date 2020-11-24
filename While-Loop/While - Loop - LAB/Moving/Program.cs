using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double spaceBoxes = 0;
            double allSpace = width * lenght * height;
            
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="Done")
                {
                    Console.WriteLine($"{allSpace-spaceBoxes} Cubic meters left.");
                    break;
                }
               
                    int countBoxes = int.Parse(command);
                spaceBoxes += countBoxes;
              
                    
                
                if (allSpace-spaceBoxes<0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(allSpace-spaceBoxes)} Cubic meters more.");
                    break;
                }
              
            }
            

        }
    }
}
