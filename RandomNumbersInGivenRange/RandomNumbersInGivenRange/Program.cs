using System;

namespace RandomNumbersInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a integer");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter a integer");
            int minInt = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter a integer");
            int maxInt = int.Parse(Console.ReadLine());
            if (minInt <= maxInt)
            {
                Random random = new Random();
                for (int index = 0; index < count; index++)
                {
                    Console.Write("{0} ", random.Next(minInt, maxInt + 1));
                }
            }
            else
            {
                Console.WriteLine("incorrect input");
            }
        }
    }
}