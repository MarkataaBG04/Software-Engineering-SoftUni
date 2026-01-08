using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballsCount = int.Parse(Console.ReadLine());

            int snowballSnowBest = 0;
            int snowballTimeBest = 0;
            int snowballQualityBest = 0;
            BigInteger snowballValueBest = 0;

            for (int i = 1; i <= snowballsCount; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger currentFormulaSum = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (currentFormulaSum > snowballValueBest)
                {
                    snowballValueBest = currentFormulaSum;
                    snowballSnowBest = snowballSnow;
                    snowballTimeBest = snowballTime;
                    snowballQualityBest = snowballQuality;
                }
            }

            Console.WriteLine($"{snowballSnowBest} : {snowballTimeBest} = {snowballValueBest} ({snowballQualityBest})");
        }
    }
}
