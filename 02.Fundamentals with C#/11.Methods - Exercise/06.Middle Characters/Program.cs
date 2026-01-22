
namespace _06.Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            MiddleCharacters(text);
        }

        static void MiddleCharacters(string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.WriteLine(text.Substring((text.Length / 2) - 1, 2));
            }
            else
            {
                Console.WriteLine(text[text.Length / 2]);
            }
        }
    }
}
