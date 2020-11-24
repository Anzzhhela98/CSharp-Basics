using System;

namespace Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double averageGrade = 0;
            
            int failed = 0;
            while (grade <= 12)
            {
               
                double rating = double.Parse(Console.ReadLine());
                if (rating>=4)
                {
                    averageGrade += rating;
                    grade++;
                }
                else
                {
                    failed++;
                    if (failed==2)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }
                }
                if (grade == 13)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {averageGrade / 12:f2}");
                }

            }
            
        }
    }
}

