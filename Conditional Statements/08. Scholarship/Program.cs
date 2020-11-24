using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Scholarships
{
    public class Scholarships
    {
        public static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double socialScolarship = minSalary * 0.35;
            double excellenceScolarship = averageGrade * 25;

            if (income < minSalary && socialScolarship > excellenceScolarship && averageGrade > 4.50)

            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScolarship)} BGN");
            }
            else if (averageGrade >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellenceScolarship)} BGN");
            }
            else if (income > minSalary || averageGrade < 5.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }


        }
    }
}