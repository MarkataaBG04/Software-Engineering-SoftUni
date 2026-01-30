namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] studentAsString = Console.ReadLine().Split();

                Student newStudnet = new Student(studentAsString[0], studentAsString[1], double.Parse(studentAsString[2]));

                students.Add(newStudnet);
            }

             List<Student> orderedStudents = students.OrderByDescending(student => student.Grade).ToList();

            foreach (Student student in orderedStudents) 
            {
                Console.WriteLine(student);
            }
        }
    }
    class Student 
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }

    }

}
