
using System.Diagnostics.Metrics;

namespace _02.Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int count = VowelsCount(word);

            Console.WriteLine(count);
        }

        static int VowelsCount(string input)
        {
            int count = 0;

            string vowels = "aeiouAEIOU";

            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                    count++;
            }


            return count;
        }
    }
}
