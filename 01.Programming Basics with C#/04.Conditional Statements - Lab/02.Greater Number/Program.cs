namespace _02.Greater_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете две цели числа въведени от потребителя и отпечатва по-голямото от двете. 

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a >= b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}