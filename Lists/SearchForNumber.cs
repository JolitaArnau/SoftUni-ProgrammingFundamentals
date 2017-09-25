namespace SearchForNum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class SearchForNumber
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var commands = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            var countTake = commands[0];
            var toBeDeletedFromTaken = commands[1];
            var takeAfterManipulation = commands[2];

            numbers.Take(countTake);

            numbers.Remove(toBeDeletedFromTaken);

            if (numbers.Contains(takeAfterManipulation))
            {
                Console.WriteLine("YES!");
            }

            else
            {
                Console.WriteLine("NO!");
            }

           // Console.ReadKey();
        }
    }
}
