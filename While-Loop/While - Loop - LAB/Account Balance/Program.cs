using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
        
            double total = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "NoMoreMoney")
                {
                    
                    break;
                }

                double sum = double.Parse(command);

                if (sum < 0)
                    {
                        Console.WriteLine("Invalid operation!");
                        break;

                    }
                    else
                    {
                        total += sum;
                        Console.WriteLine($"Increase: {sum:f2}");

                    }             
                  
                

                
            }
            Console.WriteLine($"Total: {total:f2}");


        }
    }
}
