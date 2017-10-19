namespace Pr01Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Pr01Numbers
    {
        public static void Main()
        {
            var sequence = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var average = sequence.Average();

            var top = sequence.OrderByDescending(n => n).Where(n => n > average).Take(5).ToList();

            if (!top.Any())
            {
                Console.WriteLine("No");
            }

            else
            {
                Console.WriteLine(string.Join(" ", top));
            }
        }
    }
}