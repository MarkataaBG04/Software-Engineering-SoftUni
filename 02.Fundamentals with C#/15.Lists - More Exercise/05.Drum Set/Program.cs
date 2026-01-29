namespace _05.Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> initialQuality = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            List<int> experimentDrums = new List<int>(initialQuality);


            string input;

            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!") 
            {
                int hitPower = int.Parse(input);

                for (int i = 0; i < experimentDrums.Count; i++)
                {
                    experimentDrums[i] -= hitPower;

                    if (experimentDrums[i] <= 0)
                    {
                        if (initialQuality[i] * 3 <= savings)
                        {
                            savings -= initialQuality[i] * 3;
                            experimentDrums[i] = initialQuality[i];
                        }
                        else
                        {
                            experimentDrums.RemoveAt(i);
                            initialQuality.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", experimentDrums));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
