namespace _03.Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            while (sum != number && sum < number )
            {

                int numbers = int.Parse(Console.ReadLine());
                sum += numbers;
            }
            Console.WriteLine(sum);
        }
    }
}