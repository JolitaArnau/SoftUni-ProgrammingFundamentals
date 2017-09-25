using System;
using System.Linq;

namespace OddNumsAtOddPositions
{
    class OddNumsAtOddPositions
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                var index = i;

                var current = numbers[i];

                if (current % 2 != 0 && i % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {current}");
                }
            }
        }
    }
}
