using System;

namespace ConsoleApp2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int lowerRandomNumber = 0;
            int upperRandomNumber = 100;
            int firstMultiplicity = 3;
            int secondMultiplicity = 5;
            int sumOfNumbers = 0;

            Random random = new Random();
            number = random.Next(lowerRandomNumber, upperRandomNumber);

            Console.WriteLine(number);

            for (int i = 0; i <= number; i++)
            {
               if (i % firstMultiplicity == 0 || i % secondMultiplicity == 0)
                {
                    sumOfNumbers += i;                    
                }               
            }
            Console.WriteLine(sumOfNumbers);
        }
    }
}
