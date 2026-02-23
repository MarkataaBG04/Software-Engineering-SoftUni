namespace _05.Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string text = Console.ReadLine();

            string letters = string.Empty;

            string digits = string.Empty;

            string other = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                //isDigit
                //is Letter
                // if not digit or if not letter --> other

                char currentChar = text[i];

                if (char.IsDigit(currentChar))
                {
                    digits += currentChar;
                }
                else if (char.IsLetter(currentChar))
                {
                    letters += currentChar;
                }
                else
                {
                    other += currentChar;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
