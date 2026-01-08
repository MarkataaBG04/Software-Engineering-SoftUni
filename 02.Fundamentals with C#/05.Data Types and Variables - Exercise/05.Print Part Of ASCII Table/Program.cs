namespace _05.Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startInput = int.Parse(Console.ReadLine());
            int endInput = int.Parse(Console.ReadLine());

            string word = "";

            for (int symbol = startInput; symbol <= endInput; symbol++)
            {
                word += (char)symbol + " ";
            }

            Console.WriteLine($"{word}");
        }
    }
}
