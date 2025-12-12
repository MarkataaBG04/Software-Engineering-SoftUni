namespace _48.Favourite_Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int count = 0;
            int bestMoviePoints = int.MinValue;
            string bestMovieTitle = "";

            while (command != "STOP" && count != 7) 
            {
                int sum = 0;
                foreach (char ch in command)
                {
                    int ascii = (int)ch;

                    if (char.IsUpper(ch))
                    {
                        ascii -= command.Length; // главна буква
                    }
                    else if (char.IsLower(ch))
                    {
                        ascii -= 2 * command.Length; // малка буква
                    }

                    sum += ascii;
                }

                if (sum > bestMoviePoints) 
                {
                    bestMoviePoints = sum;
                    bestMovieTitle = command;
                }



                count++;
                command = Console.ReadLine();
            }
            if (count == 7)
            {
                Console.WriteLine($"The limit is reached.");
            }
            Console.WriteLine($"The best movie for you is {bestMovieTitle} with {bestMoviePoints} ASCII sum.");
        }
    }
}
