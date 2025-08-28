using System;

namespace _06.Operations_Between_Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = 0;

            string isEvenOrOdd = "";
            bool isValid = true;

            if (operation == "+")
            {
                result = num1 + num2;
            }
            else if (operation == "-")
            {
                result = num1 - num2;
            }
            else if (operation == "*")
            {
                result = num1 * num2;
            }
            else if (operation == "/")
            {
                if (num2 == 0)
                {
                    isValid = false;
                }
                else
                {
                    result = (double)num1 / num2;
                }
            }
            else
            {
                if (num2 == 0)
                {
                    isValid = false;
                }
                else
                {
                    result = num1 % num2;
                }
            }

            if (result % 2 == 0)
            {
                isEvenOrOdd = "even";
            }
            else
            {
                isEvenOrOdd = "odd";
            }

            if (isValid)
            {
                if (operation == "/")
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {result:f2}");
                }
                else if (operation == "%")
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {result}");
                }
                else
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - {isEvenOrOdd}");
                }
            }
            else
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }
        }
    }
}