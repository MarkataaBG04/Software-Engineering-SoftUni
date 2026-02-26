using System.Text;

namespace _04.Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] morseCode = Console.ReadLine().Split();

            StringBuilder stringBuilder = new StringBuilder(capacity: morseCode.Length);

            for (int i = 0; i < morseCode.Length; i++)
            {
                char word = MorseCode(morseCode[i]);
                stringBuilder.Append(word);
            }

            Console.WriteLine(stringBuilder.ToString().ToUpper());
        }

        public static char MorseCode(string v)
        {
            switch (v)
            {
                case ".-":
                    return 'a';
                case "-...":
                    return 'b';
                case "-.-.":
                    return 'c';
                case "-..":
                    return 'd';
                case ".":
                    return 'e';
                case "..-.":
                    return 'f';
                case "--.":
                    return 'g';
                case "....":
                    return 'h';
                case "..":
                    return 'i';
                case ".---":
                    return 'j';
                case "-.-":
                    return 'k';
                case ".-..":
                    return 'l';
                case "--":
                    return 'm';
                case "-.":
                    return 'n';
                case "---":
                    return 'o';
                case ".--.":
                    return 'p';
                case "--.-":
                    return 'q';
                case ".-.":
                    return 'r';
                case "...":
                    return 's';
                case "-":
                    return 't';
                case "..-":
                    return 'u';
                case "...-":
                    return 'v';
                case ".--":
                    return 'w';
                case "-..-":
                    return 'x';
                case "-.--":
                    return 'y';
                case "--..":
                    return 'z';
                default:
                    return ' ';
            }
        }
    }
}
