using System.Xml.Linq;

namespace _03.House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>();

            for (int i = 0; i < count; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();

                if (commandArgs[2] == "going!")
                {
                    string name = commandArgs[0];
                    int index = guestList.IndexOf(name);
                    if (index != -1)
                    {
                        Console.WriteLine($"{name} is already in the list! ");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
                else if (commandArgs[2] == "not")
                {
                    string name = commandArgs[0];
                    int index = guestList.IndexOf(name);
                    if (index != -1)
                    {
                        guestList.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            //foreach (string guest in guestList)
            //{
            //    Console.WriteLine(guest);
            //}

            Console.WriteLine(string.Join("\n", guestList));
        }
    }
}
