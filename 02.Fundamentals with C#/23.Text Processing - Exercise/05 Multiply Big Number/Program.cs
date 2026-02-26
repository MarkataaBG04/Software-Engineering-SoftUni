using System.Text;

namespace _05_Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder(capacity: number.Length + 1);

            int carry = 0;

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int result = (number[i] - '0') * multiplier + carry;

                sb.Append(result % 10);
                carry = result / 10;
            }

            if (carry != 0) 
            {
                sb.Append(carry);
            }

            for (int i = 0; i < sb.Length / 2; i++)
            {
                char temp = sb[i];
                sb[i] = sb[sb.Length - (i + 1)];
                sb[sb.Length - (i + 1)] = temp; 
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
