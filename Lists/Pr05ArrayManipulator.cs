namespace Pr05ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Pr05ArrayManipulator
    {
        static void Main()
        {
            var sequence = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var commands = Console.ReadLine();

            while (!commands.Equals("print"))
            {
                var commandTokens = commands.Split();
                var command = commandTokens[0];

                if (command.Equals("add"))
                {
                    var indexAdd = int.Parse(commandTokens[1]);
                    var elementAdd = int.Parse(commandTokens[2]);

                    sequence.Insert(indexAdd, elementAdd);
                }

                if (command.Equals("addMany"))
                {
                    var indexAddMany = int.Parse(commandTokens[1]);
                    var rangeAdd = commandTokens.Skip(2).Select(int.Parse).ToList();

                    sequence.InsertRange(indexAddMany, rangeAdd);
                }

                if (command.Equals("contains"))
                {
                    //print index of wanted element
                    //if not present print -1

                    var searchItem = int.Parse(commandTokens[1]);

                    if (sequence.Contains(searchItem))
                    {
                        Console.WriteLine(sequence.IndexOf(searchItem));
                    }

                    else
                    {
                        Console.WriteLine("-1");
                    }
                }

                if (command.Equals("remove"))
                {
                    var removeItemIndex = int.Parse(commandTokens[1]);

                    sequence.RemoveAt(removeItemIndex);
                }

                if (command.Equals("shift"))
                {
                    int positions = int.Parse(commandTokens[1]);

                    for (int i = 0; i < positions; i++)
                    {
                        int lastElement = sequence[0];
                        for (int j = 0; j < sequence.Count - 1; j++)
                        {
                            sequence[j] = sequence[j + 1];
                        }
                        sequence[sequence.Count - 1] = lastElement;
                    }
                }

                if (command.Equals("sumPairs"))
                {
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
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", sequence)}]");
        }
    }
}
