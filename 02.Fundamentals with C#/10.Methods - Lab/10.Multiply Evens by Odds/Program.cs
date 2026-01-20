namespace _10.Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0 )
            {
                number = Math.Abs(number);
            }

            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            int result = GetMultipleOfEvenAndOdds(evenSum, oddSum);

            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int evenSum = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 != 0)
                {
                    evenSum += currentDigit;
                }

                number = number / 10;
            }

            return evenSum;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;
            while (number > 0)
            {             
                int currentDigit = number % 10;
                if (currentDigit % 2 == 0) 
                {
                    evenSum += currentDigit;
                }

               number =  number / 10;
            }

            return evenSum;
        }
    }
}
