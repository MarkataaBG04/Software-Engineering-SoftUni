namespace _10.Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGame = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());


            int countTrashHeadset = 0;
            int countTrashMouse = 0;
            int countTrashKeyboard = 0;
            int countTrashDisplay = 0;


            double sum = 0;

            for (int i = 1; i <= lostGame; i++)
            {
                if (i % 3 == 0 && i % 2 == 0)
                {
                    countTrashKeyboard++;
                    countTrashHeadset++;
                    countTrashMouse++;
                    if (countTrashKeyboard % 2 == 0)
                    {
                        countTrashDisplay++;
                    }
                }
                else if (i % 3 == 0)
                {
                    countTrashMouse++;
                }
                else if (i % 2 == 0)
                {
                    countTrashHeadset++;
                }

                
            }

            sum = (countTrashHeadset * headsetPrice) + (mousePrice * countTrashMouse) + (keyboardPrice *  countTrashKeyboard) + (countTrashDisplay * displayPrice);

            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
        }
    }
}
