namespace _04.Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> countColour = new Dictionary<string, int>();

            List<Dwarf> dwarfs = new List<Dwarf>();

            string input;

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] arguments = input.Split(" <:> ");
                string dwarfName = arguments[0];
                string dwarfHatColor = arguments[1];
                int dwarfPhysics = int.Parse(arguments[2]);


                Dwarf newDwarf = new Dwarf(dwarfName, dwarfHatColor, dwarfPhysics);

                bool exists = false;

                foreach (var dwarf in dwarfs)
                {
                    // Ако има джудже със същото име и същ цвят
                    if (dwarf.Name == newDwarf.Name && dwarf.HatColor == newDwarf.HatColor)
                    {
                        exists = true;

                        // Обновяваме Physics, ако новото е по-голямо
                        if (newDwarf.Physics > dwarf.Physics)
                        {
                            dwarf.Physics = newDwarf.Physics;
                        }

                        break; // вече сме го намерили, няма нужда да продължаваме
                    }
                }

                // Ако няма такова джудже в списъка → добавяме новото
                if (!exists)
                {
                    dwarfs.Add(newDwarf);
                }


                if (!countColour.ContainsKey(dwarfHatColor))
                {
                    countColour.Add(dwarfHatColor, 0);
                }
                countColour[dwarfHatColor]++;


            }

            foreach (var dwarf in dwarfs
                                    .OrderByDescending(x => x.Physics)
                                    .ThenByDescending(x => countColour[x.HatColor]))
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }

    class Dwarf
    {
        public Dwarf(string name, string hatColor, int physics)
        {
            Name = name;
            HatColor = hatColor;
            Physics = physics;
        }

        public string Name { get; set; }

        public string HatColor { get; set; }

        public int Physics { get; set; }
    }
}
