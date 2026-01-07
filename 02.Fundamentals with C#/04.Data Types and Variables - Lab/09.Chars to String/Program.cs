namespace _09.Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            string word = first + "" + second + "" + third;
            Console.WriteLine(word);
        }
    }
}
