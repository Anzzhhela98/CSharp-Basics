using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double electricityCost = 0;
          
            
           
            for (int i = 1; i <= months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                electricityCost += electricity;
               


            }
            double waterCost = months * 20;
            double internetCost = months * 15;
            double otherCost = ( electricityCost+waterCost+internetCost)*1.20;
            double  averageMoney = (waterCost + internetCost + electricityCost + otherCost) / months;
            Console.WriteLine($"Electricity: {electricityCost:F2} lv");
            Console.WriteLine($"Water: {waterCost:F2} lv");
            Console.WriteLine($"Internet: {internetCost:F2} lv");
            Console.WriteLine($"Other: {otherCost:F2} lv");
            Console.WriteLine($"Average: {averageMoney:F2} lv");

        }
    }
}
