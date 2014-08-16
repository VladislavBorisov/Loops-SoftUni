using System;


namespace BinaryToDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string binNumber = Console.ReadLine();
            long decNumber = 0;
            int power = 1;

            for (int i = binNumber.Length - 1; i >= 0; i--)
            {
                int num = binNumber[i] - 48;
                decNumber += num * power;
                power *= 2;
            }
            Console.WriteLine(decNumber);
        }
    }
}
