using System;

namespace ConsoleApp2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sumOfNumbers = 0;

            Random rand = new Random();
            number = rand.Next(0, 100);

            Console.WriteLine(number);

            for (int i = 0; i <= number; i++)
            {
               if (i % 3 == 0 || i % 5 == 0)
                {
                    sumOfNumbers += i;                    
                }               
            }
            Console.WriteLine(sumOfNumbers);
        }
    }
}
