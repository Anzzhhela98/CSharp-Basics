using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeDays = int.Parse(Console.ReadLine());
            int normTime = 30000;

            int playTime = ((365 - freeDays) * 63) + freeDays * 127;

            if (normTime >= playTime)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{(normTime - playTime) / 60} hours and {(normTime - playTime) % 60} minutes less for play");
            }
            else
            {
                Console.WriteLine($"Tom will run away");
                Console.WriteLine($"{(playTime - normTime) / 60} hours and {(playTime - normTime) % 60} minutes more for play");
            }
        }
    }
}