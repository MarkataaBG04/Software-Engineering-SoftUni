namespace _09.Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int firstNum = int.Parse(Console.ReadLine());
           int secondNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int j = firstNum; j <= secondNum; j++)
                {
                    count++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicNum})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{count} combinations - neither equals {magicNum}");
        }
    }
}