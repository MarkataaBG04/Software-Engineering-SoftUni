namespace _02.Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //Дадено е цяло число – начален брой точки.Върху него се начисляват бонус точки по правилата, описани по -   долу.
                //Да  се   напише програма, която пресмята бонус точките, които получава числото и общия брой точки(числото  +бонуса).
                
                //· Ако числото е до 100 включително, бонус точките са 5.
                
                //· Ако числото е по-голямо от 100 и по-малко или равно на 1000, бонус точките са 20 % от числото.
                
                //· Ако числото е по-голямо от 1000, бонус точките са 10 % от числото.
                
                //· Допълнителни бонус точки(начисляват се отделно от предходните):
                
                //o За четно число -> + 1 т.
                
                //o За число, което завършва на 5 -> + 2 т.

            int startingPoints  = int.Parse(Console.ReadLine());

            double bonusPoints = 0.0;

            if (startingPoints <= 100)
            {
                bonusPoints = 5;
            }
            else if (startingPoints <= 1000)
            {
                bonusPoints =  startingPoints * 0.20;
            }
            else
            {
                bonusPoints = startingPoints * 0.10;
            }

            if (startingPoints % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            else if(startingPoints % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(startingPoints + bonusPoints);
        }
    }
}