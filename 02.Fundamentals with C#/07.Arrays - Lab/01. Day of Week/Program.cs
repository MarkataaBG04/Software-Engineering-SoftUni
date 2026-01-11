using System.Linq;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type name = value
            //int[] numbers = new int[10];// empty array with ten elements
            //// int[] numbers3 =  new []{1,2, 3, 4, 5,6,7,8,9,10}; aray with 10 elements
            //// int[] numbers2 = {1,2, 3, 4, 5,6,7,8,9,10}; array with 10 elemets

            //numbers[0] = 5;
            //numbers[6] = 12;
            //numbers[9] = 100;

            //string numbersAsValues = Console.ReadLine();

            //int[] splittedStringValue = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();



            //// i -- > index --> 0
            //for (int i = 0; i <= numbers.Length-1; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            string[] daysOfWeek = {"Monday" , "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 7)
            {
                Console.WriteLine($"Invalid day!");
            }
            else
            {
                Console.WriteLine($"{daysOfWeek[n-1]}");
            }


        }
    }
}
