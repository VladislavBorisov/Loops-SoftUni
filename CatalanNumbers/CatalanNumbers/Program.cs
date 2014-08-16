using System;
using System.Numerics;


namespace CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a positive whole number in the range [2...99], N = ");
            string numberStr = Console.ReadLine();
            int numN = int.Parse(numberStr);
            if (numN < 2 || numN >= 100)
            {
                Console.WriteLine("Error - Invalid Number !!!");
            }
            else
            /* The formula for Catalan numbers: C = (2N)! / ((N + 1)! * N!) .
             * Will seeing factorials N! and (N + 1)! They are Subsets of
             * factorial (2N)! That's means, the N Catalan Number can be
             * calculated by other most easy way:
             * 1) First loop for multiply numbers from (2N) to (N + 2);
             * 2) Second loop to calculate factorial N!;
             * RESULT C = 1) / 2). Example: N=10, RESULT C = 16796.  */
            {
                BigInteger factorial2NtoN2 = 1;
                for (int i = (2 * numN); i > (numN + 1); i--)
                {
                    factorial2NtoN2 *= i;
                }

                BigInteger factorialN = 1;
                for (int j = 2; j <= numN; j++)
                {
                    factorialN *= j;
                }

                BigInteger numberCatalan = factorial2NtoN2 / factorialN;
                Console.WriteLine("The N-th number of Catalan is CATALAN NUM = {0} !",
                    numberCatalan);
            }
            Console.ReadLine();
        }
    }
}
