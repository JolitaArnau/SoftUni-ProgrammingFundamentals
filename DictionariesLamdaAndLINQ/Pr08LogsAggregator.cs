namespace Pr08LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Pr08LogsAggregator
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var aggregatedLog = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var logsStream = Console.ReadLine().Split().ToArray();
                var IP = logsStream[0];
                var name = logsStream[1];
                var sessionDuration = int.Parse(logsStream[2]);

                if (!aggregatedLog.ContainsKey(name))
                {
                    aggregatedLog[name] = new Dictionary<string, int>();
                }

                if (!aggregatedLog[name].ContainsKey(IP))
                {
                    aggregatedLog[name][IP] = sessionDuration;
                }
                else
                {
                    aggregatedLog[name][IP] += sessionDuration;
                }
                
            }

            var logsOrderedByUsername = aggregatedLog.OrderBy(u => u.Key);

            foreach (var user in logsOrderedByUsername)
            {
                var username = user.Key;
                var log = user.Value;
                var sessionDurationTotal = user.Value.Values.Sum();

                Console.Write($"{username}: {sessionDurationTotal} [");

                int commaCounter = 0;

                foreach (var entry in log.OrderBy(e => e.Key))
                {
                    Console.Write($"{entry.Key}");
                    if (commaCounter < user.Value.Count - 1)
                    {
                        Console.Write(", ");
                        commaCounter++;
                    }
                    else
                    {
                        Console.WriteLine("]");
                    }
                }
               
            }
        }
    }
}
