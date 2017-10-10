namespace Pr01MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Pr06MaxSequenceOfEqualElements
    {
        static void Main()
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var max = sequence.Select((n, i) => new { Value = n, Index = i })
            .OrderBy(s => s.Value)
            .Select((o, i) => new { Value = o.Value, Diff = i - o.Index })
            .GroupBy(s => new { s.Value, s.Diff })
            .OrderByDescending(g => g.Count())
            .First()
            .Select(f => f.Value)
            .ToArray();

            Console.WriteLine(string.Join(" ", max));

        }
    }
}