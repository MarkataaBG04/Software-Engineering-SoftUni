namespace _08.On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine()) * 60;
            int examMin = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine()) * 60;
            int arriveMin = int.Parse(Console.ReadLine());

            int examTotalMin = examHour + examMin;
            int arriveTotalMin = arriveHour + arriveMin;

            if((arriveTotalMin > examTotalMin))
            {
                int newMin = (arriveTotalMin - examTotalMin) % 60;
                int newHour = (arriveTotalMin - examTotalMin) / 60;
                if (newHour == 0)
                {
                    Console.WriteLine($"Late");
                    Console.WriteLine($"{newMin} minutes after the start");
                }
                else
                {
                    if (newMin < 10)
                    {
                        Console.WriteLine($"Late");
                        Console.WriteLine($"{newHour}:0{newMin} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"Late");
                        Console.WriteLine($"{newHour}:{newMin} hours after the start");
                    }
                }
            }
            else if ((examTotalMin - arriveTotalMin) > 30)
            {
                int newMin = (examTotalMin - arriveTotalMin) % 60;
                int newHour = (examTotalMin - arriveTotalMin) / 60;
                if (newHour == 0)
                {
                    Console.WriteLine($"Early");
                    Console.WriteLine($"{newMin} minutes before the start");
                }
                else
                {
                    if (newMin < 10)
                    {
                        Console.WriteLine($"Early");
                        Console.WriteLine($"{newHour}:0{newMin} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"Early");
                        Console.WriteLine($"{newHour}:{newMin} hours before the start");
                    }          
                }
            }
            else if ((examTotalMin - arriveTotalMin) <= 30)
            {
                if (examTotalMin == arriveTotalMin)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    int newMin = (examTotalMin - arriveTotalMin) % 60;
                    Console.WriteLine($"On time");
                    Console.WriteLine($"{newMin} minutes before the start");
                }
            }
        }
    }
}