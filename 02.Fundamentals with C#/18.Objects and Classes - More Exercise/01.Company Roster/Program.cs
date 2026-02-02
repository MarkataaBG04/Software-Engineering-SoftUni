namespace _01.Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                Employee newEmployee = new Employee(arguments[0], double.Parse(arguments[1]), arguments[2]);

                employees.Add(newEmployee);
            }

                    var bestDepartment = employees
                                    .GroupBy(e => e.Department)
                                    .OrderByDescending(g => g.Average(e => e.Salary))
                                    .First();

            Console.WriteLine($"Highest Average Salary: {bestDepartment.Key}");

            
            foreach (Employee employee in bestDepartment.OrderByDescending(p => p.Salary)) 
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
        class Employee
        {
            public Employee(string name, double salaray, string department)
            {
                Name = name;
                Salary = salaray;
                Department = department;
            }

            public string Name { get; set; }
            public double Salary { get; set; }

            public string Department { get; set; }

        }
    }
}