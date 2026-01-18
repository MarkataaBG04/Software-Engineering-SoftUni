namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get Field Size
            int fieldLenght = int.Parse(Console.ReadLine());

            //initialize the empty field
            int[] field = new int[fieldLenght];
            
            // ladybug Places
            int[] bugPlaces = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //Fill the field with bugs

            for (int i = 0; i < bugPlaces.Length; i++)
            {
                int currentIndex = bugPlaces[i];

                if (currentIndex >= 0 && currentIndex < field.Length)
                {
                    field[currentIndex] = 1;
                }
            }

            //[1 1 0]

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                //Do work
                string[] arguments = command.Split(" ");
                int bugIndex = int.Parse(arguments[0]);
                string direction = arguments[1];
                int flyLenght = int.Parse(arguments[2]);

                if (bugIndex < 0 || bugIndex > field.Length - 1 || field[bugIndex] == 0)
                {
                    continue;
                }

                field[bugIndex] = 0;

                if (direction == "right")
                {
                    int landIndex = bugIndex + flyLenght;
                    int lastFieldIndex = field.Length - 1;

                    if (landIndex > lastFieldIndex)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex += flyLenght;
                            if (landIndex > field.Length - 1)
                            {
                                break;
                            }

                        }

                    }

                    if (landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }
                    
                }
                else if(direction == "left")
                {
                    int landIndex = bugIndex - flyLenght;

                    if (landIndex < 0)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLenght;
                            if (landIndex < 0)
                            {
                                break;
                            }

                        }

                    }

                    if (landIndex >= 0)
                    {
                        field[landIndex] = 1;
                    }
                }

            }
            //exit

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
