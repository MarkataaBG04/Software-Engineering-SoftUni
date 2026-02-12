using System.Xml.Linq;

namespace _04.SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> users = new Dictionary<string, User>();

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= commandCount; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string command = arguments[0];
                string userName = arguments[1];

                switch (command)
                {
                    case "register":
                        string licensePlateNumber = arguments[2];
                        if (!users.ContainsKey(userName))
                        {
                            User newUser = new User(userName, licensePlateNumber);
                            users.Add(userName, newUser);
                            Console.WriteLine($"{newUser.UserName} registered {newUser.LicensePlateNumber} successfully");
                        }
                        else
                        {
                            User foundUser = users[userName];
                            Console.WriteLine($"ERROR: already registered with plate number {foundUser.LicensePlateNumber}");
                        }
                            break;
                    case "unregister":
                        if (users.ContainsKey(userName))
                        {
                            users.Remove(userName);
                            Console.WriteLine($"{userName} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        break;
                    default:
                        break;
                }

                
            }
            foreach (KeyValuePair<string, User> user in users)
            {
                Console.WriteLine($"{user.Value}");
            }
        }
    }

    class User 
    {
        public User(string name, string licensePlateNumber)
        {
            UserName = name;
            LicensePlateNumber = licensePlateNumber;
        }

        public string UserName { get; set; }

        public string LicensePlateNumber { get; set; }

        public override string ToString()
        {
            return $"{UserName} => {LicensePlateNumber}";
        }

    }

}
