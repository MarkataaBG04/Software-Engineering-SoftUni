namespace _01.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> contests = new Dictionary<string,string>();
            string input;

            while ((input = Console.ReadLine()) != "end of contests") 
            {
                string[] arguments = input.Split(":");
                string contest = arguments[0];
                string passowrd = arguments[1];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, passowrd);
                }
            }

            Dictionary<string, Student> students = new Dictionary<string, Student>();

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] arguments = input.Split("=>");
                string contest = arguments[0];
                string passowrd = arguments[1];
                string username = arguments[2];
                int points = int.Parse(arguments[3]);

                if (contests.ContainsKey(contest))
                {
                    if (contests[contest] == passowrd)
                    {
                        Student newStudent = new Student(username, points);
                        if (!students.ContainsKey(username))
                        {
                            students.Add(username, newStudent);
                        }
                        if (!students[username].ContestStats.ContainsKey(contest))
                        {
                            students[username].ContestStats.Add(contest, points);
                        }
                        else 
                        {
                            if (students[username].ContestStats[contest] < points)
                            {
                                students[username].ContestStats[contest] = points;
                            }
                        }
                    }
                }

            }


            var bestStudent = students
                                .OrderByDescending(s => s.Value.ContestStats.Values.Sum())
                                .First();

            int totalPoints = bestStudent.Value.ContestStats.Values.Sum();

            Console.WriteLine($"Best candidate is {bestStudent.Key} with total {totalPoints} points.");
            Console.WriteLine($"Ranking:");

            var orderedStudents = students.OrderBy(s => s.Key);

            foreach (var student in orderedStudents)
            {
                // 2️⃣ За всеки студент сортираме контестите по точки (низходящо)
                var contestsOrdered = student.Value.ContestStats
                    .OrderByDescending(c => c.Value);

                // 3️⃣ Принтираме името на студента
                Console.WriteLine(student.Key);

                // 4️⃣ Принтираме контестите с точките
                foreach (var contest in contestsOrdered)
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }


        }
    }

    class Student
    {
        public Student(string userName, int points)
        {
            UserName = userName;
            ContestStats = new Dictionary<string, int>();
        }

        public string UserName { get; set; }


        public Dictionary<string,int> ContestStats { get; set; }
    }
}
