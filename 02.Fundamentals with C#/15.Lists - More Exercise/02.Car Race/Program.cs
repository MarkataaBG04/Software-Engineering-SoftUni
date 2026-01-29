

namespace _02.Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            double leftCarTime = LeftCar(numbers);
            double rightCarTime = RightCar(numbers);

            if (rightCarTime < leftCarTime)
            {
                Console.WriteLine($"The winner is right with total time: {rightCarTime}");
            }
            else
            {
                Console.WriteLine($"The winner is left with total time: {leftCarTime}");
            }
        }

        static double RightCar(List<int> numbers)
        {
            double result = 0;


            for (int i = numbers.Count - 1; i > numbers.Count / 2; i--)
            {
                if (numbers[i] == 0)
                {
                    result -= result * 0.20;
                }

                result += numbers[i];

            }

            return result;
        }

        static double LeftCar(List<int> numbers)
        {
            double result = 0;


            for (int i = 0; i < numbers.Count / 2; i++)
            {
                if (numbers[i] == 0)
                {
                    result -= result * 0.20;
                }

                result += numbers[i];

            }

            return result;
        }
    }
}
