namespace _09.Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int leftNumbers = int.Parse(Console.ReadLine());
                leftSum += leftNumbers;
            }

            for (int i = 1; i <= n; i++)
            {
                int rightNumbers = int.Parse(Console.ReadLine());
                rightSum += rightNumbers;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum-rightSum)}");
            }
        }
    }
}