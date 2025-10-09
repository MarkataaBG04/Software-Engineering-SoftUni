namespace _02.Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int specialNum = int.MinValue;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > specialNum)
                {
                    specialNum = num;
                }

                
            }

            int sumWithoutMaxNumber = sum - specialNum;

            if (specialNum == sumWithoutMaxNumber)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {specialNum}");
            }
            else
            {
                int diff = Math.Abs(specialNum - sumWithoutMaxNumber);
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}