namespace _01.Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jeff, john45, ab, cd, peter-ivanov, @smith

            string[] usernames = Console.ReadLine().Split(", ");

            for (int i = 0; i < usernames.Length; i++)
            {
                if (IsValidUsername(usernames[i]))
                {
                    Console.WriteLine(usernames[i]);
                }
                
            }
        }

        static bool IsValidUsername(string username) 
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }
            for (int i = 0; i < username.Length; i++)
            {
                if (!char.IsLetter(username[i]) && !char.IsDigit(username[i]) && username[i] != '-' && username[i] != '_')
                {
                    return false;
                }
            }

            return true;

        }
    }
}
