

namespace _10.Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            TopInteger(n);
        }

        static void TopInteger(int n)
        {
            
            for (int i = 1; i <= n; i++)
            {
                int currentNum = i;
                bool isContainOddNum = IsContainOdd(currentNum);
                bool isDivisible = IsDivisbleBy8(currentNum);

                if (isContainOddNum && isDivisible)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsDivisbleBy8(int currentNum)
        {
            bool isDivisible = false;
            int result = 0;
            while (currentNum != 0)
            {
                int currentDigit = currentNum % 10;
                result += currentDigit;
                currentNum /= 10;
            }
            if (result % 8 == 0)
            {
                isDivisible = true;
            }
            
            return isDivisible;
        }

        static bool IsContainOdd(int currentNum)
        {
            bool isContainOddNum = false;
            while (currentNum != 0)
            {
                int currentDigit = currentNum % 10;
                if (currentDigit % 2 != 0)
                {
                    isContainOddNum = true;
                    break;
                }
                currentNum /= 10;
            }

           return isContainOddNum;
        }
    }
}
