namespace Pr07PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Pr07PopulationCounter
    {
        static void Main()
        {
            var report = new Dictionary<string, Dictionary<string, long>>();

            var line = Console.ReadLine();

            while (!line.Equals("report"))
            {
                var rawData = line.Split('|').ToArray();
                var cityName = rawData[0];
                var countryName = rawData[1];
                var cityPopulation = long.Parse(rawData[2]);

                if (!report.ContainsKey(countryName))
                {
                    report[countryName] = new Dictionary<string, long>();
                }
                report[countryName].Add(cityName, cityPopulation);

                line = Console.ReadLine();
            }

            var orderedReport = report.OrderByDescending(p => p.Value.Values.Sum());

            foreach (var country in orderedReport)
            {
                var countryName = country.Key;
                var totalPopulation = country.Value.Values.Sum();

                Console.WriteLine($"{countryName} (total population: {totalPopulation})");

                var citiesData = country.Value.OrderByDescending(p => p.Value);

                foreach (var city in citiesData)
                {
                    var cityName = city.Key;
                    var cityPopulation = city.Value;

                    Console.WriteLine($"=>{cityName}: {cityPopulation}");
                }
            }
        }
    }
}