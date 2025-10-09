namespace _07.Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalGroups = int.Parse(Console.ReadLine());

            int totalPeople = 0;

            double musalaCount = 0;
            double monblanCount = 0;
            double kilimendjaroCount = 0;
            double k2Count = 0;
            double everestCount = 0;

            for (int i = 1; i <= totalGroups; i++)
            {
                int countPeopleInGroup = int.Parse(Console.ReadLine());

                if (countPeopleInGroup <= 5)
                {
                    musalaCount += countPeopleInGroup;
                }
                else if (countPeopleInGroup >= 6 && countPeopleInGroup <= 12)
                {
                    monblanCount += countPeopleInGroup;
                }
                else if (countPeopleInGroup >= 13 && countPeopleInGroup <= 25)
                {
                    kilimendjaroCount += countPeopleInGroup;
                }
                else if (countPeopleInGroup >= 26 && countPeopleInGroup <= 40)
                {
                    k2Count += countPeopleInGroup;
                }
                else if (countPeopleInGroup >= 41)
                {
                    everestCount += countPeopleInGroup;
                }


                totalPeople += countPeopleInGroup;
            }

            Console.WriteLine($"{musalaCount / totalPeople * 100:f2}%");
            Console.WriteLine($"{monblanCount / totalPeople * 100:F2}%");
            Console.WriteLine($"{kilimendjaroCount / totalPeople * 100:F2}%");
            Console.WriteLine($"{k2Count / totalPeople * 100:F2}%");
            Console.WriteLine($"{everestCount / totalPeople * 100:F2}%");
        }
    }
}