using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
                   
            int maxNum = int.MinValue;

            while (true)
            {
                string comand = Console.ReadLine();
                if (comand=="Stop")
                {
                    
                    break;
                }
                else
                {
                    int num = int.Parse(comand);
                    if (num > maxNum)
                    {
                        maxNum = num;
                    }
                }
               
            }
           
            Console.WriteLine($"{maxNum}");
        }
    }
}
