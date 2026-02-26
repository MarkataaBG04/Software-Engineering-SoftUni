namespace _02.Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string randomText = Console.ReadLine();

            int result = 0;

            for (int i = 0; i < randomText.Length; i++)
            {

                char current = randomText[i];
                if (current > firstChar && current < secondChar)
                {
                    result += current;
                }
            }

            Console.WriteLine(result);
        }
    }
}
