using System;

namespace FactorialCalculator
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Enter a number: ");

            int number = int.Parse(Console.ReadLine());

            long factorial = CalculateFactorial(number);

            Console.WriteLine($"The factorial of {number} is {factorial}");

            Console.ReadLine();
        }

        static long CalculateFactorial(int number)
        {
            if (number == 0 || number == 1)
                return 1;

            long factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}