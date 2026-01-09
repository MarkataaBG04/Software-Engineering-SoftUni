namespace _05.Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string message = "";

            for (int i = 1; i <= n; i++)
            {
                char character = char.Parse(Console.ReadLine());

                message = message + (char)(character + key);
            }

            Console.WriteLine(message);
        }
    }
}
