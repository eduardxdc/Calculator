using System;
using System.Runtime.Intrinsics;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum();
            Subtraction();
            Division();
            Multiplication();
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

            Console.ReadKey();
        }

        static void Subtraction()
        {
            Console.Clear();

            Console.WriteLine("Enter the first value:");
            float subFirstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value:");
            float subSecondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("==============================");

            float subResult = subFirstValue - subSecondValue;
            Console.WriteLine($"Result of the subtraction is: {subResult}");

            Console.ReadKey();
        }

        static void Division()
        {
            Console.Clear();

            Console.WriteLine("Enter the first value:");
            float divFirstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value:");
            float divSecondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("==============================");

            float divResult = divFirstValue / divSecondValue;
            Console.WriteLine($"Result of the division is: {divResult}");

            Console.ReadKey();
        }

        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("Enter a first value:");
            float multiFirstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second value:");
            float multiSecondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("==============================");

            float multiResult = multiFirstValue * multiSecondValue;
            Console.WriteLine($"Result of the multiplication is: {multiResult}");

            Console.ReadKey();
        }
    }

}
