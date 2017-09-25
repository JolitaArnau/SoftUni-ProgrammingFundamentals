namespace ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(new char[] {'.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\',  '/', '!',  '?', ' '  }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .Select(s => s.ToLower())
                .Where(s => s.Length < 5)
                .OrderBy(s => s)
                .Distinct();

            Console.Write($"{String.Join(", ", text)}");
        
            //Console.ReadKey();
        }
    }
}
