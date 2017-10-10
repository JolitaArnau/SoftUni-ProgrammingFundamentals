namespace Pr06SumReversedNums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Pe06SumReversedNums
    {
        static void Main()
        {
            var sequence = Console
                .ReadLine()
                .Split()
                .ToList();

            var reversedDigits = new List<int>();

            for (int i = 0; i < sequence.Count; i++)
            {
                var current = sequence[i];

                var charArray = current.ToCharArray();

                Array.Reverse(charArray);

                var reversed = new string(charArray);

                var digit = int.Parse(reversed);

                reversedDigits.Add(digit);
                
            }

            Console.WriteLine(reversedDigits.Sum());


        }
    }
}
