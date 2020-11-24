using System;
using System.Runtime.InteropServices;

namespace Еднакви_суми_на_четна_и_нечетна_позиция
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                int number = i;
                bool isEvenPosrion = true;
                int evenSum = 0;
                int oddSum = 0;
                while (number > 0)
                {
                    int lastDigits = number % 10;
                    if (isEvenPosrion)
                    {
                        evenSum += lastDigits;
                        isEvenPosrion = false;
                    }
                    else
                    {
                        oddSum += lastDigits;
                        isEvenPosrion = true;
                    }
                    number /= 10;
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
            }

        }
    }
}
