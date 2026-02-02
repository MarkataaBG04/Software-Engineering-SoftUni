namespace _01.Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> name = new List<string>() {"Filip", "Ivan" };
            //List<string> numbers = new List<string>() {"0886127312", "34023121" };
            //Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();
            // phoneNumbers.Add("Filip", "0889");
            // phoneNumbers.Add("Ivan", "0889232");
            // phoneNumbers.Add("George", "082312");
            // phoneNumbers["Filip"] = "123123";

            //for (int i = 0; i < name.Count; i++)
            //{
            //    Console.WriteLine($"{name[i]} - {phoneNumbers[i]}");
            //}

            double[] inputNumbers =  Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                double currentNumber = inputNumbers[i];

                if (!numbers.ContainsKey(currentNumber))
                {
                    numbers.Add(currentNumber, 0);
                }
                numbers[currentNumber]++;
                    
            }

            foreach (KeyValuePair<double, int> kvp in numbers)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
    //class Person 
    //{
    //    public string Name { get; set; }

    //    public string PhoneNumber { get; set; }
    //}
}
