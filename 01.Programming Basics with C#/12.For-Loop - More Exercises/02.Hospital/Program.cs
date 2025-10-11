namespace _02.Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int doctorCount = 7;

            int curedPatients = 0;

            int uncuredPatients = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 3 == 0)
                {
                    if (uncuredPatients > curedPatients)
                    {
                        doctorCount++;
                    }
                }

                int patiens = int.Parse(Console.ReadLine());

                if (patiens <= doctorCount)
                {
                    curedPatients += patiens;
                }
                else
                {
                    uncuredPatients += patiens - doctorCount;
                    curedPatients = curedPatients + doctorCount;
                }       
            }

            Console.WriteLine($"Treated patients: {curedPatients}.");
            Console.WriteLine($"Untreated patients: {uncuredPatients}.");
        }
    }
}