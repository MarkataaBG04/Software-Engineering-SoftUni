namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double totalGrades = 0;
            int grade = 1;        // текущ клас
            int fails = 0;        // брояч за слабите оценки

            while (grade <= 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());

                if (currentGrade >= 4.00)
                {
                    totalGrades += currentGrade;
                    grade++;
                }
                else
                {
                    fails++;

                    if (fails == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        return;
                    }
                }
            }

            double average = totalGrades / 12;
            Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
        }
    }
}