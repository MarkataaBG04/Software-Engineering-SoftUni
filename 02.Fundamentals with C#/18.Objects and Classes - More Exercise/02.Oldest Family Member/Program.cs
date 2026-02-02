namespace _02.Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                string[] arguments = Console.ReadLine().Split();
                string name = arguments[0];
                int age = int.Parse(arguments[1]);

                Person newPerson = new Person(name, age);
                family.AddMember(newPerson);
            }

            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
    class Family 
    {
        public List<Person> Members = new List<Person>();

        public void AddMember(Person member) 
        {
            Members.Add(member);
        }

        public Person GetOldestMember() 
        {

            return Members.OrderByDescending(people => people.Age).First();
        }
    }

    class Person 
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
