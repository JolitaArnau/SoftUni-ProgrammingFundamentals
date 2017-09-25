namespace SumReversed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SumReversedNums
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .ToList();

            var reversedDigits = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];

                var charArr =  currentNumber.ToCharArray();

                Array.Reverse(charArr);

                var reversed = new string(charArr);

                var digit = int.Parse(reversed);

                reversedDigits.Add(digit);
            }

            var sum = reversedDigits.Sum();

            Console.WriteLine(sum);
        }
    }
}
