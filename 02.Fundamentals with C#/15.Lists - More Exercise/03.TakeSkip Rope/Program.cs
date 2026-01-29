using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TakeSkip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вход: encrypted message
            List<char> symbols = Console.ReadLine().ToList();

            // Списък за цифрите
            List<int> numbers = new List<int>();

            // Взимаме цифрите и махаме от символите
            for (int i = 0; i < symbols.Count; i++)
            {
                if (Char.IsDigit(symbols[i]))
                {
                    numbers.Add(symbols[i] - '0');
                    symbols.RemoveAt(i);
                    i--;
                }
            }

            // Разделяме на take и skip списъци
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                    takeList.Add(numbers[i]);
                else
                    skipList.Add(numbers[i]);
            }

            // Резултатът
            string result = "";
            int currentIndex = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                int takeCount = takeList[i];
                int skipCount = skipList[i];

                // Вземаме takeCount символа
                if (currentIndex + takeCount > symbols.Count)
                    takeCount = symbols.Count - currentIndex;

                result += string.Concat(symbols.Skip(currentIndex).Take(takeCount));

                // Преместваме индекса с take + skip
                currentIndex += takeCount + skipCount;

                if (currentIndex >= symbols.Count)
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
