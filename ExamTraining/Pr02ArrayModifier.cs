using System.Linq;
using System.Web;

namespace Pr02ArrayModifier
{
    using System;
    using System.Collections.Generic;
    
    public class Pr02ArrayModifier
    {
        public static void Main()
        {
            var sequence = Console
                .ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();

            var commands = Console.ReadLine();

            while (!commands.Equals("end"))
            {
                var commandTokens = commands.Split();

                var command = commandTokens[0];

                switch (command)
                {
                        case "swap":
                            SwapElements(sequence, commandTokens);
                            break;
                        case "multiply":
                            MultiplyElements(sequence, commandTokens);
                            break;
                        case "decrease":
                            DecreaseAllElements(sequence);
                            break;
                            
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", sequence));
        }

        public static long[] SwapElements(long[] sequence, string[] commandTokens)
        {
            int firstIndex = int.Parse(commandTokens[1]);
            int secondIndex = int.Parse(commandTokens[2]);
            
            long temp = sequence[firstIndex]; // Copy the first position's element
            sequence[firstIndex] = sequence[secondIndex]; // Assign to the second element
            sequence[secondIndex] = temp; // Assign to the first element
            return sequence;
        }
        
        public static long[] MultiplyElements(long[] sequence, string[] commandTokens)
        {
            int firstIndex = int.Parse(commandTokens[1]);
            int secondIndex = int.Parse(commandTokens[2]);

            long firstElement = sequence[firstIndex];
            long secondElement = sequence[secondIndex];
           
            long result = firstElement * secondElement;

            sequence[firstIndex] = result;
            
            return sequence;
        }

        public static long[] DecreaseAllElements(long[] sequence)
        {

            for (int i = 0; i < sequence.Length; i++)
            {
                var currentElement = sequence[i];
                currentElement -= 1;
                sequence[i] = currentElement;
            }
            return sequence;
        }
    }
}