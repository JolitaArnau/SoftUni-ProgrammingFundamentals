namespace LetterRepetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class LetterRepetition
    {
        static void Main(string[] args)
        {
            var stringSequence = Console.ReadLine();

            var countOfElements = new Dictionary<char, int>();

            foreach (var character in stringSequence)
            {
                if (!countOfElements.ContainsKey(character))
                {
                    countOfElements[character] = 0;
                }
                countOfElements[character]++;
            }

            foreach (var kvp in countOfElements)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}"); 
            }
        }
    }
}
