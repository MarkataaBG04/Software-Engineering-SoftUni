namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int attempts = 1;
            string password = string.Empty;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string input = Console.ReadLine();

            while (input != password) 
            {
                if (attempts == 4) 
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                    Console.WriteLine($"Incorrect password. Try again.");
               
                input = Console.ReadLine();
                attempts++;
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
