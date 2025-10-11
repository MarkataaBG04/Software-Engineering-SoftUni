using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // прочитаме броя на двойките
        int previousSum = 0;                   // ще пази сумата от предишната двойка
        int maxDiff = 0;                       // максималната разлика между двойки
        bool isFirstPair = true;               // флаг за първата двойка

        for (int i = 0; i < n; i++)
        {
            // четем двете числа от текущата двойка
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int currentSum = num1 + num2; // изчисляваме сумата на двойката

            if (isFirstPair)
            {
                previousSum = currentSum;
                isFirstPair = false;
            }
            else
            {
                int diff = Math.Abs(currentSum - previousSum);
                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }
                previousSum = currentSum;
            }
        }

        // проверяваме резултата
        if (maxDiff == 0)
        {
            Console.WriteLine($"Yes, value={previousSum}");
        }
        else
        {
            Console.WriteLine($"No, maxdiff={maxDiff}");
        }
    }
}
