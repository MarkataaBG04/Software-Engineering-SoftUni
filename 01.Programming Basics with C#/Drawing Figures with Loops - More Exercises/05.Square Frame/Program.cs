namespace _05.Square_Frame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Горен ред
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

            // Средни редове
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write("| ");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }

            // Долен ред
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
        }
    }
}