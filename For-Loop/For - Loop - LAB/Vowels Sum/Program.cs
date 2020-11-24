using System;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                if (letter=='a')
                {
                    sum+=1;
                }
                else if (letter=='e')
                {
                    sum+=2;
                }
                else if (letter == 'i')
                {
                    sum+=3;
                }
                else if (letter == 'o')
                {
                    sum+=4;
                }
                else if (letter == 'u')
                {
                    sum+=5;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
