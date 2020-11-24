using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGrades = int.Parse(Console.ReadLine());
            double averageScore = 0;
            double countExercises = 0;
            string name = string.Empty;
            double countPoorGrade = 0;

            while (true)
            {
                string exerciseName = Console.ReadLine();
               
                if (exerciseName == "Enough")
                {
                    Console.WriteLine($"Average score: {averageScore / countExercises:F2}");
                    Console.WriteLine($"Number of problems: {countExercises}");
                    Console.WriteLine($"Last problem: {name}");
                    break;
                }

                double grade = double.Parse(Console.ReadLine());
                name = exerciseName;
                countExercises++;
                averageScore += grade;
                if (grade <= 4)
                {
                  countPoorGrade++;
                    if (poorGrades == countPoorGrade)
                    {
                        Console.WriteLine($"You need a break, {poorGrades} poor grades.");
                        break;
                    }
                }
            }
        }
    }
}
