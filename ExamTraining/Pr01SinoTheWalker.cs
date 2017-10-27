using System;
using System.Collections.Generic;
using System.Globalization;

namespace Pr01SinoTheWalker
{
    public class Pr01SinoTheWalker
    {
        public static void Main()
        {
            var timeAsString = Console.ReadLine();
            DateTime startTime = DateTime.ParseExact(timeAsString, "HH:mm:ss", CultureInfo.InvariantCulture);
            double stepsCount = double.Parse(Console.ReadLine());
            double secondsPerStep = double.Parse(Console.ReadLine());

            double timeNeededInMins = (stepsCount * secondsPerStep) / 60;

            var arrivalTime = startTime.AddMinutes(timeNeededInMins);

            Console.WriteLine($"Time Arrival: {arrivalTime.ToString("HH:mm:ss")}");

        }
    }
}