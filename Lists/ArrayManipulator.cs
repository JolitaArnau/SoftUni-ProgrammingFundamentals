namespace ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var command = Console.ReadLine();

            while (command != "print")
            {
                var tokens = command.Split();
                var toDo = tokens[0];
                switch (toDo)
                {
                    case "add":
                        var indexAdd = int.Parse(tokens[1]);
                        var element = int.Parse(tokens[2]);
                        sequence.Insert(indexAdd, element);
                        break;
                    case "addMany":
                        var indexAddMany = int.Parse(tokens[1]);
                        var elementsToAdd = tokens.Skip(2).Select(int.Parse).ToList();
                        sequence.InsertRange(indexAddMany, elementsToAdd);
                        break;
                    case "contains":
                        var wantedIndex = int.Parse(tokens[1]);
                        if (sequence.Contains(wantedIndex))
                        {
                            var wantedItemIndexContained = sequence.IndexOf(wantedIndex);
                        }
                        break;
                    case "remove":
                        var indexRemove = int.Parse(tokens[1]);
                        var wantedItemIndexRemove = sequence.IndexOf(indexRemove);
                        sequence.Remove(wantedItemIndexRemove);
                        break;
                    case "shift":
                        int positions = int.Parse(tokens[1]);
                        for (int i = 0; i < positions; i++)
                        {
                            int lastElement = sequence[0];
                            for (int j = 0; j < sequence.Count - 1; j++)
                            {
                                sequence[j] = sequence[j + 1];
                            }
                            sequence[sequence.Count - 1] = lastElement;
                        }
                        break;
                    case "sumPairs":
                        var summed = new List<int>();
                        for (int i = 0; i < sequence.Count - 1; i += 2)
                        {
                            summed.Add(sequence[i] + sequence[i + 1]);
                        }
                        if (sequence.Count % 2 == 1)
                        {
                            summed.Add(sequence[sequence.Count - 1]);
                        }
                        sequence = summed;
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", sequence) + "]");

            Console.ReadKey();
        }
    }
}
