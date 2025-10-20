namespace _02.Letters_Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char lastSymbol = char.Parse(Console.ReadLine());
            char forbiddenSymbol = char.Parse(Console.ReadLine());

            int totalCombinations = 0;

            string word = "";

            for(char i  = firstSymbol; i <= lastSymbol; i++)
            {
                for (char j = firstSymbol; j <= lastSymbol; j++)
                {
                    for (char k = firstSymbol; k <= lastSymbol; k++)
                    {
                        if (i != forbiddenSymbol && j != forbiddenSymbol && k != forbiddenSymbol)
                        {
                            totalCombinations++;
                            word += $"{i}{j}{k} ";
                        }
                    }
                }

            }

            Console.Write($"{word}{totalCombinations}");
        }
    }
}