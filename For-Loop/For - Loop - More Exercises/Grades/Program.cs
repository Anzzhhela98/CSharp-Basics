using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
           double countStudents = double.Parse(Console.ReadLine());
            double failed = 0;
            int between3and399=0;
            int between4and499=0;
          int topStudent=0;
            double averageGrade = 0;
            for (int i = 1; i <= countStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                averageGrade += grade;
                if (grade < 3)
                {
                    failed++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                  between3and399 ++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    between4and499++;
                }
                else if (grade >= 5)
                {
                    topStudent++;
                }
            }
            Console.WriteLine($"Top students: {topStudent/countStudents*100:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {between4and499/countStudents*100:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {between3and399/countStudents*100:F2}%");
            Console.WriteLine($"Fail: {failed/countStudents*100:F2}%");
            Console.WriteLine($"Average: {averageGrade/countStudents:F2}");
        }
    }
}
