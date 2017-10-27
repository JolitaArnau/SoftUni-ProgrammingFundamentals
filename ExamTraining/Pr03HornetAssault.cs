using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr03HornetAssault
{
    public class Pr03HornetAssault
    {
        public static void Main()
        {
            var beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            var hornetsPower = hornets.Sum();
            
          
            for (int i = 0; i < beehives.Count; i++)
            {
               
                if (beehives[i] < hornetsPower)
                {
                    beehives[i] -= beehives[i];
                }

                if (beehives[i] >= hornetsPower)
                {
                    beehives[i] -= hornetsPower;
                    hornets.RemoveAt(0);
                    hornetsPower = hornets.Sum();
                }
               
            }

            var leftBees = beehives.Where(b => b > 0).ToList();

            if (leftBees.Any())
            {
                Console.WriteLine(string.Join(" ", leftBees));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }

        }
    }
}