namespace _06.Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> studentsAcademy = new Dictionary<string, Student>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsAcademy.ContainsKey(name))
                {
                    Student newStudent = new Student(name);
                    studentsAcademy.Add(name, newStudent);
                }

                    studentsAcademy[name].Grades.Add(grade);
            }

            foreach (var student in studentsAcademy.Values)
            {
                if (student.GetAverageGrade() >= 4.50)
                {
                    Console.WriteLine(student);
                }
            }

        }
    }
    class Student 
    {
        public Student(string studentName)
        {
            StudentName = studentName;
            Grades = new List<double>();
        }

        public string StudentName { get; set; }

        public List<double> Grades { get; set; }


        public override string ToString()
        {
            return $"{StudentName} -> {GetAverageGrade():f2}";
        }

        public double GetAverageGrade()
        {
            double sum = 0;

            foreach (double grade in Grades)
            {
                sum += grade;
            }

            return sum / Grades.Count;
        }
    }
}
