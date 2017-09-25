using System;
using System.Linq;

namespace CountOddNums
{
    class CountOddNums
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                var current = numbers[i];

                if (current % 2 != 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);

        }
    }
}
