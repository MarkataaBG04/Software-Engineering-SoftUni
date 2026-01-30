namespace _04.Students
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

                Student student = new Student() 
                {
                    FirstName = studentTokens[0],
                    LastName = studentTokens[1],
                    Age = int.Parse(studentTokens[2]),
                    HomeTown = studentTokens[3]
                };

                students.Add(student);
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
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

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
