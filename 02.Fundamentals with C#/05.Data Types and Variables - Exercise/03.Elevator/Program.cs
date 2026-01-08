namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberOfPeople = int.Parse(Console.ReadLine());
           int capacity = int.Parse(Console.ReadLine());

            int courses = 0;


            while (numberOfPeople != 0) 
            {
                if (capacity >= numberOfPeople)
                {
                    courses++;
                    numberOfPeople -= numberOfPeople;
                }
                else  
                {
                    numberOfPeople -= capacity;
                    courses++;
                }
            }

            Console.WriteLine(courses);
        }
    }
}
