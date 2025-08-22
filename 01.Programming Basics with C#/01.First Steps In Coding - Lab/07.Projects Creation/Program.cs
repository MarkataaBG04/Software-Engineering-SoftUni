namespace _07.Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string architectName = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());

            int totalTimeNeed = projectsCount * 3;

            Console.WriteLine($"The architect {architectName} will need {totalTimeNeed} hours to complete {projectsCount} project/s.");
        }
    }
}