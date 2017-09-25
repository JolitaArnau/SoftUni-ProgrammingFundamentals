namespace EqualSumAfterExtr
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class EqualSumAfterExtr
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderBy(x => x)
                .ToList();

            var secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderBy(x => x)
                .ToList();

            foreach (var num in firstList)
            {
                secondList.Remove(num);
            }

            var sumFirstList = firstList.Sum();

            var sumSecondList = secondList.Sum();

            var diff = Math.Abs(sumFirstList - sumSecondList);

            if (sumFirstList == sumSecondList)
            {
                Console.WriteLine($"Yes. Sum: {sumFirstList}");
            }

            else
            {
                Console.WriteLine($"No. Diff: {diff}");
            }
        }
    }
}
