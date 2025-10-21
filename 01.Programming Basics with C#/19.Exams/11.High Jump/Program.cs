using System;

namespace _11.High_Jump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goalHeight = int.Parse(Console.ReadLine());
            int barHeight = goalHeight - 30;

            int jumpsCount = 0;

            while (barHeight <= goalHeight)
            {
                int failedJumps = 0;

                while (failedJumps < 3)
                {
                    int jump = int.Parse(Console.ReadLine());
                    jumpsCount++;

                    if (jump > barHeight)
                    {
                        // Успешен скок – покачваме летвата
                        break;
                    }
                    else
                    {
                        failedJumps++;
                    }

                    if (failedJumps == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {barHeight}cm after {jumpsCount} jumps.");
                        return;
                    }
                }

                barHeight += 5;
            }

            Console.WriteLine($"Tihomir succeeded, he jumped over {goalHeight}cm after {jumpsCount} jumps.");
        }
    }
}
