using System.Collections.Concurrent;

namespace _08.Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> arrayData = Console.ReadLine()
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                    .ToList();

            string input;

            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] commandArgs = input.Split();

                switch (commandArgs[0])
                {
                    case "merge":
                        int startIndex = int.Parse(commandArgs[1]);
                        int endIndex = int.Parse(commandArgs[2]);
                        arrayData = Merge(arrayData, startIndex, endIndex);
                        break;
                    case "divide":
                        int index = int.Parse(commandArgs[1]);
                        int partitions = int.Parse(commandArgs[2]);
                        arrayData = Divide(arrayData, index, partitions);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", arrayData));
        }

        static List<string> Divide(List<string> arrayData, int index, int partitions)
        {
            List<string> temp = new List<string>();
            string toDivide = arrayData[index];
            int partitionLength = toDivide.Length / partitions;
            int additionalPartLength = toDivide.Length % partitions;
            //this will be 0 if the amount of substrings is even number

            for (int i = 0; i < partitions; i++)
            {
                if (i == partitions - 1)
                {
                    partitionLength += additionalPartLength;
                } 
                //adds the additional length to the last element
                temp.Add(toDivide.Substring(0, partitionLength));
                //adds in temp the substring from toDivide from index 0 to the length of the partition
                toDivide = toDivide.Remove(0, partitionLength);
                //removes from toDivide the substring we just added
            }

            arrayData.RemoveAt(index);
            //removes the original string
            arrayData.InsertRange(index, temp);
            //insert the new list temp to data from the given index

            return arrayData;
        }

        static List<string> Merge(List<string> arrayData, int startIndex, int endIndex)
        {
            if (startIndex < 0) 
            {
                startIndex = 0;
            }

            if (startIndex > arrayData.Count - 1) 
            {
                startIndex = arrayData.Count - 1;
            }

            if (endIndex < 0) 
            {
                endIndex = 0;
            }

            if (endIndex > arrayData.Count - 1) 
            {
                endIndex = arrayData.Count - 1;
            } 

            List<string> temp = new List<string>();
            for (int i = startIndex; i <= endIndex; i++)
            {
                temp.Add(arrayData[i]);
                //add to a temp list the elements we want to merge
            }

            arrayData[startIndex] = string.Join("", temp);

            //the value at startIndex in arrayData becomes temp
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                arrayData.RemoveAt(startIndex + 1);
                //removes the items between the starting and ending index
            }

            return arrayData;
        }
    }
}
