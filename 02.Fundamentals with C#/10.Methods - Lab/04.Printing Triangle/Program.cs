namespace _04.Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                PrintLine(1, n);
            }

            for (int row = n - 1; row >= 1; row--)
            {
                PrintLine(1, n);
            }
        }

        private static void PrintLine(int start, int end)
        {
            for (int col = start; col <= end; col++)
            {
                Console.Write($"{col} ");
            }
            Console.WriteLine();
        }
    }
}
