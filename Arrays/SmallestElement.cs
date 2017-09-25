using System;
using System.Linq;

namespace SmallestElement
{
    class SmallestElement
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int min = numbers.Min();
     
            Console.WriteLine(min);

        }
    }
}
