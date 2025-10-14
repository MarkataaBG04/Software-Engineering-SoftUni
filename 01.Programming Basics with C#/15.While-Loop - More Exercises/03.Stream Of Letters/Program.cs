namespace _03.Stream_Of_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command  = Console.ReadLine();

            string word = "";

            string secretCommand = "";

            int countN = 0;
            int countO = 0;
            int countC = 0;
            string sentence = "";

            while (command != "End")
            {
                char symbols = char.Parse(command);
                if ((symbols >= 'a' && symbols <= 'z') || (symbols >= 'A' && symbols <= 'Z'))
                {
                    if ((symbols == 'n' && countN < 1)|| (symbols == 'o' && countO < 1) || (symbols == 'c' && countC < 1))
                    {
                        if (symbols == 'n')
                        {
                            secretCommand += 'n';
                            countN++;
                        }
                        else if (symbols == 'o')
                        {
                            secretCommand += 'o';
                            countO++;
                        }
                        else if (symbols == 'c')
                        {
                            secretCommand += 'c';
                            countC++;
                        }
                    }
                    else
                    {
                        word += symbols;
                    }
                    if ((secretCommand.Contains('n') && countN == 1) && (secretCommand.Contains('o') && countO ==1) && (secretCommand.Contains('c') && countC == 1))
                    {
                        
                        word += " ";

                        sentence += word;
                        word = "";
                        countO = 0;
                        countN = 0;
                        countC = 0;
                    }

                }
                



                command = Console.ReadLine();
            }
            Console.WriteLine(sentence);
        }
    }
}