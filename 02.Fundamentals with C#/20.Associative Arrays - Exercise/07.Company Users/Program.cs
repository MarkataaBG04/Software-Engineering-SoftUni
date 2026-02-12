using System.Xml.Linq;

namespace _07.Company_Users
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Dictionary<string, Company> companies = new Dictionary<string, Company>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split(" -> ");
                string companyName = arguments[0];
                string employeeId = arguments[1];

                

                if (!companies.ContainsKey(companyName))
                {
                    Company newCompany = new Company(companyName);

                    companies.Add(companyName, newCompany);
                }

                if (!companies[companyName].EmployeeId.Contains(employeeId))
                {
                    companies[companyName].EmployeeId.Add(employeeId);
                }


            }

            foreach (var company in companies.Values)
            {
                Console.WriteLine(company);
            }
        }
    }
    
    class Company
    {
        public Company(string companyName)
        {
            CompanyName = companyName;
            EmployeeId = new List<string>();
        }

        public string CompanyName { get; set; }

        public List<string> EmployeeId { get; set; }

        public override string ToString()
        {
            string result = $"{CompanyName}\n";


            for (int i = 0; i < EmployeeId.Count; i++)
            {
                result += $"-- {EmployeeId[i]}\n";
            }

            return result.Trim();
        }
    }
}
