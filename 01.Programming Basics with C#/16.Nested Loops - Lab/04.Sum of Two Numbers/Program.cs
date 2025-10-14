namespace _04.Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int combinationCount = 0;

            for (int i = startNum; i <= endNum ; i++)
            {
                for (int j = startNum; j <= endNum; j++)
                {
                    combinationCount++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinationCount} ({i} + {j} = {magicNum})");
                        return;
                    }
                    
                }
            }

            Console.WriteLine($"{combinationCount} combinations - neither equals {magicNum}");
        }
    }
}