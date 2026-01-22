

using static System.Net.Mime.MediaTypeNames;

namespace _04.Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passwod = Console.ReadLine();

            if (LenghtPass(passwod) == false)
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
            }

            if (OnlyLettersAndDigits(passwod) == false)
            {
                Console.WriteLine($"Password must consist only of letters and digits");
            }

            if (AtLeast2Digits(passwod) == false)
            {
                Console.WriteLine($"Password must have at least 2 digits");
            }

            if (AtLeast2Digits(passwod) == true && LenghtPass(passwod) && OnlyLettersAndDigits(passwod) == true)
            {
                Console.WriteLine($"Password is valid");
            }
        }

        private static bool AtLeast2Digits(string input)
        {
            bool contains2Digits = false;

            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                contains2Digits = true;
            }

            return contains2Digits;
        }

        static bool OnlyLettersAndDigits(string input)
        {
            bool isNumberOrString = false;
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) || char.IsLetter(input[i]))
                {
                    count++;  
                }
            }
            if (count == input.Length)
            {
                isNumberOrString = true;
            }


            return isNumberOrString;
        }

        static bool LenghtPass(string input)
        {
            bool isLongEnough = false;

            if (input.Length >= 6 && input.Length <= 10)
            {
                isLongEnough = true;
            }

            return isLongEnough;
        }
    }
}
