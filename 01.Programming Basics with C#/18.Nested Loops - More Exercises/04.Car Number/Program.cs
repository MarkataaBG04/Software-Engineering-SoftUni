using System;

namespace Car_Number
{
    class CarNumber
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());


            for (int firstDigit = firstNum; firstDigit <= secondNum; firstDigit++)
            {
                for (int secondDigit = firstNum; secondDigit <= secondNum; secondDigit++)
                {
                    for (int thirdDigit = firstNum; thirdDigit <= secondNum; thirdDigit++)
                    {
                        for (int fourthDigit = firstNum; fourthDigit <= secondNum; fourthDigit++)
                        {
                            if (firstDigit > fourthDigit)
                            {
                                if (firstDigit % 2 == 0 && fourthDigit % 2 != 0)
                                {
                                    if ((secondDigit + thirdDigit) % 2 == 0)
                                    {
                                        Console.Write($"{firstDigit}{secondDigit}{thirdDigit}{fourthDigit} ");
                                    }
                                }
                                else if (firstDigit % 2 != 0 && fourthDigit % 2 == 0)
                                {
                                    if ((secondDigit + thirdDigit) % 2 == 0)
                                    {
                                        Console.Write($"{firstDigit}{secondDigit}{thirdDigit}{fourthDigit} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}