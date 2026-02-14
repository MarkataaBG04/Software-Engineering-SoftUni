using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> contests = new Dictionary<string, int>();
            Dictionary<string, User> users = new Dictionary<string, User>();
            string input;

            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] arguments = input.Split(" -> ");
                string username = arguments[0];
                string contest = arguments[1];
                int points = int.Parse(arguments[2]);

                // Ако user-а не съществува, създаваме нов и го добавяме в users
                if (!users.ContainsKey(username))
                {
                    User newUser = new User(username);
                    users.Add(username, newUser);
                }

                // Ако contest-а не съществува, добавяме го с брояч 0
                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, 0);
                }

                // Проверяваме дали user вече участва в този contest
                if (!users[username].ContestAndResults.ContainsKey(contest))
                {
                    users[username].ContestAndResults[contest] = points; // добавяме нов резултат
                    contests[contest] += 1; // увеличаваме броя на участниците
                }
                else
                {
                    // Ако има по-добри точки, обновяваме
                    if (users[username].ContestAndResults[contest] < points)
                    {
                        users[username].ContestAndResults[contest] = points;
                    }
                }
            }

            PrintResults(contests, users);
        }

        static void PrintResults(Dictionary<string, int> contests, Dictionary<string, User> users)
        {
            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value} participants");

                int index = 1;

                // Подреждаме участниците по точки (спадане) и име (възходящо)
                foreach (var user in users
                    .Where(u => u.Value.ContestAndResults.ContainsKey(contest.Key))
                    .OrderByDescending(u => u.Value.ContestAndResults[contest.Key])
                    .ThenBy(u => u.Key))
                {
                    Console.WriteLine($"{index}. {user.Key} <::> {user.Value.ContestAndResults[contest.Key]}");
                    index++;
                }
            }

            Console.WriteLine("Individual standings:");

            int position = 1;

            // Подреждаме всички потребители по общи точки (спадане) и име (възходящо)
            foreach (var user in users
                .OrderByDescending(u => u.Value.ContestAndResults.Values.Sum())
                .ThenBy(u => u.Key))
            {
                int totalPoints = user.Value.ContestAndResults.Values.Sum();
                Console.WriteLine($"{position}. {user.Key} -> {totalPoints}");
                position++;
            }
        }

        class User
        {
            public User(string name)
            {
                Name = name;
                ContestAndResults = new Dictionary<string, int>();
            }

            public string Name { get; set; }

            public Dictionary<string, int> ContestAndResults { get; set; }
        }
    }
}
