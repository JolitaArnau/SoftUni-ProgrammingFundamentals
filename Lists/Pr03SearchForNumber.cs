namespace Pr03SearchForNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Pr03SearchForNumber
    {
        static void Main()
        {
            var sequence = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var manipulations = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var takeFromSequence = manipulations[0];
            var deleteFromSequence = manipulations[1];
            var searchAfterManipulations = manipulations[2];

            var updated = sequence
                .Take(takeFromSequence)
                .ToList();

            updated.RemoveRange(0, deleteFromSequence);

            if (updated.Contains(searchAfterManipulations))
            {
                Console.WriteLine("YES!");
            }

            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
