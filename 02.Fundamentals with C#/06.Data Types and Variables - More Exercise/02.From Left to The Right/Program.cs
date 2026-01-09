namespace _02.From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                long sum = 0;
                string[] numbers = Console.ReadLine().Split();

                long leftNum = long.Parse(numbers[0]);
                long rightNum = long.Parse(numbers[1]);

                if (leftNum > rightNum)
                {
                    leftNum = Math.Abs(leftNum);
                    while (leftNum != 0)
                    {

                        long currentDigit = leftNum % 10;
                        sum += currentDigit;
                        leftNum = leftNum / 10;
                    }
                }
                else
                {
                    rightNum = Math.Abs(rightNum);
                    while (rightNum != 0)
                    {
                        long currentDigit = rightNum % 10;
                        sum += currentDigit;
                        rightNum = rightNum / 10;
                    }
                }

                Console.WriteLine(sum);
            }


        }
    }
}
