namespace _04.List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split();
                switch (commandArgs[0])
                {
                    case "Add":
                        list.Add(int.Parse(commandArgs[1]));
                        break;
                    case "Insert":
                        int number = int.Parse(commandArgs[1]);
                        int indexInsert = int.Parse(commandArgs[2]);
                        if (IsNotValidIndex(indexInsert, list.Count))
                        {
                            Console.WriteLine($"Invalid index");
                            continue;
                        } 
                        list.Insert(indexInsert, number);
                        break;
                    case "Remove":
                        int removeIndex = int.Parse(commandArgs[1]);
                        if (IsNotValidIndex(removeIndex, list.Count))
                        {
                            Console.WriteLine($"Invalid index");
                            continue;
                        }
                        list.RemoveAt(removeIndex);
                        break;
                    case "Shift":
                        string direction = commandArgs[1];
                        int count = int.Parse(commandArgs[2]);
                        list = Shift(list, direction, count);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }

        static List<int> Shift(List<int> list, string direction, int count)
        {
            count %= list.Count;

            if (direction == "left")
            {
                List<int> shiftedPart = list.GetRange(0, count);
                list.RemoveRange(0, count);
                list.InsertRange(list.Count, shiftedPart);
            }
            else if (direction == "right")
            {
                List<int> shiftedPart = list.GetRange(list.Count - count, count);
                list.RemoveRange(list.Count - count, count);
                list.InsertRange(0, shiftedPart);
            }

            return list;
        }

        private static bool IsNotValidIndex(int index, int lastIndex)
        {
            return index < 0 || index >= lastIndex;
        }
    }
}
