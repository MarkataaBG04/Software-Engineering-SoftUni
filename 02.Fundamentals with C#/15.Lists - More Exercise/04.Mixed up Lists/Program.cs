namespace _04.Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToList();

            List<int> secondList = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToList();

            List<int> elements = new List<int>();

            int minCount = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < minCount; i++) 
            {
                elements.Add(firstList[i]);
                elements.Add(secondList[secondList.Count - 1 - i]);
            }

            int[] constrains = new int[2];

            if (firstList.Count > secondList.Count)
            {
                constrains[0] = firstList[firstList.Count - 2];
                constrains[1] = firstList[firstList.Count - 1];
            }
            else 
            {
                constrains[0] = secondList[1];
                constrains[1] = secondList[0];

            }

            int min = Math.Min(constrains[0], constrains[1]);
            int max = Math.Max(constrains[0], constrains[1]);

            List<int> result = new List<int>();

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] > min && elements[i] < max)
                {
                    result.Add(elements[i]);
                }
            }

            result.Sort();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
