namespace LambdaAndLINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MinMaxSumAvg
    {
        static void Main(string[] args)
        {
            var numbersCount = int.Parse(Console.ReadLine());

            var numbers = new List<int>();

            for (int i = 0; i < numbersCount; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());

                numbers.Add(currentNum);
            }


            var sum = numbers.Sum();
            var min = numbers.Min();
            var max = numbers.Max();
            var avg = numbers.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {avg}");

            //Console.ReadKey();
        }
    }
}
