namespace Largest3Nums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Largest3Nums
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList()
                .OrderByDescending(x => x)
                .Take(3);

            foreach (var num in numbers)
            {
                Console.Write($"{String.Join(" ", num)}");
            }

            //Console.ReadKey();
        }
    }
}
