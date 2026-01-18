namespace _05.Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();



            for (int i = 0; i < arr.Length; i++) 
            {
                bool isItBigger = true;
                for (long j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        isItBigger = false;
                    }
                }

                if (isItBigger)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
