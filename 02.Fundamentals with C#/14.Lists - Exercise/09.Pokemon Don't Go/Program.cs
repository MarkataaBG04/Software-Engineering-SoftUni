namespace _09.Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequenceOfIntegers = Console.ReadLine()
                                           .Split()
                                           .Select(int.Parse)
                                           .ToList();

            int sum = 0;

            while (sequenceOfIntegers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int removedElement = 0;

                
                    if (index < 0)
                    {
                        removedElement = sequenceOfIntegers[0];
                        sum += removedElement;
                        int coppyLast = sequenceOfIntegers[sequenceOfIntegers.Count - 1];
                        sequenceOfIntegers.RemoveAt(0);
                        sequenceOfIntegers.Add(coppyLast);
                        IncreaseOrDecrease(sequenceOfIntegers, removedElement);
                    }
                    else if (index > sequenceOfIntegers.Count - 1)
                    {
                        removedElement = sequenceOfIntegers[sequenceOfIntegers.Count - 1];
                        sum += removedElement;
                        int coppyFirst = sequenceOfIntegers[0];
                        sequenceOfIntegers.RemoveAt(sequenceOfIntegers.Count - 1);
                        sequenceOfIntegers.Add(coppyFirst);
                        IncreaseOrDecrease(sequenceOfIntegers, removedElement);
                    }
                    else
                    {
                        removedElement = sequenceOfIntegers[index];
                        sum += removedElement;
                        sequenceOfIntegers.RemoveAt(index);
                        IncreaseOrDecrease(sequenceOfIntegers, removedElement);
                    }
                
            }

            Console.WriteLine(sum);
        }

        private static void IncreaseOrDecrease(List<int> sequenceOfIntegers, int currentNum)
        {
            for (int j = 0; j < sequenceOfIntegers.Count; j++)
            {
                if (currentNum >= sequenceOfIntegers[j])
                {
                    sequenceOfIntegers[j] += currentNum;
                }
                else if (currentNum <= sequenceOfIntegers[j])
                {
                    sequenceOfIntegers[j] -= currentNum;
                }
            }
        }
    }
}
