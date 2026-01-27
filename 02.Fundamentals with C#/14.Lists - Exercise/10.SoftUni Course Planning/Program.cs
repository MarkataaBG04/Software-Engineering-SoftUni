




namespace _10.SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> course = Console.ReadLine()
                                    .Split(", ")
                                    .ToList();

            string input;

            while ((input = Console.ReadLine()) != "course start") 
            {
                string[] commandArgs = input.Split(":");

                switch (commandArgs[0])
                {
                    case "Add":
                        string lessonTitle = commandArgs[1];
                        course = Add(course, lessonTitle);
                        break;
                    case "Insert":
                        lessonTitle = commandArgs[1];
                        int index = int.Parse(commandArgs[2]);
                        course = Insert(course, lessonTitle, index);
                        break;
                    case "Remove":
                        lessonTitle = commandArgs[1];
                        course = Remove(course, lessonTitle);
                        break;
                    case "Swap":
                        lessonTitle = commandArgs[1];
                        string secondLessonTitle = commandArgs[2];
                        course = Swap(course, lessonTitle, secondLessonTitle);
                        break;
                    case "Exercise":
                        lessonTitle = commandArgs[1];
                        course = Exercise(course, lessonTitle);
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < course.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{course[i]}");
            }
        }

        static List<string> Exercise(List<string> course, string lessonTitle)
        {
            if (course.Contains(lessonTitle))
            {
                if (!course.Contains($"{lessonTitle}-Exercise"))
                {
                    int index = course.IndexOf(lessonTitle);
                    course.Insert(index + 1, $"{lessonTitle}-Exercise");
                }
            }
            else
            {
                course.Add(lessonTitle);
                course.Add($"{lessonTitle}-Exercise");
            }

            return course;
        }

        static List<string> Swap(List<string> listNums, string firstTitle, string secondTitle)
        {
            if (!listNums.Contains(firstTitle) || !listNums.Contains(secondTitle))
            {
                return listNums;
            }

            int firstIndex = listNums.IndexOf(firstTitle);
            int secondIndex = listNums.IndexOf(secondTitle);

            // swap lessons
            listNums[firstIndex] = secondTitle;
            listNums[secondIndex] = firstTitle;

            // check exercises
            bool firstHasExercise = listNums.Contains($"{firstTitle}-Exercise");
            bool secondHasExercise = listNums.Contains($"{secondTitle}-Exercise");

            // move first exercise
            if (firstHasExercise)
            {
                listNums.Remove($"{firstTitle}-Exercise");
                listNums.Insert(listNums.IndexOf(firstTitle) + 1, $"{firstTitle}-Exercise");
            }

            // move second exercise
            if (secondHasExercise)
            {
                listNums.Remove($"{secondTitle}-Exercise");
                listNums.Insert(listNums.IndexOf(secondTitle) + 1, $"{secondTitle}-Exercise");
            }

            return listNums;
        }

        static List<string> Remove(List<string> course, string lessonTitle)
        {
            while (course.Contains(lessonTitle) || course.Contains($"{lessonTitle}-Exercise")) 
            {
                course.Remove(lessonTitle);
                course.Remove($"{lessonTitle}-Exercise");
            }
            return course;
        }

        static List<string> Insert(List<string> course, string lessonTitle, int index)
        {
            if (!course.Contains(lessonTitle))
            {
                course.Insert(index, lessonTitle);
            }
            return course;
        }

        static List<string> Add(List<string> course, string lessonTitle)
        {
            if (!course.Contains(lessonTitle))
            {
                course.Add(lessonTitle);
            }
            return course;
        }
    }
}
