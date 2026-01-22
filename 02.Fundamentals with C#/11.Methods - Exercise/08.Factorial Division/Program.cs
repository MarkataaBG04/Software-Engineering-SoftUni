namespace _08.Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double firstFactorial = Factorial(firstNum);
            double secondFactorial = Factorial(secondNum);

            Console.WriteLine($"{firstFactorial / secondFactorial:F2}");
        }

        static double Factorial(int num)
        {
            double result = 1;

            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
