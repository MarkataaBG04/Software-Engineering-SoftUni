
using System.Text;

namespace _07.Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
              int count = int.Parse(Console.ReadLine());

            string result = RepeatString(text, count);
            PrintResult(result);
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }

        static string RepeatString(string? text, int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= count; i++)
            {
                sb.Append(text);
            }

            return sb.ToString();
        }
    }
}
