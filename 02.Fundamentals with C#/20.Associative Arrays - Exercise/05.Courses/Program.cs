namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Course> coursesMap = new Dictionary<string, Course>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split(" : ");
                string courseName = arguments[0];
                string studentName = arguments[1];

                if (!coursesMap.ContainsKey(courseName))
                {
                    Course newCourse = new Course(courseName);
                    coursesMap.Add(courseName, newCourse);
                }

                coursesMap[courseName].StudentNames.Add(studentName);

            }

            foreach (Course course in coursesMap.Values)
            {
                Console.WriteLine(course);
            }
        }
    }

    class Course 
    {
        public Course(string name)
        {
            Name = name;
            StudentNames = new List<string>();
        }

        public string Name { get; set; }

        public List<string> StudentNames { get; set; }

        public override string ToString()
        {
            string result = $"{Name}: {StudentNames.Count}\n";


            for (int i = 0; i < StudentNames.Count; i++)
            {
                result += $"-- {StudentNames[i]}\n";
            }

            return result.Trim();
        }
    }
}
