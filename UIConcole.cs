using System;
using System.Collections.Generic;

namespace Calculator
{
    internal class UI
    {
        public void Start()
        {
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Choose an operation: ");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");

            int choice = GetChoice();

            List<int> numbers = GetNumbers();
            Calculator calculator = new Calculator();

            int result = PerformOperation(choice, numbers, calculator);
            Console.WriteLine($"The numbers provided were: {string.Join(", ", numbers)}");
            Console.WriteLine($"The result is: {result}");
        }

        private int GetChoice()
        {
            int choice;
            do
            {
                Console.Write("Enter your choice (1-4): ");
            } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4);
            return choice;
        }

        private List<int> GetNumbers()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter numbers (Press enter to confirm each number. Type 'done' to finish):");
            while (true)
            {
                string input = Console.ReadLine();
                if (input?.ToLower() == "done") break;

                if (int.TryParse(input, out int num))
                {
                    numbers.Add(num);
                }
                else
                {
                    Console.WriteLine("Invalid number, please try again.");
                }
            }
            return numbers;
        }

        private int PerformOperation(int choice, List<int> numbers, Calculator calculator)
        {
            if (numbers.Count < 2)
            {
                Console.WriteLine("At least two numbers are required for calculation.");
                return 0;
            }

            int result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                switch (choice)
                {
                    case 1: result = calculator.Addition(result, numbers[i]); break;
                    case 2: result = calculator.Subtraction(result, numbers[i]); break;
                    case 3: result = calculator.Multiplication(result, numbers[i]); break;
                    case 4: result = calculator.Divison(result, numbers[i]); break;
                }
            }
            return result;
        }
    }
}
