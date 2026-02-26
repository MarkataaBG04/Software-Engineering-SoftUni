using System.Text;

namespace _04.Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            //1. char[] -> new string()
            //2. StringBuilder -> .ToString()

            StringBuilder result = new StringBuilder(capacity: text.Length);
            for (int i = 0; i < text.Length; i++) 
            {
                char substitute = (char)(text[i] + 3);
                result.Append(substitute);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
