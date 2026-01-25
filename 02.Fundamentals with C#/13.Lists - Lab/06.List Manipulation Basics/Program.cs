


using System;

namespace _06.List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToList();

            string input;
            while ((input = Console.ReadLine()) != "end") 
            {
                string[] commandArgs = input.Split();

                switch (commandArgs[0])
                {
                    case "Add":
                        int numForAdd = int.Parse(commandArgs[1]);
                        numbers = AddToList(numbers, numForAdd);
                        break;
                    case "Remove":
                        int numForRemove = int.Parse(commandArgs[1]);
                        numbers = RemoveToList(numbers, numForRemove);
                        break;
                    case "RemoveAt":
                        int index = int.Parse(commandArgs[1]);
                        numbers = RemoveAtToList(numbers, index);
                        break;
                    case "Insert":
                        int numberForInsert = int.Parse(commandArgs[1]);
                        index = int.Parse(commandArgs[2]);
                        numbers = InsertToList(numbers, index ,numberForInsert);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> InsertToList(List<int> numbersExperiment, int specialIndex , int num)
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
