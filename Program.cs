using System;
using System.Runtime.Intrinsics;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum();
        }

        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("Enter the first value:");
            float sumFirstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value:");
            float sumSecondValue = float.Parse(Console.ReadLine());   
              
            Console.WriteLine("==============================");

            float sumResult = sumFirstValue + sumSecondValue; 

            Console.WriteLine($"Result of the sum is: {sumResult}");
        }
    }
}
