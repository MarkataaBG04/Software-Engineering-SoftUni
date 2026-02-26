namespace _08.Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double result = 0;

            for (int i = 0; i < data.Length; i++)
            {
                string currentWord = data[i];
                char prefix = currentWord[0];
                char suffix = currentWord[currentWord.Length-1];

                double score = int.Parse(currentWord.Substring(1, currentWord.Length - 2));

                if (char.IsUpper(prefix))
                {
                    score /= prefix - 'A' + 1; 
                }
                else
                {
                    score *= prefix - 'a' + 1;
                }

                if (char.IsUpper(suffix))
                {
                    score -= suffix - 'A' + 1;
                }
                else
                {
                    score += suffix - 'a' + 1;
                }

                result += score;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
