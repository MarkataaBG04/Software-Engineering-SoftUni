namespace _05.Students_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;

            List<Student> students = new List<Student>();

            while ((line = Console.ReadLine()) != "end")
            {
                string[] studentTokens = line.Split();

                string firstName = studentTokens[0];
                string lastName = studentTokens[1];
                string age = studentTokens[2];
                string homeTown = studentTokens[3];
                Student student = IsStudentExisting(students, firstName, lastName);

                if (student == null)
                {
                    students.Add(new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown
                    });
                }
                else
                {
                    student.Age = age;
                    student.HomeTown = homeTown;
                }



            }

            string filter = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == filter)
                {
                    Console.WriteLine(student.GetStudentInfromation);
                }
            }
        }

        private static Student IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            Student result = null;
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    result = student;

                }
            }

            return result;
        }
    } 

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Age { get; set; }

        public string HomeTown { get; set; }

        public string GetStudentInfromation
        {
            get
            {
                return $"{FirstName} {LastName} is {Age} years old.";
            }
        }
    }
}

