using System;
using System.Security.Cryptography;

namespace Stream_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();
            int countN = 0;
            int countC = 0;
            int countO = 0;
            string word = string.Empty;
            string secredWord = "";
            while (symbol != "End")
            {

                char letter = char.Parse(symbol);
                if (letter >= 'a' && letter <= 'z' || letter >= 'A' && letter <= 'Z')
                {
                    if (letter == 'c' && countC == 0)
                    {
                        countC++;
                    }
                    else if (symbol == "o" && countO == 0)
                    {
                        countO++;
                    }
                    else if (symbol == "n" && countN == 0)
                    {
                        countN++;
                    }
                    else
                    {
                        word += letter;
                    }
                    if (countC+countN+countO==3)
                    {
                        secredWord += word;
                        secredWord += ' ';
                        word = "";
                        countO = 0;
                        countC = 0;
                        countN = 0;
                    }
                    

                }
                symbol = Console.ReadLine();
               

            }
            Console.WriteLine(secredWord);

        }
    }
}
