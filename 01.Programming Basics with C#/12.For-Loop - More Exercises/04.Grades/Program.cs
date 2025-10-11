namespace _04.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            int topStudents = 0;
            int goodStudents = 0;
            int averageStudents = 0;
            int failStudents = 0;
            double average = 0;

            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                average += grade;

                if (grade >= 5.00)
                {
                    topStudents++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    goodStudents++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    averageStudents++;
                }
                else if (grade < 3.00)
                {
                    failStudents++;
                }
            }

            Console.WriteLine($"Top students: {(double)topStudents/students * 100:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(double)goodStudents/students * 100:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(double)averageStudents/students * 100:F2}%");
            Console.WriteLine($"Fail: {(double)failStudents/students * 100:F2}%");
            Console.WriteLine($"Average: {average / students:f2}");

        }
    }
}