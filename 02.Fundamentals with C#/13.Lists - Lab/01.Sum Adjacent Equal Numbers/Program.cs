using System;

namespace _01.Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////array --> elements of the same type
            ////initial lenght
            //int[] numbers = new int[4];
            //int[] numbers3 = new int[]{ 1, 2, 3, 4 }; 
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //Console.WriteLine(numbers.Length);
            //Console.WriteLine(string.Join(" ", numbers));

            //for (int i = 0; i <= numbers.Length - 1; i++)
            //{
            //    Console.WriteLine($"{numbers[i]}");
            //}

            ////Add(element) - adds an element to the list<T> DONE
            ////Count – number of elements in the List<T> DONE
            ////Remove(element) – removes an element (returns true /false) - DONE
            ////Insert(index, element) – inserts an element to a given index - DONE
            ////Contains(element) – determines whether an element is in the list - DONE
            ////Sort() – sorts the array / list in ascending order
            //Console.WriteLine($"============================================");
            ////List --> elemnts of the same type
            //List<int> numbers2 = new List<int>();
            //List<string> carNames = new List<string> { "Tesla", "BMW", "AUDI"};
            //numbers2.Add(1);
            //numbers2.Add(2);
            //numbers2.Add(3);
            //numbers2.Add(4);
            //numbers2.Add(5);
            //Console.WriteLine(numbers2.Count); // 5
            //Console.WriteLine(string.Join(" ", numbers2));

            //numbers2.Insert(1, -1000);

            //for (int i = 0; i <= numbers2.Count - 1; i++)
            //{
            //    Console.WriteLine($"{numbers2[i]}");
            //}
            //numbers2.Remove(0);
            //Console.WriteLine(string.Join(" ", numbers2));


            List<double> numbers = Console.ReadLine() // 3 3 6 1
                                .Split()
                                .Select(double.Parse)
                                .ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                double current = numbers[i];
                double next = numbers[i + 1];

                if (current == next)
                {
                    numbers[i] = current + next;
                    numbers.Remove(next);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        } 
    }
}
