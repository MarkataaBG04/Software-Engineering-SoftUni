using System;

namespace _13.Prime_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialValueFirstPair = int.Parse(Console.ReadLine());
            int initialValueSecondPair = int.Parse(Console.ReadLine());
            int endingValueFirst = int.Parse(Console.ReadLine());
            int endingValueSecond = int.Parse(Console.ReadLine());

            for (int firstNums = initialValueFirstPair; firstNums <= initialValueFirstPair + endingValueFirst; firstNums++)
            {
                bool isPrimeFirst = true;

                if (firstNums < 2)
                {
                    isPrimeFirst = false;
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(firstNums); i++)
                    {
                        if (firstNums % i == 0)
                        {
                            isPrimeFirst = false;
                            break;
                        }
                    }
                }

                if (isPrimeFirst)
                {
                    for (int secondNums = initialValueSecondPair; secondNums <= initialValueSecondPair + endingValueSecond; secondNums++)
                    {
                        bool isPrimeSecond = true;

                        if (secondNums < 2)
                        {
                            isPrimeSecond = false;
                        }
                        else
                        {
                            for (int i = 2; i <= Math.Sqrt(secondNums); i++)
                            {
                                if (secondNums % i == 0)
                                {
                                    isPrimeSecond = false;
                                    break;
                                }
                            }
                        }

                        if (isPrimeSecond)
                        {
                            Console.WriteLine($"{firstNums}{secondNums}");
                        }
                    }
                }
            }
        }
    }
}
