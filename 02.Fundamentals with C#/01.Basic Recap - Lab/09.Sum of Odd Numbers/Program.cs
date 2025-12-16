namespace _09.Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int numbers = i * 2 - 1;
                Console.WriteLine(numbers);
                sum += numbers;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}