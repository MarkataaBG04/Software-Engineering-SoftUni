namespace _67.Care_of_Puppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodPurchasedInKg = int.Parse(Console.ReadLine()) * 1000; //prava gi v gramove

            string command = Console.ReadLine();

            while (command != "Adopted")
            {
                int foodEat = int.Parse(command);

                foodPurchasedInKg -= foodEat;


                command = Console.ReadLine();
            }

            if (foodPurchasedInKg < 0)
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(foodPurchasedInKg)} grams more.");

            }
            else
            {

                Console.WriteLine($"Food is enough! Leftovers: {foodPurchasedInKg} grams.");
            }
        }
    }
}
