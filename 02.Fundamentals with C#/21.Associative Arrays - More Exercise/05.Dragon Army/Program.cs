namespace _05.Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, Dragon>> dragons = new Dictionary<string, SortedDictionary<string, Dragon>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string type = arguments[0];
                string name = arguments[1];
                int damage = arguments[2] == "null" ? 45 : int.Parse(arguments[2]);
                int health = arguments[3] == "null" ? 250 : int.Parse(arguments[3]);
                int armor = arguments[4] == "null" ? 10 : int.Parse(arguments[4]);


                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, Dragon>();
                }

                Dragon newDragon = new Dragon(damage, health, armor);
                dragons[type][name] = newDragon;
            }

            foreach (var typePair in dragons)
            {
                string type = typePair.Key;
                SortedDictionary<string, Dragon> currentDragons = typePair.Value;

                double totalDamage = 0;
                double totalHealth = 0;
                double totalArmor = 0;

                foreach (var dragonPair in currentDragons)
                {
                    totalDamage += dragonPair.Value.Damage;
                    totalHealth += dragonPair.Value.Health;
                    totalArmor += dragonPair.Value.Armor;
                }

                double avgDamage = totalDamage / currentDragons.Count;
                double avgHealth = totalHealth / currentDragons.Count;
                double avgArmor = totalArmor / currentDragons.Count;

                Console.WriteLine($"{type}::({avgDamage:F2}/{avgHealth:F2}/{avgArmor:F2})");

                foreach (var dragonPair in currentDragons)
                {
                    Console.WriteLine($"-{dragonPair.Key} -> damage: {dragonPair.Value.Damage}, health: {dragonPair.Value.Health}, armor: {dragonPair.Value.Armor}");
                }
            }

        }
    }

    class Dragon 
    {
        public Dragon(int damage, int health, int armor)
        {
            Damage = damage;
            Health = health;
            Armor = armor;
        }

        public int Damage { get; set; }

        public int Health { get; set; }

        public int Armor { get; set; }
    }
}
