namespace _38.Easter_Bake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int needKozunaks = int.Parse(Console.ReadLine());

            double sugarTotalGrams = 0;
            double flourTotalGrams = 0;

            int currentHighSugar = int.MinValue;
            int currentHighFlour = int.MinValue;

            for (int i = 1; i <= needKozunaks; i++)
            {
                int sugarGrams = int.Parse(Console.ReadLine());
                int flourGrams = int.Parse(Console.ReadLine());

                sugarTotalGrams += sugarGrams;
                flourTotalGrams += flourGrams;

                if (currentHighSugar < sugarGrams)
                {
                    currentHighSugar = sugarGrams;
                }

                if (currentHighFlour < flourGrams)
                {
                    currentHighFlour = flourGrams;
                }

            }

            Console.WriteLine($"Sugar: {Math.Ceiling(sugarTotalGrams / 950)}");
            Console.WriteLine($"Flour: {Math.Ceiling(flourTotalGrams / 750)}");
            Console.WriteLine($"Max used flour is {currentHighFlour} grams, max used sugar is {currentHighSugar} grams.");
        }
    }
}
