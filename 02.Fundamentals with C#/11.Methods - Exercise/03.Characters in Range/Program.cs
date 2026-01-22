
namespace _03.Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            CharactersInRange(a, b);
        }

        static void CharactersInRange(char first, char second)
        {
            string characters = "";

            if (second < first)
            {
                char temp = first;
                first = second;
                second = temp;
            }

            for (int i = first + 1; i < second; i++)
            {
                characters += $"{(char)i} ";
            }

            Console.WriteLine(characters);
        }
    }
}
