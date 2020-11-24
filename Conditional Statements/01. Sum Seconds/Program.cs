using System;

namespace Сумиране_на_секунди
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());

            int total = sec1 + sec2 + sec3;
            int min = total / 60;
            int sec = total % 60;
            if (sec < 10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");

            }

        }
    }
}
