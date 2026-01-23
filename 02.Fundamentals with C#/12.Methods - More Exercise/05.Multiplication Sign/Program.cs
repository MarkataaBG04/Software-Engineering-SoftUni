
namespace _05.Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            MultiplicationSign(number1, number2, number3);
        }

        static void MultiplicationSign(int number1, int number2, int number3)
        {
            // ако има нула
            if (number1 == 0 || number2 == 0 || number3 == 0)
            {
                Console.WriteLine("zero");
                return;
            }

            // броим отрицателните числа
            int negativeCount = 0;
            if (number1 < 0) negativeCount++;
            if (number2 < 0) negativeCount++;
            if (number3 < 0) negativeCount++;

            // ако броят на отрицателните е четен → положително
            if (negativeCount % 2 == 0)
            {
                Console.WriteLine("positive");
            }
            else // ако броят е нечетен → отрицателно
            {
                Console.WriteLine("negative");
            }
        }
    }
}
