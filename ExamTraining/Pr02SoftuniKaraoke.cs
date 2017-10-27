using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr02SoftuniKaraoke
{
    public class Pr02SoftuniKaraoke
    {
        public static void Main(string[] args)
        {
            var participants = Console
                .ReadLine()
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim())
                .ToArray();
            var songs = Console
                .ReadLine()
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(a => a.Trim())
                .ToArray();
            
            var performances = new Dictionary<string, HashSet<string>>();

            var performancesInput = Console.ReadLine();

            while (!performancesInput.Equals("dawn"))
            {
                var performaceTokens =
                    performancesInput.Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);

                var participant = performaceTokens[0];
                var song = performaceTokens[1];
                var award = performaceTokens[2];
               

                if (participants.Contains(participant) && songs.Contains(song))
                {
                    if (!performances.ContainsKey(participant))
                    {
                        performances[participant] = new HashSet<string>();
                    }
                    
                    var awards = performances[participant];

                    if (!awards.Contains(award))
                    {
                        awards.Add(award);
                    }
                }
                
                performancesInput = Console.ReadLine();
            }

            if (!performances.Any())
            {
                Console.WriteLine("No awards");
                
            }
            

            foreach (var performance in performances
                .OrderByDescending(a => a.Value.Count)
                .ThenBy(n => n.Key))
            {
                Console.WriteLine($"{performance.Key}: {performance.Value.Count} awards");
                
                foreach (var award in performance.Value.OrderBy(a => a))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}