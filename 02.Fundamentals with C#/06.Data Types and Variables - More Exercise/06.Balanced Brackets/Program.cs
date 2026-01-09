using System;

namespace _06.Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool hasOpenBracket = false;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    if (hasOpenBracket)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }

                    hasOpenBracket = true;
                }
                else if (input == ")")
                {
                    if (!hasOpenBracket)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }

                    hasOpenBracket = false;
                }
            }

            if (hasOpenBracket)
            {
                Console.WriteLine("UNBALANCED");
            }
            else
            {
                Console.WriteLine("BALANCED");
            }
        }
    }
}
