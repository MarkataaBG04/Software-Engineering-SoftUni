

namespace _05.Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int result = FirstTwoNum(firstNum, secondNum);

            result = Substract(result, thirdNum);

            Console.WriteLine(result);
        }

        private static int Substract(int result, int c)
        {
            return result - c;
        }

        private static int FirstTwoNum(int a, int b)
        {
            return a + b;
        }
    }
}
