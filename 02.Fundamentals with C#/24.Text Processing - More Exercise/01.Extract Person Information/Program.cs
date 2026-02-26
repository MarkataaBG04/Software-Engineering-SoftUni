namespace _01.Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string text = Console.ReadLine();

                int pFrom = text.IndexOf('@') + 1;
                int pTo = text.LastIndexOf('|');

                string name = text.Substring(pFrom, pTo - pFrom);

                pFrom = text.IndexOf('#') + 1;
                pTo = text.LastIndexOf('*');

                int age = int.Parse(text.Substring(pFrom, pTo - pFrom));

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
