using System;


namespace CalculateGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write a integer");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("write a integer");
            int b = int.Parse(Console.ReadLine());
            int remain = a % b;
            while (remain != 0)
            {
                a = b;
                b = remain;
                remain = a % b;
            }
            Console.WriteLine(Math.Abs(b));
        }
    }
}
