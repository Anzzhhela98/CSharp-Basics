using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int periodCalculation = int.Parse(Console.ReadLine());
            int doctors = 7;
            int reviewed = 0;
            int unChecked = 0;
            for (int startPeriod = 1; startPeriod <= periodCalculation; startPeriod++)
            {

                int patientComing = int.Parse(Console.ReadLine());
                if (startPeriod % 3 == 0)
                {
                    if (unChecked > reviewed)
                    {
                        doctors++;
                    }
                }
                if (patientComing <= doctors)
                {
                    reviewed += patientComing;
                }
                else
                {
                    reviewed += doctors;
                    unChecked += patientComing - doctors;
                }
            }
            Console.WriteLine($"Treated patients: {reviewed}.");
            Console.WriteLine($"Untreated patients: {unChecked}.");

        }
    }
}
