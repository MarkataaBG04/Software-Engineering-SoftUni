namespace _06.Card_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToList();


            List<int> secondDeck = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToList();

            while (firstDeck.Count > 0 && secondDeck.Count > 0)
            {
                int index = 0;

                        if (firstDeck[index] > secondDeck[index])
                        {
                            firstDeck.Add(secondDeck[index]);
                            firstDeck.Add(firstDeck[index]);
                            firstDeck.RemoveAt(index);
                            secondDeck.RemoveAt(index);
                            
                        }
                        else if (secondDeck[index] > firstDeck[index])
                        {
                            secondDeck.Add(firstDeck[index]);
                            secondDeck.Add(secondDeck[index]);
                            secondDeck.RemoveAt(index);
                            firstDeck.RemoveAt(index);
                            
                        }
                        else if (secondDeck[index] == firstDeck[index])
                        {
                            firstDeck.RemoveAt(index);
                            secondDeck.RemoveAt(index);
                            
                        }
                  
            }

            if (firstDeck.Count > 0)
            {
                int sum = 0;
                for (int i = 0; i < firstDeck.Count; i++)
                {
                    
                    sum += firstDeck[i];
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else if (secondDeck.Count > 0)
            {
                int sum = 0;
                for (int i = 0; i < secondDeck.Count; i++)
                {

                    sum += secondDeck[i];
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
