using System;

namespace _07.Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();

                Person newPerson = new Person(arguments[0], arguments[1], int.Parse(arguments[2]));


                Person? foundPerson = people.FirstOrDefault(person => person.Id == newPerson.Id);

                if (foundPerson != null)
                {
                    foundPerson.Name = newPerson.Name;
                    foundPerson.Age = newPerson.Age;
                }
                else
                {
                    people.Add(newPerson);
                }     
            }

            List<Person> orderedPpl = people
                .OrderBy(person => person.Age)
                .ToList();

            foreach (Person person in orderedPpl)
            {
                Console.WriteLine(person);
            }

        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }

    }
}
