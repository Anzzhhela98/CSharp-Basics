using System;

namespace Лица_на_фигури
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double side1 = double.Parse(Console.ReadLine());
            double total = 0;
            if (type == "square")
            {
                total = side1 * side1;
            }
            else if (type == "rectangle")
            {
                double side2 = double.Parse(Console.ReadLine());
                total = side1 * side2;
            }
            else if (type == "circle")
            {

                total = Math.PI * side1 * side1;
            }
            else if (type == "triangle")
            {
                double side2 = double.Parse(Console.ReadLine());
                total = (0.5 * side2) * side1;
            }
            Console.WriteLine($"{total:f3}");
        }
    }
}
