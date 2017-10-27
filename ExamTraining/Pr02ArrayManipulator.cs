using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr02ArrayManipulator
{
    public class Pr02ArrayManipulator
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var commands = Console.ReadLine();
            
            while (!commands.Equals("end"))
            {
                var commandTokens = commands.Split();
                var command = commandTokens[0];

                switch (command)
                {
                    case "exchange":
                        var indexExchange = int.Parse(commandTokens[1]);
                       
                        
                        if (indexExchange< 0 || indexExchange >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        numbers =  ReturnExchangedElements(numbers, indexExchange + 1);
                        
                        break;
                        
                    case "max":
                        var maxEvenOrOdd = commandTokens[1];
                        
                        GetMaxIndex(numbers, maxEvenOrOdd);
                        
                        break;
                        
                    case "min":
                        var minEvenOrOdd = commandTokens[1];
                        
                        GetMinIndex(numbers, minEvenOrOdd);
                        
                        break;
                        
                    case "first":
                        var countFirst = int.Parse(commandTokens[1]);
                        
                        var firstEvenorOdd = commandTokens[2];
                        
                        GetFirstEvenOrOddElements(numbers, countFirst, firstEvenorOdd);
                        
                        break;
                        
                    case "last":
                        var countLast = int.Parse(commandTokens[1]);
                        
                        var lastEvenorOdd = commandTokens[2];

                        GetLastEvenOrOddElements(numbers, countLast, lastEvenorOdd);
                        
                        break;
                }
                commands = Console.ReadLine();
            }
            
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static void GetLastEvenOrOddElements(List<int> numbers, int countLast, string lastEvenorOdd)
        {
          
            if (lastEvenorOdd.Equals("even"))
            {
                var evenNums = numbers.Where(e => e % 2 == 0);
                
                if (countLast > numbers.Count)
                {
                    Console.WriteLine("Invalid index");
                }
                else if (!evenNums.Any())
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    evenNums = evenNums.Reverse().Take(countLast).Reverse();
                   
                    Console.WriteLine($"[{string.Join(", ", evenNums)}]");
                }
            }  
            
            if (lastEvenorOdd.Equals("odd"))
            {
                var oddNums = numbers.Where(e => e % 2 != 0);
                
                if (countLast > numbers.Count)
                {
                    Console.WriteLine("Invalid index");
                }
                else if (!oddNums.Any())
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    oddNums = oddNums.Reverse().Take(countLast).Reverse();
                   
                    Console.WriteLine($"[{string.Join(", ", oddNums)}]");
                }
            }  

        }

        private static void GetFirstEvenOrOddElements(List<int> numbers, int countFirst, string firstEvenorOdd)
        {
           
            if (firstEvenorOdd.Equals("even"))
            {
                var evenNums = numbers.Where(e => e % 2 == 0);
                
                if (countFirst > numbers.Count)
                {
                    Console.WriteLine("Invalid count");
                }
                else if (!evenNums.Any())
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    evenNums = evenNums.Take(countFirst);
                    Console.WriteLine($"[{string.Join(", ", evenNums)}]");
                }
            }  
            
            if (firstEvenorOdd.Equals("odd"))
            {
                var oddNums = numbers.Where(e => e % 2 != 0);
                
                if (countFirst > numbers.Count)
                {
                    Console.WriteLine("Invalid index");
                }
                else if (!oddNums.Any())
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    oddNums = oddNums.Take(countFirst);
                    Console.WriteLine($"[{string.Join(", ", oddNums)}]");
                }
            }  

           
        }

        private static void GetMinIndex(List<int> numbers, string minEvenOrOdd)
        {
            if (minEvenOrOdd.Equals("even"))
            {
                var evenNums = numbers.Where(e => e % 2 == 0);

                if (!evenNums.Any())
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    var maxEvenNumIndex = numbers.LastIndexOf(evenNums.Min()).ToString();
                    Console.WriteLine(maxEvenNumIndex);
                }
            }
            
            if (minEvenOrOdd.Equals("odd"))
            {
                var oddNums = numbers.Where(e => e % 2 != 0);

                if (!oddNums.Any())
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    var minOddNumIndex = numbers.LastIndexOf(oddNums.Min()).ToString();
                    Console.WriteLine(minOddNumIndex);
                }
            }
        }

        private static void GetMaxIndex(List<int> numbers, string maxEvenOrOdd)
        {
           
            if (maxEvenOrOdd.Equals("even"))
            {
                var evenNums = numbers.Where(e => e % 2 == 0);

                if (!evenNums.Any())
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    var maxEvenNumIndex = numbers.LastIndexOf(evenNums.Max()).ToString();
                    Console.WriteLine(maxEvenNumIndex);
                }
         
            }

            if (maxEvenOrOdd.Equals("odd"))
            {
                var oddNums = numbers.Where(e => e % 2 != 0);

                if (!oddNums.Any())
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    var maxOddNumIndex = numbers.LastIndexOf(oddNums.Max()).ToString();
                    Console.WriteLine(maxOddNumIndex);
                }
            }
        }

        public static List<int> ReturnExchangedElements(List<int> numbers, int indexExchange)
        {
           
            return numbers.Skip(indexExchange).Concat(numbers.Take(indexExchange)).ToList();
        }
    }
}