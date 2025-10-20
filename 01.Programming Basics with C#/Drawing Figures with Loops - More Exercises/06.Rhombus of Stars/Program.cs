namespace _06.Rhombus_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Горна част на ромба
            for (int row = 1; row <= n; row++)
            {
                // Отпечатваме водещи интервали
                for (int space = 0; space < n - row; space++)
                {
                    Console.Write(" ");
                }

                // Отпечатваме звездички
                Console.Write("*");
                for (int stars = 1; stars < row; stars++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }

            // Долна част на ромба
            for (int row = n - 1; row >= 1; row--)
            {
                // Отпечатваме водещи интервали
                for (int space = 0; space < n - row; space++)
                {
                    Console.Write(" ");
                }

                // Отпечатваме звездички
                Console.Write("*");
                for (int stars = 1; stars < row; stars++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
        }
    }
}