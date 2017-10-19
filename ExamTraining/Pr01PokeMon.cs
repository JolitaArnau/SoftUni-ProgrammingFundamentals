namespace Pr01PokeMon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Pr01PokeMon
    {
        static void Main()
        {
            int power = int.Parse(Console.ReadLine()); // N
            int distance = int.Parse(Console.ReadLine()); // M
            int exhaustionFactor = int.Parse(Console.ReadLine()); // Y

            int targetsPoked = 0;

            int updatedPower = power;

            // start doing distance - power, until power becomes less than distance
            // if n / 2  = n / 2

            while (updatedPower >= distance)
            {
                if (updatedPower < distance)
                {
                    break;
                }

                else
                {
                    updatedPower -= distance;

                    if (updatedPower == power / 2)
                    {
                        updatedPower /= exhaustionFactor;
                    }
                   

                    targetsPoked++;
                }
            }

            Console.WriteLine(updatedPower);
            Console.WriteLine(targetsPoked);
        }
    }
}
