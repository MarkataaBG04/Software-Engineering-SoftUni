namespace _67.Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupsCountN = int.Parse(Console.ReadLine());
            int musalaCount = 0;
            int monblanCount = 0;
            int kilimndjdaroCount = 0;
            int k2Count = 0;
            int everestCount = 0;

            int totalClimbers = 0;


            for (int i = 1; i <= groupsCountN; i++)
            {
                int peopleCount = int.Parse(Console.ReadLine());

                totalClimbers += peopleCount;

                if (peopleCount <= 5)
                {
                    musalaCount += peopleCount;
                }
                else if (peopleCount <= 12)
                {
                    monblanCount += peopleCount;
                }
                else if (peopleCount <= 25)
                {
                    kilimndjdaroCount += peopleCount;
                }
                else if (peopleCount <= 40)
                {
                    k2Count += peopleCount;
                }
                else if (peopleCount >= 41)
                {
                    everestCount += peopleCount;
                }
            }

            Console.WriteLine($"{(double)musalaCount / totalClimbers * 100:f2}%");
            Console.WriteLine($"{(double)monblanCount / totalClimbers * 100:f2}%");
            Console.WriteLine($"{(double)kilimndjdaroCount / totalClimbers * 100:f2}%");
            Console.WriteLine($"{(double)k2Count / totalClimbers * 100:f2}%");
            Console.WriteLine($"{(double)everestCount / totalClimbers * 100:f2}%");



        }
    }
}
