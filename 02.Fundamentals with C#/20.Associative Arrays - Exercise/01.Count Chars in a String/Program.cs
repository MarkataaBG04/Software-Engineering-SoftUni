namespace _01.Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, uint> charOccurrences = new Dictionary<char, uint>();

            for (int i = 0; i < input.Length; i++)
            {
                char character = input[i];

                if (character == ' ')
                {
                    continue;
                }

                if (!charOccurrences.ContainsKey(character))
                {
                    charOccurrences.Add(character, 0);
                }

                charOccurrences[character]++;
                
            }

            foreach (KeyValuePair<char, uint> charPair in charOccurrences) 
            {
                Console.WriteLine($"{charPair.Key} -> {charPair.Value}");
            }

            
        }
    }
}
