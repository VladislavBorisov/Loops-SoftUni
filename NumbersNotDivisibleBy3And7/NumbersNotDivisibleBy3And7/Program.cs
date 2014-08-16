using System;


namespace NumbersNotDivisibleBy3And7
{
    class NumbersNotDivisibleBy3And7
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter an integer number:");
            bool isnInt = int.TryParse(Console.ReadLine(), out n);
            if (isnInt)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (((i % 3) != 0) || ((i % 7) != 0))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}