

namespace _02.Change_List
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
                    case "Delete":
                        int deleteElement = int.Parse(commandArgs[1]);
                        numbers = DeleteMethod(numbers, deleteElement);
                        break;
                    case "Insert":
                        int insertElemnt = int.Parse(commandArgs[1]);
                        int position = int.Parse(commandArgs[2]);
                        numbers = InsertMethod(numbers, insertElemnt, position);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> InsertMethod(List<int> listOfNums, int numInsert, int index)
        {
            listOfNums.Insert(index, numInsert);
            
            return listOfNums;
        }

        static List<int> DeleteMethod(List<int> listOfNums, int numToBeDeleted)
        {
            while (listOfNums.Contains(numToBeDeleted))
            {
                listOfNums.Remove(numToBeDeleted);
            }



            return listOfNums;
        }
    }
}
