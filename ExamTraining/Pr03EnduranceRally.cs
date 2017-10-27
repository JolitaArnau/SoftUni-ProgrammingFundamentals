using System.Linq;

namespace Pr03EnduranceRally
{
    using System;
    using System.Collections.Generic;

    public class Pr03EnduranceRally
    {
        public static void Main()
        {
            var drivers = Console.ReadLine().Split().ToArray();

            var fuelZones = Console
                .ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var checkPoints = Console
                .ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            // if checkpoint -> add fuel, if not, substract


            foreach (var driver in drivers)
            {
                double initialFuel = driver[0];

                for (int i = 0; i < fuelZones.Length; i++)
                {
                    var currentZone = fuelZones[i];
                    
                    if (checkPoints.Contains(i))
                    {
                        initialFuel += currentZone;
                    }
                    else
                    {
                        initialFuel -= currentZone;
                    }

                    if (initialFuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }
                 
                }

                if (initialFuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {initialFuel:f2}");
                }
            }
        }
    }
}