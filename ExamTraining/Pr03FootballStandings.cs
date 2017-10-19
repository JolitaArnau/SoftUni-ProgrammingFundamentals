using System.Linq;

namespace Pr03FootballStandings
{
    using System;
    using System.Collections.Generic;
    
    public class ProPr03FootballStandingsgram
    {
        public static void Main()
        {
            var key = Console.ReadLine();

            var line = Console.ReadLine();
            
            var scoreTable = new Dictionary<string, int>();
            var goalTable = new Dictionary<string, int>();

            while (!line.Equals("final"))
            {
                var scores = line.Split();
                
                var teamA = scores[0];
                var teamB = scores[1];
                
                var result = scores[2].Split(':');
                var goalA = int.Parse(result[0]);
                var goalB = int.Parse(result[1]);

                if (teamA.Contains(key))
                {
                    int leftNameIndex = teamA.IndexOf(key) + key.Length;
                    int rightNameIndex = teamA.LastIndexOf(key);

                    teamA = teamA.Substring(leftNameIndex, rightNameIndex - leftNameIndex);

                    var charrArr = teamA.ToCharArray();
                    Array.Reverse(charrArr);
                    teamA = new string(charrArr);
                    teamA = teamA.ToUpper();

                    if (!goalTable.ContainsKey(teamA))
                    {
                        goalTable[teamA] = goalA;
                    }
                    else
                    {
                        goalTable[teamA] += goalA;
                    }

                    if (!scoreTable.ContainsKey(teamA))
                    {
                        scoreTable[teamA] = 0;
                    }
                }

                if (teamB.Contains(key))
                {
                     int leftNameIndex = teamB.IndexOf(key) + key.Length;
                     int rightNameIndex = teamB.LastIndexOf(key);
                    
                     teamB = teamB.Substring(leftNameIndex, rightNameIndex - leftNameIndex);
                    
                    var charrArr = teamB.ToCharArray();
                    Array.Reverse(charrArr);
                    teamB = new string(charrArr);
                    teamB = teamB.ToUpper();
                    
                    if (!goalTable.ContainsKey(teamB))
                    {
                        goalTable[teamB] = goalB;
                    }
                    else
                    {
                        goalTable[teamB] += goalB;
                    }

                    if (!scoreTable.ContainsKey(teamB))
                    {
                        scoreTable[teamB] = 0;
                    }
                }

                if (goalA > goalB)
                {
                    scoreTable[teamA] += 3;
                }

                if (goalB > goalA)
                {
                    scoreTable[teamB] += 3;
                }

                if (goalA == goalB)
                {
                    scoreTable[teamA] += 1;
                    scoreTable[teamB] += 1;
                }
                
                line = Console.ReadLine();
            }

            int place = 1;

            Console.WriteLine("League standings: ");

            foreach (var score in scoreTable.OrderByDescending(s => s.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{place}. {score.Key} {score.Value}");

                place++;
            }
            
            Console.WriteLine("Top 3 scored goals: ");
            
            foreach (var goal in goalTable.OrderByDescending(g => g.Value).Take(3))
            {
                Console.WriteLine($"- {goal.Key} -> {goal.Value}");
            }
        }
    }
}