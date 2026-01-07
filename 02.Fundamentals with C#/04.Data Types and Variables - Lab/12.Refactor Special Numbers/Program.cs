namespace _12.Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool isSpecial = false;

            for (int num = 1; num <= n; num++)

            {
                int currentNum = num;
                int sum  = 0;

                while (currentNum > 0)

                {
                    sum += currentNum % 10;

                    currentNum = currentNum / 10;
                }

                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", num, isSpecial);

            }
        }
    }
}
