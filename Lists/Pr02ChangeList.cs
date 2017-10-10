namespace Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Pr02ChangeList
    {
        static void Main()
        {

            var numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            var line = Console.ReadLine();

            //var command = string.Empty;

            while (!(line.Equals("Even") || line.Equals("Odd")))
            {
                var tokens = line.Split();

                var command = tokens[0];

                if (command.Equals("Delete"))
                {
                    var element = int.Parse(tokens[1]);

                    numbers.RemoveAll(e => e == element);
                }

                if (command.Equals("Insert"))
                {
                    var element = int.Parse(tokens[1]);
                    var index = int.Parse(tokens[2]);
                    numbers.Insert(index, element);
                }

                line = Console.ReadLine();
            }

            foreach (var num in numbers)
            {
                if (line.Equals("Even"))
                {
                    if (num % 2 == 0)
                    {
                        Console.Write(num + " ");
                    }
                }

                if (line.Equals("Odd"))
                {
                    if (num % 2 != 0)
                    {
                        Console.Write(num + " ");
                    }
                }
            }



            //Console.ReadKey();
        }
    }
}
