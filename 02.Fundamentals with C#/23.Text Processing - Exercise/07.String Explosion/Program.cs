using System.Text;

namespace _07.String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder(capacity: text.Length);


            int strenght = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    strenght += text[i + 1] - '0';
                    sb.Append(text[i]);
                }
                else if (strenght > 0)
                {
                    strenght--;
                }
                else 
                {
                    sb.Append(text[i]);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
