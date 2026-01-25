




using System.Diagnostics.Metrics;

namespace _07.List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToList();

            int counter = 0;

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commandArgs = input.Split();

                switch (commandArgs[0])
                {
                    case "Add":
                        int numForAdd = int.Parse(commandArgs[1]);
                        numbers = AddToList(numbers, numForAdd);
                        counter++;
                        break;
                    case "Remove":
                        int numForRemove = int.Parse(commandArgs[1]);
                        numbers = RemoveToList(numbers, numForRemove);
                        counter++;
                        break;
                    case "RemoveAt":
                        int index = int.Parse(commandArgs[1]);
                        numbers = RemoveAtToList(numbers, index);
                        counter++;
                        break;
                    case "Insert":
                        int numberForInsert = int.Parse(commandArgs[1]);
                        index = int.Parse(commandArgs[2]);
                        numbers = InsertToList(numbers, index, numberForInsert);
                        counter++;
                        break;
                    case "Contains":
                        int numberContains = int.Parse(commandArgs[1]);
                        ContainsNumber(numbers, numberContains);
                        break;
                    case "PrintEven":
                        PrintEvenNums(numbers);
                        break;
                    case "PrintOdd":
                        PrintOddNums(numbers);
                        break;
                    case "GetSum":
                        int result = GetSum(numbers);
                        Console.WriteLine(result);
                        break;
                    case "Filter":
                        string filter = commandArgs[1];
                        int numberFilter = int.Parse(commandArgs[2]);
                        FilterNums(numbers, filter, numberFilter);
                        break;
                    default:
                        break;
                }
            }

            if (counter > 0 && counter != numbers.Count)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
            
        

        static void FilterNums(List<int> numbers, string filter, int numberFilter)
        {
            List<int> result = new List<int>();


            for (int i = 0; i < numbers.Count; i++)
            {
                if (filter == "<")
                {
                    if (numbers[i] < numberFilter)
                    {
                        result.Add(numbers[i]);
                    }
                }
                else if (filter == ">")
                {
                    if (numbers[i] > numberFilter)
                    {
                        result.Add(numbers[i]);
                    }
                }
                else if (filter == "<=")
                {
                    if (numbers[i] <= numberFilter)
                    {
                        result.Add(numbers[i]);
                    }
                }
                else if (filter == ">=")
                {
                    if (numbers[i] >= numberFilter)
                    {
                        result.Add(numbers[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }

        static int GetSum(List<int> numbers)
        {
            int result = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                result += numbers[i];
            }

            return result;
        }

        static void PrintOddNums(List<int> numbers)
        {
            List<int> oddNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", oddNumbers));
        }

        static void PrintEvenNums(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", evenNumbers));
        }

        static void ContainsNumber(List<int> numbers, int numberContains)
        {
            if (numbers.Contains(numberContains))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine($"No such number");
            }
                
        }

        static List<int> InsertToList(List<int> numbersExperiment, int specialIndex, int num)
        {
            numbersExperiment.Insert(specialIndex, num);

            return numbersExperiment;
        }

        static List<int> RemoveAtToList(List<int> numbersExperiment, int specialIndex)
        {
            numbersExperiment.RemoveAt(specialIndex);

            return numbersExperiment;
        }

        static List<int> RemoveToList(List<int> numbersExperiment, int num)
        {
            numbersExperiment.Remove(num);

            return numbersExperiment;
        }

        static List<int> AddToList(List<int> numbersExperiment, int num)
        {
            numbersExperiment.Add(num);

            return numbersExperiment;
        }
    }
}

