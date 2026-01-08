namespace _02.Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            while (number != 0)
            {
                int currentNum = number % 10;
                sum += currentNum;
                number = number / 10;
            }

            Console.WriteLine(sum);
        }
    }
}
