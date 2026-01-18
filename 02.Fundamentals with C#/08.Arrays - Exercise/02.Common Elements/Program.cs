namespace _02.Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                        .Split();
            string[] secondArr = Console.ReadLine()
                        .Split();

            string common = "";

            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (secondArr[i] == firstArr[j])
                    {
                        common += $"{secondArr[i]} ";
                    }
                }
            }

            Console.WriteLine(common);
        }
    }
}
