namespace Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class RemoveAtOddPos
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine()
                .Split()
                .ToList();

            var even = new List<string>();

            for (int i = 0; i < elements.Count; i++)
            {
                if (i % 2 != 0)
                {
                    even.Add(elements[i]);
                }
            }

            foreach (var word in even)
            {
                Console.Write(word);
            }
        }
    }
}
