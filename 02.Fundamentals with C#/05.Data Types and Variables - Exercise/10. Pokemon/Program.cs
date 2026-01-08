namespace _10._Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int halfOfNumber = pokePower / 2;

            int targetsCount = 0;

            while (pokePower >= distance)
            {
                pokePower = pokePower - distance;
                targetsCount++;

                if (pokePower == halfOfNumber)
                {
                    if (exhaustionFactor == 0)
                    {
                        continue;
                    }
                    else
                    {
                        pokePower = pokePower / exhaustionFactor;
                    }
                }

                

            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetsCount);
        }
    }
}
