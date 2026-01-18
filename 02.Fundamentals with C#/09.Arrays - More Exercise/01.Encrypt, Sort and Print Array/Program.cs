namespace _01.Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] arr = new string[n];
            int[] sortedArr = new int[n];

            char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < n; i++) 
            {
                int sum = 0;
                arr[i] = Console.ReadLine();
                

                char[] words = arr[i].ToCharArray();
                

                for (int j = 0; j < words.Length; j++)
                {
                    
                    if (words[j] == 'a' || words[j] == 'e' || words[j] == 'i' || words[j] == 'o' || words[j] == 'u' ||
                        words[j] == 'A' || words[j] == 'E' || words[j] == 'I' || words[j] == 'O' || words[j] == 'U')
                    {
                        sum += (words[j] * words.Length); 
                    }
                    else
                    {
                        sum += (words[j] / words.Length);
                    }
                    
                }
                sortedArr[i] = sum;
            }


            Array.Sort(sortedArr);
            foreach (int i in sortedArr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
