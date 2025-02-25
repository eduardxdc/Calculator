using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Welcome! Select below which mathematical operation you want to perform:");
            Console.WriteLine("");

            Console.WriteLine("1- Sum");
            Console.WriteLine("2- Subtraction");
            Console.WriteLine("3- Division");
            Console.WriteLine("4- Multiplication");

            Console.WriteLine("");
            Console.Write("Enter your choice: ");

            short menuResul = short.Parse(Console.ReadLine());
            Console.WriteLine($"Good! You chose the option {menuResul}");

            Console.ReadKey();
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
