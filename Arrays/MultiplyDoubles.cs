using System;
using System.Linq;
using System.Collections.Generic;
namespace MultiplyDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var doubles = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var p = double.Parse(Console.ReadLine());

            var results = new List<double>();

            double result = 0;

            for (int i = 0; i < doubles.Length; i++)
            {
                var current = doubles[i];

                result = current * p;

                results.Add(result);
            }

            foreach (var item in results)
            {
                Console.Write(item + " ");
            }

        }
    }
}
