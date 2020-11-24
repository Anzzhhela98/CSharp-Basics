using System;

namespace Време___15_минути
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());

            int minute = int.Parse(Console.ReadLine());

            minute = minute + 15;
            if (minute > 59)
            {
                hour++;
                minute -= 60;
            }
            if (hour > 23)
            {
                hour = 0;
            }
            if (minute < 10)
            {
                Console.WriteLine("{0}:0{1}", hour, minute);

            }
            else
            {
                Console.WriteLine("{0}:{1}", hour, minute);
            }
        }
    }
}
