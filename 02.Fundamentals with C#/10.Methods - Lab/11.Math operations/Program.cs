

namespace _11.Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string operators = Console.ReadLine(); 
            int secondNum = int.Parse(Console.ReadLine());

            double result = Calculate(firstNum, operators, secondNum);

            Console.WriteLine(result);

        }

        private static double Calculate(int firstNum, string operators, int secondNum)
        {
            double result = 0;

            switch (operators)
            {
                case "/":
                    result = firstNum / secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
