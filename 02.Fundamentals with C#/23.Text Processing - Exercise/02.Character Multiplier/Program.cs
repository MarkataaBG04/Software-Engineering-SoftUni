
namespace _02.Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            
            uint calculate = Calculate(input[0], input[1]);

            Console.WriteLine(calculate);
        }

        //static int Calculate(string word1, string word2)
        //{
        //    //int result = 0;

        //    //int m = Math.Min(word1.Length, word2.Length);

        //    //for (int i = 0; i < m; i++)
        //    //{
        //    //    result += word1[i] * word2[i];
        //    //}

        //    //for (int i = m; i < word1.Length; i++)
        //    //{
        //    //    result += word1[i];
        //    //}

        //    //for (int i = m; i < word2.Length; i++)
        //    //{
        //    //    result += word2[i];
        //    //}

        //    //return result;



        //}

        static uint Calculate(string word1, string word2) 
        {
            int m = Math.Max(word1.Length, word2.Length);

            uint result = 0;

            for (int i = 0; i < m; i++)
            {
                uint multiplier1 = 1, multiplier2 = 1;
                if (i < word1.Length)
                {
                    multiplier1 = word1[i];
                }
                if (i < word2.Length)
                {
                    multiplier2 = word2[i];
                }

                result += multiplier1 * multiplier2;
            }

            return result;
        }
    }
}
