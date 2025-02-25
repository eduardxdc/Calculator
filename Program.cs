using System;
using System.Runtime.Intrinsics;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Enter the first value: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            float secondValue = float.Parse(Console.ReadLine());       

            Console.WriteLine(firstValue + " " + secondValue);
        }
    }
}
