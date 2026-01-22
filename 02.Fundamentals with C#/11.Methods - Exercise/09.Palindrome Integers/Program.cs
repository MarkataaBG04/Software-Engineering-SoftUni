
namespace _09.Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsNumPalindrome(input));
            }
        }

        static bool IsNumPalindrome(string input)
        {
            //12321
            
            string firstHalf = input.Substring(0, input.Length / 2);

            //12

            char[] charrArr = input.ToCharArray();
            // ['1', '2', '3', '2', '1']

            Array.Reverse(charrArr);
            // ['1', '2', '3', '2', '1']

            string temp = new string(charrArr);
            //"12321"

            string lastHalf = temp.Substring(0, temp.Length / 2);
            //12

            return firstHalf == lastHalf; ;
            // return to Main Method the value true or false 
        }
    }
}
