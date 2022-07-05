using System;

namespace LeetCodePractice
{
    class Program
    {
        static void Main(String[] args)
        {
            Random rnd = new Random();
            double num = rnd.Next(1, 13);
            double sum = 0;

            Console.WriteLine("Starting Number = " + num);

            if (num % 2 == 0)
            {
                Console.WriteLine(num + " Can be devided by 2");
                sum = num / 2;
                Console.WriteLine("Ending Number = " + sum);
            }
            else
            {
                Console.WriteLine("Can't be devided by 2");
            }

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
