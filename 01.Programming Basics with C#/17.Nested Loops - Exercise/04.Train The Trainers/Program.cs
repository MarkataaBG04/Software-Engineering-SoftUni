namespace _04.Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();

            double average = 0;

            int allGrades = 0;

            while (presentation != "Finish")
            {
                double input = 0;
                double grades = 0;
                for (int i = 1; i <= judges; i++)
                {
                     input = double.Parse(Console.ReadLine());

                    grades += input;
                    average += input;
                    allGrades++;
                }

                Console.WriteLine($"{presentation} - {grades/judges:f2}.");
                presentation = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {average/allGrades:f2}.");
        }
    }
}