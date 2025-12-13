namespace _59.The_Most_Powerful_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            int wordBestPoints = int.MinValue;
            string bestWord = string.Empty;
            string command = Console.ReadLine();

            while (command != "End of words")
            {
                int points = 0;
                foreach (char ch in command)
                {
                    points += ch;
                }

                char firstChar = char.ToLower(command[0]);

                if (firstChar == 'a' || firstChar == 'e' || firstChar == 'i' ||
                    firstChar == 'o' || firstChar == 'u' || firstChar == 'y')
                {
                    points = points * command.Length;
                }
                else
                {
                    points = (int)(Math.Floor((double)points / command.Length));
                }

                if (points > wordBestPoints)
                {
                    wordBestPoints = points;
                    bestWord = command;
                }
               

                command = Console.ReadLine();
            }

            Console.WriteLine($"The most powerful word is {bestWord} - {wordBestPoints}");
        }
    }
}
