namespace _16.Movie_Ratings
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int nMovies = int.Parse(Console.ReadLine());

            double lowestRating = double.MaxValue;

            double highestRating = double.MinValue;

            string highestRateMoive = string.Empty;
            string lowestRateMovie = string.Empty;

            double averageRate = 0;

            for (int i = 1; i <= nMovies; i++)
            {
                string movieName = Console.ReadLine();
                double ratingMovie = double.Parse(Console.ReadLine());

                if (ratingMovie > highestRating)
                {
                    highestRateMoive = movieName;
                    highestRating = ratingMovie;
                }
                else if (ratingMovie < lowestRating)
                {
                    lowestRateMovie = movieName;
                    lowestRating = ratingMovie;
                }

                averageRate += ratingMovie;
            }

            Console.WriteLine($"{highestRateMoive} is with highest rating: {highestRating:f1}");
            Console.WriteLine($"{lowestRateMovie} is with lowest rating: {lowestRating:F1}");
            Console.WriteLine($"Average rating: {averageRate/nMovies:f1}");
        }
    }
}