using System;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;

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
                    if (num<minNumber)
                    {
                        minNumber = num;
                    }
                }
            }
            Console.WriteLine($"{minNumber}");
        }
    }
}
