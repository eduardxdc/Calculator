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

            Console.WriteLine("1 => Sum");
            Console.WriteLine("2 => Subtraction");
            Console.WriteLine("3 => Division");
            Console.WriteLine("4 => Multiplication");
            Console.WriteLine("5 => Exit");

            Console.WriteLine("");
            Console.Write("Enter your choice: ");

            short menuResult = short.Parse(Console.ReadLine());

            switch (menuResult)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

            Console.ReadKey();
        }

        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("[Sum] Enter the first value:");
            float sumFirstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("[Sum] Enter the second value:");
            float sumSecondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("=============================");

            float sumResult = sumFirstValue + sumSecondValue;
            Console.WriteLine($"Result of the sum is: {sumResult}");

            Console.ReadKey();
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();

            Console.WriteLine("[Subtraction] Enter the first value:");
            float subFirstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("[Subtraction] Enter the second value:");
            float subSecondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("=====================================");

            float subResult = subFirstValue - subSecondValue;
            Console.WriteLine($"Result of the subtraction is: {subResult}");

            Console.ReadKey();
            Menu();
        }

        static void Division()
        {
            Console.Clear();

            Console.WriteLine("[Division] Enter the first value:");
            float divFirstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("[Division] Enter the second value:");
            float divSecondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("==================================");

            float divResult = divFirstValue / divSecondValue;
            Console.WriteLine($"Result of the division is: {divResult}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("[Multiplication] Enter a first value:");
            float multiFirstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("[Multiplication] Enter a second value:");
            float multiSecondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("======================================");

            float multiResult = multiFirstValue * multiSecondValue;
            Console.WriteLine($"Result of the multiplication is: {multiResult}");

            Console.ReadKey();
            Menu();
        }
    }

}
