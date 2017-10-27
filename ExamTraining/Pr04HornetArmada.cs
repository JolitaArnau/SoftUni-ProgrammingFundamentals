using System.Linq;

namespace Pr04HornetArmada
{
    using System;
    using System.Collections.Generic;

    public class Pr04HornetArmada
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            
            var legions = new Dictionary<string, long>();
            var soldiers = new Dictionary<string, Dictionary<string, long>>();

           
            for (int i = 0; i < n; i++)
            {
                var legionTokens = Console
                    .ReadLine()
                    .Split(new string[] {" = ", " -> ", ":"}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var lastActivity = long.Parse(legionTokens[0]);
                var legionName = legionTokens[1];
                var soldierType = legionTokens[2];
                var soldierCount = long.Parse(legionTokens[3]);

                if (!legions.ContainsKey(legionName))
                {
                    legions[legionName] = lastActivity;
                    soldiers.Add(legionName, new Dictionary<string, long>());
                }

                if (legions[legionName] < lastActivity)
                {
                    legions[legionName] = lastActivity;
                }

                if (!soldiers[legionName].ContainsKey(soldierType))
                {
                    soldiers[legionName][soldierType] = 0;
                }

                soldiers[legionName][soldierType] += soldierCount;
            }

            var query = Console.ReadLine();

            if (query.Contains("\\"))
            {
                var queryTokens = query.Split('\\').ToArray();
                var queryActivity = long.Parse(queryTokens[0]);
                var querySoldierType = queryTokens[1];
                
                // print legions and count of soldiers from given soldiert type, where lastactivity is lower than the given one
                // descending order by soldiers count

                foreach (var soldier in soldiers
                    .Where(s => s.Value.ContainsKey(querySoldierType))
                    .OrderByDescending(s => s.Value[querySoldierType]))
                {
                    if (legions[soldier.Key] < queryActivity)
                    {
                        Console.WriteLine($"{soldier.Key} -> {soldier.Value[querySoldierType]}");
                    }
                }

            }
            
            else
            {
                var querySoldierType = query;
                
                // print all legions from given soldier type with their last activity and legion name
                // descending order by last activity

                foreach (var activity in legions.OrderByDescending(a => a.Value))
                {
                    if (soldiers[activity.Key].ContainsKey(querySoldierType))
                    {
                        Console.WriteLine($"{activity.Value} : {activity.Key}");
                    }
                }
            }
        }
    }
}