




namespace _11.Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string commandLine;

            while ((commandLine = Console.ReadLine()) != "end")
            {
                string[] commandArgs = commandLine.Split();
                // ["exchange", '1']

                switch (commandArgs[0])
                {
                    case "exchange":
                       int index = int.Parse(commandArgs[1]);
                       numbers = ExchangeElements(numbers, index);
                        break;
                    case "max":
                        string maxType = commandArgs[1];
                        PrintMaxIndex(numbers, maxType);
                        break;
                    case "min":
                        string minType = commandArgs[1];
                        PrintMinIndex(numbers, minType);
                        break;
                    case "first":
                        int firstCount = int.Parse(commandArgs[1]);
                        string firstType = commandArgs[2];
                        PrintFirstElements(numbers, firstCount, firstType);
                        break;
                    case "last":
                        int lastCount = int.Parse(commandArgs[1]);
                        string lastType = commandArgs[2];
                        PrintLastElements(numbers, lastCount, lastType);
                        break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        static void PrintFirstElements(int[] array, int count, string type)
        {
            if (count > array.Length)
            {
                Console.WriteLine($"Invalid count");
                return;
            }


            string firstElements = "";
            int elementCount = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                int number = array[i];
                if (IsOddOrEven(type, number))
                {
                    firstElements += $"{number}, ";    
                    elementCount++;
                    if (elementCount == count)
                    {
                        break;
                    }
                }
            }

            string result = firstElements.Trim(' ', ',');
            Console.WriteLine($"[{result}]");

        }

        static void PrintLastElements(int[] array, int count, string type)
        {
            if (count > array.Length)
            {
                Console.WriteLine($"Invalid count");
                return;
            }

            string lastElements = "";
            int elementCount = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                int number = array[i];
                if (IsOddOrEven(type, number))
                {
                    lastElements = $"{number}, " + lastElements;
                    elementCount++;
                    if (elementCount == count)
                    {
                        break;
                    }
                }
            }

            string result = lastElements.Trim(' ', ',');
            Console.WriteLine($"[{result}]");

        }

        static void PrintMinIndex(int[] array, string type)
        {
            int minIndex = -1;
            int minNumber = int.MaxValue;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                int number = array[i];
                if (IsOddOrEven(type, number))
                {
                    if (number <= minNumber)
                    {
                        minNumber = number;
                        minIndex = i;
                    }
                }
            }

            if (minIndex != -1)
            {
                Console.WriteLine(minIndex);
            }
            else
            {
                Console.WriteLine($"No matches");
            }
        }

        static void PrintMaxIndex(int[] array, string type)
        {
            int maxIndex = -1;
            int maxNumber = int.MinValue;

            for (int i = 0; i <= array.Length -1; i++)
            {
                int number = array[i];
                if (IsOddOrEven(type, number))
                {
                    if (number >= maxNumber)
                    {
                        maxNumber = number;
                        maxIndex = i;
                    }
                }
            }

            if (maxIndex != -1)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine($"No matches");
            }
        }

        static int[] ExchangeElements(int[] array, int indexOfExchange)
        {
            if (CheckForOutOfRange(array, indexOfExchange))
            {
                Console.WriteLine($"Invalid index");
                return array; 
            }


            int[] changedArray = new int[array.Length];

            int changedArrayIndex = 0;

            for (int i = indexOfExchange + 1; i <= array.Length - 1; i++)
            {
                changedArray[changedArrayIndex++] = array[i];

            }

            for (int i = 0; i <= indexOfExchange; i++)
            {
                changedArray[changedArrayIndex++] = array[i];
            }

            return changedArray;
        }

        static bool CheckForOutOfRange(int[] array, int indexOfExchange)
        {
            return indexOfExchange < 0 || indexOfExchange > array.Length - 1;
        }

        static bool IsOddOrEven(string type, int number)
        {
            return (type == "even" && number % 2 == 0) ||
                   (type == "odd" && number % 2 != 0);
        }
    }
}
