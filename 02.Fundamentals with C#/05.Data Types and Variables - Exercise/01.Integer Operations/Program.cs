namespace _01.Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long firstNum = long.Parse(Console.ReadLine());
            long secondNum = long.Parse(Console.ReadLine());
            long thirdNum = long.Parse(Console.ReadLine());
            long fourthNum = long.Parse(Console.ReadLine());

            long sum = firstNum + secondNum;
            sum = sum / thirdNum;
            sum = sum * fourthNum;

            Console.WriteLine(sum);
        }
    }
}
