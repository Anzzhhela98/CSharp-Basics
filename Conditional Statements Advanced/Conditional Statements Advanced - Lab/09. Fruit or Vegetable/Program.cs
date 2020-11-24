using System;

namespace Плод_или_зеленчук
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "banana" || type == "apple" || type == "kiwi" || type == "cherry"
                || type == "lemon" || type == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (type == "tomato" || type == "cucumber" || type == "pepper" || type == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }


        }
    }
}
