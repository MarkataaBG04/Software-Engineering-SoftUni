namespace _02.A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, uint> resourceMap = new Dictionary<string, uint>();
            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                string resource = input;
                uint quantity = uint.Parse(Console.ReadLine());

                if (!resourceMap.ContainsKey(resource))
                {
                    resourceMap.Add(resource, 0);
                }
                resourceMap[resource] += quantity;
            }

            foreach (KeyValuePair<string, uint> item in resourceMap)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
