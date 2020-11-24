using System;

namespace Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="Stop")
                {
                    break;
                }
                Console.WriteLine($"{command}");
            }
            
        }
    }
}
