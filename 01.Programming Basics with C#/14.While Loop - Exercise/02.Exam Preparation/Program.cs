namespace _02.Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poorGradesCount = int.Parse(Console.ReadLine());

            string exerciseName = Console.ReadLine();

            int poorGrades = 0;

            double averageGrades = 0;

            double problemsCount = 0;

            string lastProblem = "";

            while (exerciseName != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                         

                if (grade <= 4)
                {
                    poorGrades++;
                    if (poorGrades == poorGradesCount)
                    {
                        Console.WriteLine($"You need a break, {poorGrades} poor grades.");
                        return;
                    }
                }
                averageGrades += grade;
                problemsCount++;
                lastProblem = exerciseName;
                exerciseName = Console.ReadLine();
            }

            if (exerciseName == "Enough")
            {
                Console.WriteLine($"Average score: {averageGrades / problemsCount:F2}");
                Console.WriteLine($"Number of problems: {problemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}