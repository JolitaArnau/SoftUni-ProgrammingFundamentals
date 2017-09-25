namespace ShellBound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ShellBound
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var shellBound = new Dictionary<string, HashSet<int>>();

            while (!line.Equals("Aggregate"))
            {
                var shellInformation = line.Split(' ');

                var region = shellInformation[0];
                var shellSize = int.Parse(shellInformation[1]);

                if (!shellBound.ContainsKey(region))
                {
                    shellBound[region] = new HashSet<int>();
                }

                shellBound[region].Add(shellSize);

                line = Console.ReadLine();
            }

            if (line.Equals("Aggregate"))
            {

                foreach (var shell in shellBound)
                {
                    var average = shell.Value.Sum() - ((shell.Value.Sum() / shell.Value.Count));

                    Console.WriteLine($"{shell.Key} -> {string.Join(", ", shell.Value)} ({average})");
                }
            }

            //Console.ReadKey();
        }
    }
}
